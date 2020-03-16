using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Backup {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            RefreshList();
        }

        private void Main_Click(object sender, EventArgs e) {
            DeviceList.ClearSelected();
        }

        private void CloseApp_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void Title_Click(object sender, EventArgs e) {
            SettingsPage settings = new SettingsPage();
            settings.ShowDialog(this);
        }

        private void Refresh_Click(object sender, EventArgs e) {
            RefreshList();
        }

        private async void RefreshList() {
            List<string> device = new List<string>();
            try {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                await Task.Delay(1);    // Delay 1ms to keep "searcher.Get()" from getting exception.
                // Get removable and fixed drives letter which are using USB.
                foreach (ManagementObject queryObj in searcher.Get()) {
                    if (queryObj["InterfaceType"].ToString() == "USB" || queryObj["InterfaceType"].ToString() == "SCSI") {
                        foreach (ManagementObject b in queryObj.GetRelated("Win32_DiskPartition")) {
                            foreach (ManagementBaseObject c in b.GetRelated("Win32_LogicalDisk")) {
                                device.Add(string.Format("{0}" + "\\", c["Name"].ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            DeviceList.Items.Clear();
            foreach (DriveInfo d in DriveInfo.GetDrives()) {
                if (device.Contains(d.Name)) {
                    string volumeLabel = d.VolumeLabel;
                    if (volumeLabel.Length >= 18) {
                        volumeLabel = volumeLabel.Remove(15, 3) + "...";
                    }
                    long used = d.TotalSize - d.AvailableFreeSpace;
                    DeviceList.Items.Add(string.Format("{0, -3} {1, -15} {2, 12}", d.Name, volumeLabel, UnitConversion(used) + " used"));
                }
            }
            if (DeviceList.Items.Count == 0) {
                DeviceList.Items.Add("*There's no device here*");
            }
        }

        private string UnitConversion(long space) {
            float result;
            if (space / (1024 * 1024 * 1024) > 1) {
                result = space / (1024 * 1024);
                return $"{result} GB";
            }
            else if (space / (1024 * 1024) > 1) {
                result = space / (1024 * 1024);
                return $"{result} MB";
            }
            else if (space / 1024 > 1) {
                result = space / 1024;
                return $"{result} KB";
            }
            else {
                return $"{space} bytes";
            }
        }

        protected override void WndProc(ref Message m) {
            const int DeviceChanged = 0x219;
            const int DeviceArrival = 0x8000;
            const int DeviceRemoveComplete = 0x8004;
            try {
                if (m.Msg == DeviceChanged) {
                    switch (m.WParam.ToInt32()) {
                        // When a device is arrival.
                        case DeviceArrival:
                            RefreshList();
                            break;
                        // When a device is being removed completely.
                        case DeviceRemoveComplete:
                            RefreshList();
                            break;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            base.WndProc(ref m);
        }
    }
}
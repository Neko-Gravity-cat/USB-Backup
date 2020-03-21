using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace USB_Backup {
    public partial class Main : Form {

        readonly List<DriveInfo> driveInfos = new List<DriveInfo>();
        readonly Queue queue = new Queue();

        public Main(string[] args) {
            InitializeComponent();
            if (!args.Contains("NOconsole") || System.Diagnostics.Debugger.IsAttached) {
                ConsoleControl consoleControl = new ConsoleControl();
                Task.Run(() => consoleControl.ReadConsole(this));
            }
        }

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            queue.main = this;
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

        private void DeviceList_DoubleClick(object sender, EventArgs e) {
            queue.QueueAdd(driveInfos[DeviceList.SelectedIndex]);
        }

        public async void RefreshList(bool newInput = false) {
            DeviceList.Items.Clear();
            foreach (string d in await GetList(newInput)) {
                DeviceList.Items.Add(d);
            }
            if (DeviceList.Items.Count <= 0) {
                DeviceList.Items.Add("*There's no device here*");
            }
        }

        public async Task<List<string>> GetList(bool newInput = false) {
            List<string> device = new List<string>();
            List<string> list = new List<string>();
            try {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                await Task.Delay(5);    // Delay 1ms to keep "searcher.Get()" from getting exception.
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
                Console.WriteLine("Device search error");
                Console.WriteLine(ex);
            }
            driveInfos.Clear();
            list.Clear();
            foreach (DriveInfo d in DriveInfo.GetDrives()) {
                if (device.Contains(d.Name)) {
                    driveInfos.Add(d);
                    string volumeLabel = d.VolumeLabel;
                    if (volumeLabel.Length >= 18) {
                        volumeLabel = volumeLabel.Remove(15, 3) + "...";
                    }
                    long used = d.TotalSize - d.AvailableFreeSpace;
                    string state;
                    if (queue.Done.FindIndex(a => a.Name == d.Name) >= 0) {
                        state = "✔";
                    }
                    else if (queue.Working.FindIndex(a => a.Name == d.Name) >= 0) {
                        state = "●";
                    }
                    else {
                        state = "◆";
                        if (newInput && Properties.Settings.Default.Auto) {
                            queue.QueueAdd(d);
                        }
                    }
                    string info = string.Format("{0, -3} {1, -15} {2, 12} {3, 1}", d.Name, volumeLabel, UnitConversion(used) + " used", state);
                    list.Add(string.Format(info));
                }
            }
            if (list.Count == 0) {
                list.Add("*There's no device here*");
            }
            return list;
        }

        private string UnitConversion(long space) {
            float result;
            if (space / (1024 * 1024 * 1024) > 1) {
                result = space / (1024 * 1024 * 1024);
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
                            queue.DoneClear();
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
                Console.WriteLine("WndProc error");
                Console.WriteLine(ex.Message);
            }
            base.WndProc(ref m);
        }
    }
}
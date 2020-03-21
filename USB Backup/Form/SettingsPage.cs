using System;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace USB_Backup {
    public partial class SettingsPage : Form {
        readonly Encryption encryption = new Encryption();

        public SettingsPage() {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e) {
            Password.MaxLength = 29;
            Password.Text = encryption.PasswordRead();
        }

        private void SettingsPage_FormClosing(object sender, FormClosingEventArgs e) {
            PasswordSave();
        }

        private void SettingsPage_Click(object sender, EventArgs e) {
            PasswordSave();
        }

        private void CloseApp_Click(object sender, EventArgs e) {
            Close();
        }

        private void LimitOn_Click(object sender, EventArgs e) {
            Limit.Enabled = LimitOn.Value;
        }

        private void PasswordShow_Click(object sender, EventArgs e) {
            if (PasswordShow.Value) {
                Password.PasswordChar = '\0';
            }
            else {
                Password.PasswordChar = '●';
            }
        }

        private void Reset_Click(object sender, EventArgs e) {
            string resetMessage = "Are you sure you want to reset all the settings?\r\n(Expect password)";
            if (MessageBox.Show(resetMessage, "Reset Settings", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                Properties.Settings.Default.Auto = false;
                Properties.Settings.Default.Compress = false;
                Properties.Settings.Default.Limit = 16384;
                Properties.Settings.Default.LimitOn = true;
                Properties.Settings.Default.Overwrite = true;
                Properties.Settings.Default.Path = @"C:\Windows\Temp\USB\";
                Properties.Settings.Default.Startup = false;
            }
        }

        private void PasswordSave() {
            if (Password.Text.Trim() != string.Empty) {
                Properties.Settings.Default.Password = Convert.ToBase64String(encryption.EncryptStringToBytes_Aes(Password.Text.Trim()));
            }
            else {
                Properties.Settings.Default.Password = string.Empty;
            }
        }
    }
}
using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace USB_Backup {
    public partial class SettingsPage : Form {

        public SettingsPage() {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e) {
            Password.MaxLength = 29;
            Password.Text = PasswordRead();
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
                Encryption encryption = new Encryption();
                using (Aes aes = Aes.Create()) {
                    aes.Key = GetKeyIV(true);
                    aes.IV = GetKeyIV(false);
                    Properties.Settings.Default.Password = Convert.ToBase64String(encryption.EncryptStringToBytes_Aes(Password.Text.Trim(), aes.Key, aes.IV));
                }
            }
            else {
                Properties.Settings.Default.Password = string.Empty;
            }
        }

        private string PasswordRead() {
            if (Properties.Settings.Default.Password.Trim() != string.Empty) {
                Encryption encryption = new Encryption();
                using (Aes aes = Aes.Create()) {
                    aes.Key = GetKeyIV(true);
                    aes.IV = GetKeyIV(false);
                    byte[] password = Convert.FromBase64String(Properties.Settings.Default.Password);
                    return encryption.DecryptStringFromBytes_Aes(password, aes.Key, aes.IV);
                }
            }
            else {
                return string.Empty;
            }
        }

        private byte[] GetKeyIV(bool getKey) {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider()) {
                if (getKey) {
                    string key = string.Empty;
                    foreach (var t in Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes("USB Backup!")))) {
                        key += t;
                        if (key.Length >= 32) {
                            break;
                        }
                    }
                    return Encoding.UTF8.GetBytes(key);
                }
                else {
                    string IV = string.Empty;
                    foreach (var t in Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes("Backup your USB devices!")))) {
                        IV += t;
                        if (IV.Length >= 16) {
                            break;
                        }
                    }
                    return Encoding.UTF8.GetBytes(IV);
                }
            }
        }
    }
}
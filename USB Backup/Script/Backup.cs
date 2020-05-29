using System;
using System.IO;
using System.Collections.Generic;
using Ionic.Zip;
using System.Text;
using System.Threading.Tasks;

namespace USB_Backup {

    public class Backup {
        private static bool _isRunning;
        public bool IsRunning {
            get => _isRunning;
            set => _isRunning = value;
        }

        public async void Run(DriveInfo drive, Main main) {
            Console.WriteLine($@"Running ""{drive.Name}""");
            Queue queue = new Queue();
            IsRunning = true;
            queue.Working.Add(drive);
            main.RefreshList();
            bool hasError = false;
            string destination = Path.Combine(Properties.Settings.Default.Path, drive.VolumeLabel);
            try {
                Directory.CreateDirectory(destination);
                foreach (string filename in Directory.EnumerateFiles(drive.Name, "*", SearchOption.AllDirectories)) {
                    try {
                        using (FileStream SourceStream = File.Open(filename, FileMode.Open)) {
                            string fullDestination = Path.Combine(destination, Path.GetDirectoryName(filename).Replace(drive.Name, string.Empty));
                            Directory.CreateDirectory(fullDestination);
                            using (FileStream DestinationStream = File.Create(fullDestination + filename.Substring(filename.LastIndexOf('\\')))) {
                                await SourceStream.CopyToAsync(DestinationStream);
                            }
                        }
                    }
                    catch (Exception e) {
                        Console.WriteLine("Backup loop error");
                        Console.WriteLine(e);
                        hasError = true;
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine("Main backup error");
                Console.WriteLine(e);
                hasError = true;
            }
            if (Properties.Settings.Default.Compress) {
                Console.WriteLine("Compress start");
                try {
                    await Task.Run(() => Compress(drive, destination));
                }
                catch (Exception e) {
                    Console.WriteLine("Compress error");
                    Console.WriteLine(e);
                    hasError = true;
                }
                Console.WriteLine("Compress finished");
            }
            if (hasError) {
                Console.WriteLine($@"Running finished ""{drive.Name}"" (has error)");
            }
            else {
                Console.WriteLine($@"Running finished ""{drive.Name}""");
            }
            queue.Working.Clear();
            queue.Done.Add(drive);
            IsRunning = false;
            main.RefreshList();
            queue.RunNext();
        }

        private void Compress(DriveInfo drive, string destination) {
            using (ZipFile zip = new ZipFile()) {
                Encryption encryption = new Encryption();
                string password = encryption.PasswordRead();
                if (!string.IsNullOrEmpty(password)) {
                    zip.Password = password;
                }
                zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                zip.AlternateEncoding = Encoding.UTF8;
                zip.AddDirectory(destination);
                zip.Save(Path.Combine(Properties.Settings.Default.Path, drive.VolumeLabel + ".zip"));
            }
        }
    }

    public class Queue {
        public Main main;
        readonly Backup backup = new Backup();
        readonly List<DriveInfo> queued = new List<DriveInfo>();
        private static List<DriveInfo> _done = new List<DriveInfo>();
        public List<DriveInfo> Done {
            get => _done;
            set => _done = value;
        }
        private static List<DriveInfo> _working = new List<DriveInfo>();
        public List<DriveInfo> Working {
            get => _working;
            set => _working = value;
        }

        public void QueueAdd(DriveInfo drive) {
            Console.WriteLine($@"Queue added ""{drive.Name}""");
            if (!queued.Contains(drive)) {
                queued.Add(drive);
            }
            RunNext();
        }

        public void RunNext() {
            if (queued.Count > 0 && !backup.IsRunning) {
                backup.Run(queued[queued.Count - 1], main);
                queued.RemoveAt(queued.Count - 1);
            }
        }

        public void DoneClear() {
            foreach (DriveInfo d in Done.ToArray()) {
                if (Array.IndexOf(DriveInfo.GetDrives(), d) < 0) {
                    Done.Remove(d);
                }
            }
        }
    }
}
using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace USB_Backup {
    class ConsoleControl {
        readonly Encryption encryption = new Encryption();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        public void ReadConsole(Main main) {
            bool consoleOn = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"Console opened. Type ""?"" to get help.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Empty);
            while (consoleOn) {
                string input = Console.ReadLine();
                if (input.StartsWith("-")) {
                    input = input.Trim().Substring(1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (input) {
                        case "close console":
                            Console.WriteLine("Console closing...");
                            FreeConsole();
                            consoleOn = false;
                            break;
                        case "close app":
                            Application.Exit();
                            break;
                        case "hide":
                            Console.WriteLine("Application hiding...");
                            main.Hide();
                            break;
                        case "list":
                            foreach (string i in main.GetList().Result) {
                                if (i.Length > 25) {
                                    Console.WriteLine(i.Remove(32, 2));
                                }
                                else {
                                    Console.WriteLine(i);
                                }
                            }
                            break;
                        case "set password":
                            string getPassword = GetAndComfirmPassword();
                            if (getPassword != string.Empty) {
                                Properties.Settings.Default.Password = Convert.ToBase64String(encryption.EncryptStringToBytes_Aes(getPassword));
                            }
                            else {
                                Properties.Settings.Default.Password = string.Empty;
                            }
                            break;
                        case "show password":
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (encryption.PasswordRead() != string.Empty) {
                                Console.WriteLine(encryption.PasswordRead());
                            }
                            else {
                                Console.WriteLine("*Empty*");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            Invalid();
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (input == "?") {

                }
                else {
                    Invalid();
                }
                if (!consoleOn) {
                    break;
                }
                Console.WriteLine(string.Empty);
            }
        }

        private void Invalid() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"Invalid command. Type ""?"" to get help.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private string GetAndComfirmPassword() {
            GetPassword:
            string password1 = GetConsolePassword();
            string password2 = GetConsolePassword();
            if (password1 != password2) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Those passwords did not match, please try again");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);
                goto GetPassword;
            }
            else {
                return password2;
            }
        }

        private static string GetConsolePassword(bool second = false) {
            StringBuilder sb = new StringBuilder();
            while (true) {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter) {
                    if(sb.ToString().Trim() == string.Empty) {
                        Console.WriteLine("*Empty*");
                    }
                    else if (!second) {
                        Console.WriteLine();
                    }
                    break;
                }
                if (cki.Key == ConsoleKey.Backspace) {
                    if (sb.Length > 0) {
                        Console.Write("\b\0\b");
                        sb.Length--;
                    }
                    continue;
                }
                Console.Write('*');
                sb.Append(cki.KeyChar);
            }
            return sb.ToString().Trim();
        }
    }
}
using System;
using System.Runtime.InteropServices;

namespace USB_Backup {
    class ConsoleControl {
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
                        case "hide":
                            Console.WriteLine("Application hiding...");
                            main.Hide();
                            break;
                        case "list":
                            foreach (string i in main.GetList().Result) {
                                Console.WriteLine(i.Remove(32, 2));
                            }
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
    }
}
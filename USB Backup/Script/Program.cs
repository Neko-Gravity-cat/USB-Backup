using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace USB_Backup {
    static class Program {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        [STAThread]
        static void Main(string[] args) {
            if (!args.Contains("Console") && !System.Diagnostics.Debugger.IsAttached) {
                FreeConsole();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(args));
        }
    }
}

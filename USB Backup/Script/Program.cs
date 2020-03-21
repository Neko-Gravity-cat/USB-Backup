using System;
using System.Linq;

using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace USB_Backup {
    static class Program {

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        [STAThread]
        static void Main(string[] args) {
            if (args.Contains("NOconsole") && !System.Diagnostics.Debugger.IsAttached) {
                FreeConsole();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(args));
        }
    }
}

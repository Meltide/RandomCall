using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCall
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 启用高 DPI 支持
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDpiAwareness();
            }

            Application.Run(new MainForm());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        private static void SetProcessDpiAwareness()
        {
            try
            {
                SetProcessDPIAware();
            }
            catch
            {
                // 忽略异常
            }
        }
    }
}

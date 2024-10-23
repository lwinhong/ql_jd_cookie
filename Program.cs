using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Get
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var dir = Path.Combine(Application.StartupPath, "JD_Get.exe.WebView2");
            if (Directory.Exists(dir))
                Directory.Delete(dir, true);
            Application.Run(new Form1());
        }
    }
}

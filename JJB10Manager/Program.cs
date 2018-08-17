using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJB10Manager
{
    static class Program
    {
        public static string AppName = ConfigurationSettings.AppSettings["AppName"];
        public static string Ip = ConfigurationSettings.AppSettings["Ip"];
        public static string Port = ConfigurationSettings.AppSettings["Port"];
        public static string connStr = ConfigurationSettings.AppSettings["connStr"];
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

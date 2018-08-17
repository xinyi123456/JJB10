using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace JJB10Manager
{
    class Win32
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessageString(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static string ReadIni(string Section, string Key, string filepath)
        {
            StringBuilder temp = new StringBuilder(4000);
            int i = GetPrivateProfileString(Section, Key, "", temp, 4000, filepath);
            return temp.ToString();
        }

        public static long WriteIni(string section, string key, string val, string filePath)
        {
            long i = WritePrivateProfileString(section, key, val, filePath);
            return i;
        }

        public static void WriteLogFile(string Message)
        {
            StreamWriter sw = null;
            try
            {
                DirectoryInfo dif = new DirectoryInfo((System.Windows.Forms.Application.StartupPath + "\\Log"));
                if (!dif.Exists)
                {
                    dif.Create();
                }

                string FileName = System.Windows.Forms.Application.StartupPath + "\\Log\\File_" + DateTime.Now.ToString("yyyyMMdd") + ".LOG";
                if (File.Exists(FileName))
                {
                    sw = File.AppendText(FileName);
                    sw.WriteLine(Message + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sw.Close();
                    sw.Dispose();
                }
                else
                {
                    sw = File.CreateText(FileName);
                    sw.WriteLine(Message + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sw.Close();
                    sw.Dispose();
                }
            }
            catch
            {
                try
                {
                    if (sw != null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                }
                catch
                {
                }
            }
        }

        public static string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return "8" + result.ToString();
        }
    }
}

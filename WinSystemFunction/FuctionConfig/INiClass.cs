using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinSystemFunction.FuctionConfig
{
    public  class INiClass
    {

        public static string path = System.IO.Path.GetFullPath("Parameter.ini");
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string GetINI(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, path);
            return temp.ToString();
        }
        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public static void WriteINI(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }


        public bool ExistINIFile()
        {
            return File.Exists(path);
        }

        

        public static string  A {
            get
            {
                try
                {
                    string val = GetINI("Configuration", "A");
                    return val;
                }
                catch (Exception)
                {
                    return "";
                }
            }
            set { WriteINI("Configuration", "A", value); }

        }





    }
}

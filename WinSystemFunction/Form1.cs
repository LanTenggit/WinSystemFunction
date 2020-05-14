using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
        }



        /// <summary> 
        /// 开机启动项 
        /// </summary> 
        /// <param name=\"Started\">是否启动</param> 
        /// <param name=\"name\">启动值的名称</param> 
        /// <param name=\"path\">启动程序的路径</param> 
        public static void RunWhenStart(bool Started, string name, string path)
        {
            RegistryKey HKLM = Registry.LocalMachine;
            RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\");
            if (Started == true)
            {
                try
                {
                    Run.SetValue(name, path);
                    HKLM.Close();
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Run.DeleteValue(name);
                    HKLM.Close();
                }
                catch (Exception)
                {
                    // 
                }
            }
        }


        /// <summary>  
        /// 更改是否开机自启动
        /// </summary>  
        /// <param name="isAutoStartup">是否开机自启动</param>  
        public static void ChangeAutoStartUp(bool isAutoStartup,string ExePath,string ExeName)
        {
            string executablePath = Application.ExecutablePath; //可执行文件路径
            string programName = Path.GetFileNameWithoutExtension(executablePath); //程序名称

            executablePath = ExePath;
            programName = ExeName;
            //自启动注册表路径
            string registryRunPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            try
            {
                bool isAdmin = IsAdmin();
                //判断当前用户是否是管理员
                RegistryKey registryKey = isAdmin
                    ? Registry.LocalMachine.CreateSubKey(registryRunPath)
                    : Registry.CurrentUser.CreateSubKey(registryRunPath);
                if (registryKey == null) return;
                if (isAutoStartup)
                {
                    registryKey.SetValue(programName, executablePath); //开启自启动
                }
                else
                {
                    registryKey.DeleteValue(programName, false); //关闭自启动
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// 判断程序是否以管理员身份运行
        /// </summary>
        /// <returns></returns>
        private static bool IsAdmin()
        {
            bool result = false;
            try
            {
                System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                result = principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            catch (Exception e)
            {
                //捕获异常;
            }
            return result;
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_sure_Click(object sender, EventArgs e)
        {
            try
            {
                string ExeName = this.textBox1.Text.Trim();
                string ExePath = this.textBox2.Text.Trim();

                bool Exebool = true;
                if (this.radioButton1.Checked)
                {
                    Exebool = true;
                }
                else
                {
                    Exebool = false;
                }
                ChangeAutoStartUp(Exebool, ExePath, ExeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_cancel_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = string.Empty;

            this.textBox2.Text = string.Empty;
        }
    }
}

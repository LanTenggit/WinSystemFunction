using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class ProcessOperate : Form
    {
        public ProcessOperate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 进程保护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string processStr = this.textBox1.Text;
            string ProcessName = this.textBox2.Text;

            Process newProcess = new Process();
            string pathName = "";
            pathName = processStr;
            pathName += "\\"+ ProcessName;
            newProcess.StartInfo.WorkingDirectory = @pathName;//用这个指定路径
            newProcess.StartInfo.FileName = ProcessName;
            newProcess.StartInfo.UserName = "";
            Process.Start(Application.StartupPath + "\\"+ ProcessName);


        }
        /// <summary>
        /// 进程销毁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            string Proname = this.textBox2.Text;

            Process[] process = Process.GetProcesses();

            for (int i = 0; i < process.Count(); i++)
            {

                if (process[i].ProcessName== Proname)
                {

                    process[i].Kill();

                }
            }

        }
        /// <summary>
        /// 主页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}

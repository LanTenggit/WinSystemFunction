using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 开机启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        /// <summary>
        /// 文件操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FileMoveCopyDelete file = new FileMoveCopyDelete();
            file.Show();
            this.Hide();
        }
        /// <summary>
        /// 进程保护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            ProcessOperate operate = new ProcessOperate();
            operate.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileNotUpdateOrNotDelete file = new FileNotUpdateOrNotDelete();
            file.Show();
            this.Hide();
        }
       /// <summary>
       /// 文件加密
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            FileEncryption fileEncryption = new FileEncryption();
            fileEncryption.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace WinSystemFunction
{
    public partial class 字符MD5加密 : Form
    {
        public 字符MD5加密()
        {
            InitializeComponent();
        }
        /// <summary>
        /// j加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string str = this.textBox1.Text;

            this.textBox2.Text = Common.MD5.MD5Encrypt(str);

        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string str = this.textBox4.Text;

            this.textBox3.Text = Common.MD5.MD5Decrypt(str);
        }
    }
}

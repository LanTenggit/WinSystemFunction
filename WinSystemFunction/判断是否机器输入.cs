using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class 判断是否机器输入 : Form
    {
        public 判断是否机器输入()
        {
            InitializeComponent();
        }

        private void text_Load(object sender, EventArgs e)
        {
            textBox1.MouseClick += new MouseEventHandler(textBox1_MouseClick);
            //textBox1.LostFocus += new EventHandler(txt_LostFocus); //失去焦点后发生事件
            textBox1.GotFocus += new EventHandler(txt_GotFocus);  //获取焦点前发生事件


            Thread th_jishi = new Thread(TongjiTime);
            th_jishi.Start();
        }


        bool IsStartTongJiTime = false;

        void textBox1_MouseClick(object sender, EventArgs e)
        {
            IsStartTongJiTime = true;

            //textBox1.Focus();

            //Thread.Sleep(1000);

            //textBox2.Focus();



        }

        void txt_LostFocus(object sender, EventArgs e)
        {


            //string a = textBox1.Text;

            //MessageBox.Show("2");





        }

        void txt_GotFocus(object sender, EventArgs e)
        {
            IsStartTongJiTime = true;



        }

        private void text_Activated(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        /// <summary>
        /// 1S后切换焦点
        /// </summary>
        public void TongjiTime()
        {
            while(true)
            {
                Thread.Sleep(500);
                if (IsStartTongJiTime)
                {
                    Thread.Sleep(1000);

                    this.Invoke(new Action(() =>
                    {

                        this.textBox2.Focus();

                    }));
                }
                IsStartTongJiTime = false;
            }
        }

        private void 判断是否机器输入_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Environment.Exit(0);

        }
    }
}

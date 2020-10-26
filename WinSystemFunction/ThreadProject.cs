using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WinSystemFunction.FuctionConfig;

namespace WinSystemFunction
{
    public partial class ThreadProject : Form
    {
        public ThreadProject()
        {
            InitializeComponent();

            TextBox.CheckForIllegalCrossThreadCalls = false;

        }


        object obc = new object();
        private void ThreadProject_Load(object sender, EventArgs e)
        {
            this.textBox1.ScrollBars = ScrollBars.Both;
            this.textBox2.ScrollBars = ScrollBars.Both;

            Thread th_readA = new Thread(new ParameterizedThreadStart(FuncA));
            th_readA.Start("123");

            Thread th_readB= new Thread(new ParameterizedThreadStart(FuncB));
            th_readB.Start("123");

        }



        public void FuncA(Object c)
        {
            while (true)
            {
                Thread.Sleep(1000);


                //this.Invoke(new Action(() =>
                //{

                int a = 1;
                while (a == 1)
                {
                    //Monitor.Enter(obc);
                    INiClass.A = "A";
                    this.textBox1.Text = this.textBox1.Text.Insert(0, "A" + DateTime.Now.ToString() + INiClass.A + "\r\n");
                    //Thread.Sleep(100);
                    INiClass.A = "B";
                    this.textBox1.Text = this.textBox1.Text.Insert(0, "A" + DateTime.Now.ToString() + INiClass.A + "\r\n");
                    //}));
                    
                    //Monitor.Exit(obc);
                }


            }
         
          

        }

        public void FuncB(Object c)
        {

            while (true)
            {
                Thread.Sleep(1000);
                Monitor.Enter(obc);
                INiClass.A = "D";
                this.textBox2.Text = this.textBox2.Text.Insert(0, "==>" + DateTime.Now.ToString() + INiClass.A + "\r\n");
                Thread.Sleep(100);
                INiClass.A = "E";
                this.textBox2.Text = this.textBox2.Text.Insert(0, "==>" + DateTime.Now.ToString() + INiClass.A + "\r\n");
               
                Monitor.Exit(obc);
            }

        }

        private void ThreadProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}

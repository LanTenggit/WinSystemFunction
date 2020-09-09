using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class MoveHouse : Form
    {
        public MoveHouse()
        {
            InitializeComponent();
            ///捕捉错误线程调用
            Label.CheckForIllegalCrossThreadCalls = false;
        
          //  richTextBox2.ScrollBars = ScrollBars.Vertical;
        }

        private void MoveHouse_Load(object sender, EventArgs e)
        {
            SetPos();

            Thread th_Point = new Thread(PointFunc);
            th_Point.Start();
        }
        [DllImport("User32.dll")]
        ///设置鼠标的坐标
        private static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起      
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //模拟鼠标滚轮滚动操作，必须配合dwData参数
        const int MOUSEEVENTF_WHEEL = 0x0800;

        private static void SetPos()
        {

        }
        /// <summary>
        /// 移动并点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int dx = 334;
            int dy = 633;
            dx = Convert.ToInt32(this.tb_X.Text);
            dy = Convert.ToInt32(this.tb_Y.Text);

            SetCursorPos(dx, dy);
            mouse_event(MOUSEEVENTF_LEFTDOWN, dx, dy, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, dx, dy, 0, 0);
        }


       /// <summary>
       /// 获取鼠标的坐标
       /// </summary>
        public void PointFunc() {

            while (true)
            {
                Thread.Sleep(200);
                Point p1 = MousePosition;
                this.label1.Text = "X:" + p1.X;
                this.label2.Text = "Y:" + p1.Y;


                //this.Invoke(new Action(() =>
                //{
                //    Point p1 = MousePosition;
                //    this.label1.Text = "X:" + p1.X;
                //    this.label2.Text = "Y:" + p1.Y;

                //}));
            }
        }

        private void MoveHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}

  

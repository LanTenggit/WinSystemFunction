using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class 内存清理 : Form
    {
        public 内存清理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearMemory();
        }

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        private void 内存清理_Load(object sender, EventArgs e)
        {
           
            Thread th_jietu = new Thread(JieTu);
            th_jietu.Start();


        }



        public void JieTu() {

            while (true)
            {
                Thread.Sleep(200);


                //获得当前屏幕的分辨率   
                Screen scr = Screen.PrimaryScreen;
                Rectangle rc = scr.Bounds;
                int iWidth = rc.Width;
                int iHeight = rc.Height;
                //创建一个和屏幕一样大的Bitmap  
                Image myImage = new Bitmap(iWidth, iHeight);
                //从一个继承自Image类的对象中创建Graphics对象  
                Graphics g = Graphics.FromImage(myImage);
                //抓屏并拷贝到myimage里 
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
                //保存为文件 
                //MessageBox.Show("截图成功！文件保存路径为:" + imgpath);
                string saveimgPath = Path.GetFullPath("images") + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                myImage.Save(saveimgPath);



            }



        }
    }
}

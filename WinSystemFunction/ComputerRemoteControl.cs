using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class ComputerRemoteControl : Form
    {
        public ComputerRemoteControl()
        {
            InitializeComponent();
        }

        private void ComputerRemoteControl_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 任务管理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_task_Click(object sender, EventArgs e)
        {
            Process process1 = new Process();
            process1.StartInfo.FileName = @"C:\WINDOWS\system32\taskmgr.exe";
            process1.Start();
        }

  
        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_cancellation_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-l");

        }
        /// <summary>
        /// /关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_close_Click(object sender, EventArgs e)
        {
            int time = 3;
        
            DialogResult dlResult = MessageBox.Show("确实要关闭电源吗？", "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlResult == DialogResult.Yes)
            {
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "shutdown.exe";
                ps.Arguments = "-s -t " + time;// -s -t 00
                Process.Start(ps);

            }

            //string Ip = tb_IP.Text;
            //string str = "关闭计算机";
            //Result(Ip, str);


        }
        /// <summary>
        /// 重启
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_restart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "shutdown.exe";
            /////关机
            //ps.Arguments = "-s -t 1";
            ////重启
            ps.Arguments = "-r -t 1";
            Process.Start(ps);
        }

        /// <summary>
        /// 控制计算机
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Result(string ip,string str) {

            string resultstr = "";
            //定义连接远程计算机的一些选项
            ConnectionOptions options = new ConnectionOptions();
            options.Username = "administrator";
            options.Password = "Btmu@123";
            ManagementScope scope = new ManagementScope("\\\\" + ip + "\\root\\cimv2", options);
            try
            {
                //用给定管理者用户名和口令连接远程的计算机
                scope.Connect();
                ObjectQuery oq = new ObjectQuery("select * from win32_OperatingSystem");
                ManagementObjectSearcher query1 = new ManagementObjectSearcher(scope, oq);
                ManagementObjectCollection queryCollection1 = query1.Get();
                foreach (ManagementObject mo in queryCollection1)
                {
                    string[] ss = { "" };
                    if (str == "重新启动")
                    {
                        mo.InvokeMethod("Reboot", ss);
                    }
                    if (str == "关闭计算机")
                    {
                        mo.InvokeMethod("Shutdown", ss);
                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("连接" + ip + "出错，出错信息为：" + er.Message);
            }

           return resultstr;
        }

        private void bn_open_Click(object sender, EventArgs e)
        {

            byte[] mac = new byte[6];
            //FC - 4D - D4 - 4C - 92 - 97
           

            mac[0] = 0xFC;
            mac[1] = 0x4D;
            mac[2] = 0xD4;
            mac[3] = 0x4C;
            mac[4] = 0x92;
            mac[5] = 0x97;
            WakeUp(mac);

        }



        public static void WakeUp(byte[] mac)
        {

            UdpClient client = new UdpClient();
            client.Connect(IPAddress.Broadcast, 9090);
            //MessageBox.Show(IPAddress.Broadcast.ToString());
            byte[] packet = new byte[17 * 6];
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;
            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];
            int result = client.Send(packet, packet.Length);
        }



    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSystemFunction
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += Application_ThreadException;////UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;////多线程异常

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SocketDataTransmission());
        }

        /// <summary>
        /// 多线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //可以记录日志并转向错误bug窗口友好提示用户
            Exception ex = e.ExceptionObject as Exception;
            string str = GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
            string txtpath = Path.GetFullPath("Error.txt");
            txtWrite(txtpath, str);
        }


        /// <summary>
        /// 未捕获线程异常时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.Exception, e.ToString());

            string txtpath = Path.GetFullPath("Error.txt");
            txtWrite(txtpath, str);
        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************异常文本****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            if (ex != null)
            {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
            }
            else
            {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }

        /// <summary>
        /// 写入TXT文件
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="str"></param>
        public static void txtWrite(string txtPath, string str)
        {
            string padjfdtxt = Path.GetFullPath("Error.txt");
            StreamWriter sw = new StreamWriter(txtPath, true);
            //System.Text.Encoding.GetEncoding("GB2312") = 
            str += System.DateTime.Now;
            sw.WriteLine(str);
            sw.Close();

            //Dim strArr As String() = {str}
            //File.WriteAllLines(txtPath, strArr, System.Text.Encoding.GetEncoding("GB2312")) '写入到新文件中


        }
    }
}

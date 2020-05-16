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
    public partial class FileNotUpdateOrNotDelete : Form
    {
        public FileNotUpdateOrNotDelete()
        {
            InitializeComponent();
        }

        private void FileNotUpdateOrNotDelete_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 确认保护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_SureProtect_Click(object sender, EventArgs e)
        {

            string FileSrc = tb_src.Text;
            if (FileSrc == string.Empty)
            {
                MessageBox.Show("请输入路径！");

                return;
            }


            ReadFile(FileSrc);


        }
        /// <summary>
        /// 撤销保护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_Revoke_Click(object sender, EventArgs e)
        {

            string FileSrc = tb_src.Text;
            FileStream fileStream = new FileStream(FileSrc, FileMode.Truncate);
            fileStream.Dispose();
            fileStream.Close();


        }
        /// <summary>
        /// 文件隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string FileSrc = tb_src.Text;
            if (FileSrc == string.Empty)
            {
                MessageBox.Show("请输入路径！");

                return;
            }
            DirectoryInfo dirInfo = new DirectoryInfo(FileSrc);
            //修改文件夹属性为隐度藏
            dirInfo.Attributes = FileAttributes.Hidden;
        }
       
        public static byte[] ReadFile(string filePath)
        {
            byte[] buffer;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }
            finally
            {
                //fileStream.Close();
            }
            return buffer;
        }
    }

}

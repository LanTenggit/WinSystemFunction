using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Base64AndImage
{
    public partial class ImgTobase : Form
    {
        public ImgTobase()
        {
            InitializeComponent();
        }

        private void ImgTobase_Load(object sender, EventArgs e)
        {


         
        }



       

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        /// <summary>
        /// 确认转化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
         
            this.textBox1.Text = decodeImageToBase64(filePath);
        }
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string filePath = null;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            /*  fileDialog.Filter = "所有文件(*xls*)|*.xls*";*/ //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径  
                filePath = file;
                Urlstr.Text = filePath;
            }


        }

        #region 图片转base64
        /// <summary>
        /// 图片转base64
        /// </summary>
        /// <param name="path">图片路径</param><br>        /// <returns>返回一个base64字符串</returns>
        public static string decodeImageToBase64(string path)
        {
            string base64str = "";

            try
            {
                //读图片转为Base64String
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(path);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                bmp.Dispose();
                base64str = Convert.ToBase64String(arr);
            }
            catch (Exception e)
            {
                string mss = e.Message;
            }
            string base64Data = "data:image/jpg;base64," + base64str;

            return base64str;
        }
        #endregion
    }
}

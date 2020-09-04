using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class 无损压缩图片 : Form
    {
        public 无损压缩图片()
        {
            InitializeComponent();
        }

        private void 无损压缩图片_Load(object sender, EventArgs e)
        {
           
        }



       
        string filePath;
        private void button1_Click(object sender, EventArgs e)
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
        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            string LoadPath = null;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                DirectoryInfo theFolder = new DirectoryInfo(foldPath);
                LoadPath = foldPath;
                //theFolder 包含文件路径

                FileInfo[] dirInfo = theFolder.GetFiles();
                //遍历文件夹                
                //foreach (FileInfo file in dirInfo)
                //{
                //    MessageBox.Show(file.ToString());
                //}
            }
            Guid guid = Guid.NewGuid();
            LoadPath += "/"+guid+".png";
            GetPicThumbnail(filePath, LoadPath, 200,200,20);

        }


        #region 无损压缩图片
        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="sFile">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="dHeight">高度</param>
        /// <param name="dWidth">宽度</param>
        /// <param name="flag">压缩质量1-100</param>
        /// <returns></returns>
        public static bool GetPicThumbnail(string sFile, string dFile, int dHeight, int dWidth, int flag)
        {
            var iSource = Image.FromFile(sFile);
            var tFormat = iSource.RawFormat;
            int sW = 0, sH = 0;
            // 按比例缩放
            var temSize = new Size(iSource.Width, iSource.Height);
            if (temSize.Width > dHeight || temSize.Width > dWidth)
            {
                if ((temSize.Width * dHeight) > (temSize.Height * dWidth))
                {
                    sW = dWidth;
                    sH = (dWidth * temSize.Height) / temSize.Width;
                }
                else
                {
                    sH = dHeight;
                    sW = (temSize.Width * dHeight) / temSize.Height;
                }
            }
            else
            {
                sW = temSize.Width;
                sH = temSize.Height;
            }

            var ob = new Bitmap(dWidth, dHeight);
            var g = Graphics.FromImage(ob);
            g.Clear(Color.WhiteSmoke);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(iSource, new Rectangle((dWidth - sW) / 2, (dHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            g.Dispose();

            // 以下代码为保存图片时，设置压缩质量
            var ep = new EncoderParameters();
            var qy = new long[1];

            // 设置压缩的比例1-100
            qy[0] = flag;
            var eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            ep.Param[0] = eParam;
            try
            {
                var arrayIci = ImageCodecInfo.GetImageEncoders();

                // JPEG、PNG
                var jpegIcIinfo = arrayIci.FirstOrDefault(t => t.FormatDescription.Equals("png"));

                if (jpegIcIinfo != null)
                {
                    ob.Save(dFile, jpegIcIinfo, ep); // dFile是压缩后的新路径
                }
                else
                {
                    ob.Save(dFile, tFormat);
                }
                return true;
            }
            catch(Exception ex)
            {

                return false;
            }
            finally
            {
                iSource.Dispose();
                ob.Dispose();
            }
        }
        #endregion
    }

}






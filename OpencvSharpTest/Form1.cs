using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpencvSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }
        string img1str = string.Empty;
        string img2str = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {

           
            Mat mat1 = new Mat(@"D:\桌面\三包img\2.bmp", ImreadModes.AnyColor);
            Mat mat2 = new Mat(@"D:\桌面\三包img\1.bmp", ImreadModes.AnyColor);
            mat1 = new Mat(img1str, ImreadModes.AnyColor);
            mat2 = new Mat(img2str, ImreadModes.AnyColor);

            Mat mat3 = new Mat();
            //创建result的模板，就是MatchTemplate里的第三个参数
            mat3.Create(mat1.Cols , mat1.Rows , MatType.CV_32FC1);
            //进行匹配(1母图,2模版子图,3返回的result，4匹配模式_这里的算法比opencv少，具体可以看opencv的相关资料说明)
            Cv2.MatchTemplate(mat1, mat2, mat3, TemplateMatchModes.SqDiff);

            //对结果进行归一化(这里我测试的时候没有发现有什么用,但在opencv的书里有这个操作，应该有什么神秘加成，这里也加上)
            Cv2.Normalize(mat3, mat3, 1, 0, NormTypes.MinMax, -1);
            double minValue, maxValue;
            OpenCvSharp.Point minLocation, maxLocation;
            /// 通过函数 minMaxLoc 定位最匹配的位置
            /// (这个方法在opencv里有5个参数，这里我写的时候发现在有3个重载，看了下可以直接写成拿到起始坐标就不取最大值和最小值了)
            /// minLocation和maxLocation根据匹配调用的模式取不同的点
            Cv2.MinMaxLoc(mat3, out minLocation, out maxLocation);
            //画出匹配的矩，
            //  Cv2.Rectangle(mat1, maxLocation, new Point (maxLocation.X+mat2.Cols, maxLocation.Y+mat2.Rows), Scalar.Red, 2);
            Cv2.Rectangle(mat1, minLocation, new OpenCvSharp.Point(minLocation.X + mat2.Cols, minLocation.Y + mat2.Rows), Scalar.Red, 2);
            Cv2.ImShow("mat1", mat1);
            Cv2.ImShow("mat2", mat2);

            //Console.WriteLine(minValue);
            //Console.WriteLine(maxValue);
            Console.WriteLine(minLocation);
            Console.WriteLine(maxLocation);
            Cv2.WaitKey();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "图片|*.*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径           
                Image img = Image.FromFile(file);
                img1str = file;
                pictureBox1.Image = img;
            }




        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "图片|*.*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径           
                Image img = Image.FromFile(file);
                img2str = file;
                pictureBox2.Image = img;
            }
        }
    }
}

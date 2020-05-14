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
    public partial class FileMoveCopyDelete : Form
    {
        public FileMoveCopyDelete()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_copy_Click(object sender, EventArgs e)
        {


            string BeforePath = this.tb_before.Text;
            string AfterPath = this.tb_after.Text;

            string path = "D:\\桌面\\新建文件夹\\WinSystemFunction.exe";

            FileInfo myfile = new FileInfo(BeforePath); //声明一个对象对某一个文件进行操作
            DateTime dt = myfile.CreationTime;  //获取或设置文件/文件夹的创建日期
            string filepath = myfile.DirectoryName; //仅能用于FileInfo,获得完整的路径名，路径+文件名
            bool file = myfile.Exists;              //此属性的值表示文件或文件夹是否存在,存在会返回True
            string fullname = myfile.FullName;     //获取文件或文件夹的完整路径名
            DateTime lastTime = myfile.LastAccessTime; //获取或设置最后一次访问文件或文件夹的时间
            DateTime lastWrite = myfile.LastWriteTime; //获取或设置最后一次修改文件夹或文件夹的时间
            string name = myfile.Name;                 //获取文件名，不能修改哦
            long length = myfile.Length;
            AfterPath += name;

            myfile.CopyTo(AfterPath);









        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileMoveCopyDelete_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_Move_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_delete_Click(object sender, EventArgs e)
        {
            string path = tb_after.Text;
            DelectDir(path);
        }

        /// <summary>
        /// 复制文件夹
        /// </summary>
        /// <param name="SourcePath"></param>
        /// <param name="DestinationPath"></param>
        /// <param name="overwriteexisting"></param>
        /// <returns></returns>
        private static bool CopyDirectory(string SourcePath, string DestinationPath, bool overwriteexisting)
        {
            bool ret = false;
            try
            {
                SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
                DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                        Directory.CreateDirectory(DestinationPath);

                    foreach (string fls in Directory.GetFiles(SourcePath))
                    {
                        FileInfo flinfo = new FileInfo(fls);
                        flinfo.CopyTo(DestinationPath + flinfo.Name, overwriteexisting);
                    }
                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo drinfo = new DirectoryInfo(drs);
                        if (CopyDirectory(drs, DestinationPath + drinfo.Name, overwriteexisting) == false)
                            ret = false;
                    }
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }


        /// <summary>
        /// 删除路径下所有文件
        /// </summary>
        /// <param name="srcPath"></param>
        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




       /// <summary>
       /// 复制整个文件夹
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string SourcePath = this.tb_before.Text;
            string DestinationPath = this.tb_after.Text;

            CopyDirectory(SourcePath, DestinationPath, true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}

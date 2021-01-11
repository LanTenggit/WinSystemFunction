using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log记录
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogHelper.Info("info");
                LogHelper.Error("Error");
                LogHelper.Debug("Debug");
                LogHelper.Fatal("Patal");
                LogHelper.Warn("Warn");
              

            }
            catch (Exception ex)
            {

                
            }
          


        }
    }
}

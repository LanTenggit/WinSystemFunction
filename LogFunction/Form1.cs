using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Instance.WriteLog("A");
                Logger.Instance.WriteLog("b");
            }
            catch (Exception ex)
            {
                Logger.Instance.WriteException(ex);
            }
     
        }
    }
}

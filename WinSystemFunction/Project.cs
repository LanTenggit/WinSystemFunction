using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinSystemFunction
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }


        enum student {

            one =1,
            two=2,
            four=3,
            three = 4
        }

        struct teach {

            public int NO;
            public string Name;



        }


        private void Project_Load(object sender, EventArgs e)
        {
             
            MessageBox.Show(student.four.ToString());   
           
            


            //MessageBox.Show(stu.ToString());

            teach tea = new teach();
            tea.Name = "LC";
            tea.NO = 1;
            MessageBox.Show(tea.ToString());





        }
    }
}

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

namespace Rood__VlaggenQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random ran = new Random();
            int j = ran.Next(0, imageList1.Images.Count);
            pictureBox1.Image = imageList1.Images[j];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://blog.worldofemotions.com/danilka/wp-content/uploads/2011/11/All_Flags_of_the_World_hr_5024x3757.jpg");
        }

        private void bAllFlags_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void bQuiz_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}

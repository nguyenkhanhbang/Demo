using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
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
            if (TexBox1.Text != "" && TextBox2.Text != "")
            {
                int a = int.Parse(TextBox1.Text);
                int b = int.Parse(TextBox2.Text);
            }
        }
    }
   // thêm một vài ghi chú :))
}

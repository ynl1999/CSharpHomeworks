using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = textBox1.Text;
            string B = textBox2.Text;
            double a;
            double b;
            double c;
            a = double.Parse(A);
            b = double.Parse(B);
            c = a * b;
            label3.Text = "" + c;
        }
    }
}

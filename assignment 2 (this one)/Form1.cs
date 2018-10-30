using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2__this_one_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5;

            try
            {
                r1 = double.Parse(textBox1.Text);
            }
            catch
            {
                r1 = 0;
            }
            try
            {
                r2 = double.Parse(textBox2.Text);
            }
            catch
            {
                r2 = 0;
            }
            try
            {
                r3 = double.Parse(textBox3.Text);
            }
            catch
            {
                r3 = 0;
            }
            try
            {
                r4 = double.Parse(textBox4.Text);
            }
            catch
            {
                r4 = 0;
            }
            try
            {
                r5 = double.Parse(textBox5.Text);
            }
            catch
            {
                r5 = 0;
            }
            double rt = r1 + r2 + r3 + r4 + r5;
            labelAnswer.Text = "Resistance = " + rt;
        }

        private void labelAnswer_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r6, r7, r8, r9, r10;

            try
            {
                r6 = double.Parse(textBox6.Text);
            }
            catch
            {
                r6 = 0;
            }
            try
            {
                r7 = double.Parse(textBox7.Text);
            }
            catch
            {
                r7 = 0;
            }
            try
            {
                r8 = double.Parse(textBox8.Text);
            }
            catch
            {
                r8 = 0;
            }
            try
            {
                r9 = double.Parse(textBox9.Text);
            }
            catch
            {
                r9 = 0;
            }
            try
            {
                r10 = double.Parse(textBox10.Text);
            }
            catch
            {
                r10 = 0;
            }
            double rt = r6 + r7 + r8 + r9 + r10;
            labelAnswer2.Text = "Resistance = " + rt;
        }
    }
}

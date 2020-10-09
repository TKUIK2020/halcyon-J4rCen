using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_WF
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 0;
            /*-------------------------------*/
            if (checkBox1.Checked) s += 13.000;
            if (checkBox2.Checked) s += 12.000;
            if (checkBox3.Checked) s += 17.000;
            /*-------------------------------*/
            if (checkBox4.Checked) s += 10.000;
            if (checkBox5.Checked) s += 17.000;
            if (checkBox6.Checked) s += 29.000;
            /*-------------------------------*/
            if (checkBox7.Checked) s += 8.500;
            if (checkBox8.Checked) s += 13.500;
            if (checkBox9.Checked) s += 19.500;
            /*-------------------------------*/
            label5.Text = string.Format($"{s:f3}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

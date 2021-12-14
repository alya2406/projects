using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            double v = double.Parse(textBox3.Text);
            double voz = Double.Parse(textBox2.Text);
            double i = 0;

            if (radioButton1.Checked)
            {
                i = 66 + (13.7 * v) + (5 * r) - (6.8 * voz);
                double a = i * 1.2;
                label14.Text = a.ToString("##.##");
                double b = i * 1.375;
                label19.Text = b.ToString("##.##");
                double u = i * 1.55;
                label22.Text = u.ToString("##.##");
                double k = i * 1.725;
                label21.Text = k.ToString("##.##");
                double q = i * 1.9;
                label20.Text = q.ToString("##.##");
            }
            if (radioButton2.Checked)
            {
                i = 655 + (9.6 * v) + (1.8 * r) - (4.7 * voz);
                double a = i * 1.2;
                label14.Text = a.ToString("##.##");
                double b = i * 1.375;
                label19.Text = b.ToString("##.##");
                double u = i * 1.55;
                label22.Text = u.ToString("##.##");
                double k = i * 1.725;
                label21.Text = k.ToString("##.##");
                double q = i * 1.9;
                label20.Text = q.ToString("##.##");
            }
            label12.Text = i.ToString("##.##");
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    


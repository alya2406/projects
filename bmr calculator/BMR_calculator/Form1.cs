using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rost = double.Parse(textBox1.Text);
            double ves = double.Parse(textBox2.Text);
            double let = double.Parse(textBox3.Text);
            if (radioButton1.Checked)
            {
                

            }

            if (radioButton2.Checked)
            {
                double index = 655 + (9.6 * ves) + (1.8 * rost) - (4.7 * let);
                label8.Text = index.ToString("##.##");

                double sit = index * 1.2;
                label15.Text = sit.ToString("##.##");

                double malo = index * 1.375;
                label16.Text = malo.ToString("##.##");

                double sredre = index * 1.55;
                label17.Text = sredre.ToString("##.##");

                double silno = index * 1.725;
                label18.Text = silno.ToString("##.##");

                double max = index * 1.9;
                label19.Text = max.ToString("##.##");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label8.Text = null;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

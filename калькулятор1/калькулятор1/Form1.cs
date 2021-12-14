using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор1
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

        private void height_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ves = double.Parse(weight.Text);
            double rost = double.Parse(height.Text);
            double index = ves / ((rost / 100) * (rost / 100));
            label5.Text = index.ToString("##.##");
            trackBar1.Value = Convert.ToInt32(index);

            if (index < 18.5)
            {
                pictureBox7.Image = Image.FromFile(@"C:\Users\student\source\repos\калькулятор1\5.png");
            }

            if (index > 25)
            {
                pictureBox7.Image = Image.FromFile(@"C:\Users\student\source\repos\калькулятор1\1.png");
            }

            if (index >= 18.5)
            {
                pictureBox7.Image = Image.FromFile(@"C:\Users\student\Pictures\bmi-overweight-icon.png");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            height.Clear();
            weight.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }




    }
}
    




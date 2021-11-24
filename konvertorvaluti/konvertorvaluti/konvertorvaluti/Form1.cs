using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konvertorvaluti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int est = Convert.ToInt32(textBox1.Text);
            if (rub1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 72);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 82);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 98);
                }
            }
            if (usd1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 72);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 0.8);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 0.7);
                }
            }
            if (eur1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 82);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 1.1);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 0.8);
                }
            }
            if (gbp1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 98);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 1.3);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 1.2);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rub1_CheckedChanged(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile(@"D:\alya\konvertorvaluti\r.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usd1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\alya\konvertorvaluti\d.png");
        }

        private void eur1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\alya\konvertorvaluti\e.png");
        }

        private void gbp1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\alya\konvertorvaluti\f.png");
        }

        private void rub2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\alya\konvertorvaluti\r.png");
        }

        private void usd2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\alya\konvertorvaluti\d.png");
        }

        private void eur2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\alya\konvertorvaluti\e.png");
        }

        private void gbp2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"D:\alya\konvertorvaluti\f.png");
        }
    }
}

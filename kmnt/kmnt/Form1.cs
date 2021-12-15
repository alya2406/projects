using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KARPOVASEMELEVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
        }

        public Form1(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
        {
            InitializeComponent();
            int s1 = Convert.ToInt16(p1);
            int s2 = Convert.ToInt16(p2);
            int s3 = Convert.ToInt16(p3);
            int s4 = Convert.ToInt16(p4);
            int s5 = Convert.ToInt16(p5);
            int s6= Convert.ToInt16(p6);
            int s7 = Convert.ToInt16(p7);
            int s8 = Convert.ToInt16(p8);
            int s9 = Convert.ToInt16(p9);
            int max = 0;
            int min = 10;
            int sum = 0;
            int[] mass = new int[9];
            mass[0] = s1; mass[1] = s2; mass[2] = s3; mass[3] = s4; mass[4] = s5; mass[5] = s6; mass[6] = s7; mass[7] = s8; mass[8] = s9;

            for (int i = 0; i < 9; i++)
            {
                sum = sum + mass[i];
                if (mass[i] > max)
                {
                    max = mass[i];
                }

                if (mass[i] < min)
                {
                    min = mass[i];
                }
               Console.WriteLine();

            }

            string Smax = max.ToString();
            label11.Text = Smax.ToString();

            string Smin = min.ToString();
            label13.Text = Smin;

            string Ssum = sum.ToString();
            label15.Text = Ssum;

            label1.Text = p1;
            label2.Text = p2;
            label3.Text = p3;
            label4.Text = p4;
            label5.Text = p5;
            label6.Text = p6;
            label7.Text = p7;
            label8.Text = p8;
            label9.Text = p9;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Оценка_Load(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }
    }
}

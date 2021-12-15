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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
       
        {
            string p1 = textBox1.Text;
            string p2 = textBox2.Text;
            string p3 = textBox3.Text;
            string p4 = textBox4.Text;
            string p5 = textBox5.Text;
            string p6 = textBox6.Text;
            string p7 = textBox7.Text;
            string p8 = textBox8.Text;
            string p9 = textBox9.Text;
            Form Form1 = new Form1(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Form1.Show();
        }
    }
}

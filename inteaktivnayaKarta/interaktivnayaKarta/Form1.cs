using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inteaktivnayaKartaPogorelov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Avenida Rudge";

            label5.Visible = false;
            label6.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Theatro Municipal";
          
             label2.Visible = true;
             label4.Visible = true;
             label5.Visible = true;
             label6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Parque do Ibirapuera";

            label6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Jardim Luzitania";

            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Iguatemi";

            label6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Rua Lisboa";

            label6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Cemitério da Consolação";

            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Cemitério da Consolação";

            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }
    }
}

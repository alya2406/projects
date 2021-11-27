using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace bdkomnatnaya
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Students] (Name, Surname, Birthday) VALUES (@Name, @Surname, @Birthday)", sqlConnection);
            DateTime birthday = DateTime.Parse(textzp.Text);


            command.Parameters.AddWithValue("Name", textFIO.Text);
            command.Parameters.AddWithValue("Surname", textdolznost.Text);
            command.Parameters.AddWithValue("Birthday", $"{birthday.Day}/{birthday.Month}/{birthday.Year}");

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\bdkomnatnaya\bdkomnatnaya\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
             
    }
    


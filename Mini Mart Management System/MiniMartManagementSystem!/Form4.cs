using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into logininfo(email,password)values(@Email,@Password)";
            SqlCommand Command = new SqlCommand(query, con);
            Command.Parameters.AddWithValue("@Email", textBox1.Text);
            Command.Parameters.AddWithValue("@Password", textBox3.Text);

            int a = Command.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                MessageBox.Show("SIGNUP Successful");
               Form6 f6=new Form6();
                f6.Show();
            }
            else
            {
                MessageBox.Show("Already exist");
            }
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

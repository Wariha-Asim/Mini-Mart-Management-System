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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into customerlogininfo(email,password)values(@Email,@Password)";
            SqlCommand Command = new SqlCommand(query, con);
            Command.Parameters.AddWithValue("@Email", textBox1.Text);
            Command.Parameters.AddWithValue("@Password", textBox3.Text);

            int a = Command.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                MessageBox.Show("SIGN UP");
                Form8 f8 = new Form8();
                f8.Show();
            }
            else
            {
                MessageBox.Show("already exist");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}

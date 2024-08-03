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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the username: ");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Enter the password: ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");
                    SqlCommand Command = new SqlCommand("Select * from logininfo where email=@email and password=@password", con);
                    Command.Parameters.AddWithValue("@Email", textBox1.Text);
                    Command.Parameters.AddWithValue("@Password", textBox3.Text);
                    SqlDataAdapter da = new SqlDataAdapter(Command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfull");


                        Form11 f11 = new Form11();
                        f11.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

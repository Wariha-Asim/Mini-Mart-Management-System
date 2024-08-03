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

namespace WinFormsApp6
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the username: ");
            }
            else if (textBox2.Text == " ")
            {
                MessageBox.Show("Enter the password: ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");
                    SqlCommand Command = new SqlCommand("Select * from customerlogininfo where email=@email and password=@password", con);
                    Command.Parameters.AddWithValue("@Email", textBox1.Text);
                    Command.Parameters.AddWithValue("@Password", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(Command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfull");
                        Form10 f10 = new Form10();
                        f10.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

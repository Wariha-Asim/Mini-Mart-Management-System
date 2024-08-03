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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Insert into product(pname,pprice,pquantity,pcategory) values(@Pname,@Pprice,@Pquantity,@Pcategory)";
            SqlCommand Command = new SqlCommand(query, Con);

            Command.Parameters.AddWithValue("@Pname", textBox1.Text);
            Command.Parameters.AddWithValue("@Pprice", textBox3.Text);
            Command.Parameters.AddWithValue("Pquantity", textBox4.Text);
            Command.Parameters.AddWithValue("@Pcategory", textBox2.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Data Inserted!");

            }
            else
            {
                MessageBox.Show("Can't Insert!");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string query = "UPDATE product SET pname=@Pname, pprice=@Pprice, pquantity=@Pquantity,pcategory=@Pcategory WHERE pid=@Pid";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@Pid", int.Parse(textBox5.Text));
            Command.Parameters.AddWithValue("@Pname", textBox1.Text);
            Command.Parameters.AddWithValue("@Pprice", textBox3.Text);
            Command.Parameters.AddWithValue("@Pquantity", textBox4.Text);
            Command.Parameters.AddWithValue("@Pcategory", textBox2.Text);

            int a = Command.ExecuteNonQuery();
            Con.Close();
            if (a > 0)
            {
                MessageBox.Show("Data Updated!");
            }
            else
            {
                MessageBox.Show("Can't Update!");
            }
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from dbo.product where pid=@Pid";
            SqlCommand Command = new SqlCommand(query, Con);
            Command.Parameters.AddWithValue("@Pid", int.Parse(textBox5.Text));
            Command.Parameters.AddWithValue("@Pname", textBox1.Text);
            Command.Parameters.AddWithValue("@Pprice", textBox3.Text);
            Command.Parameters.AddWithValue("@Pquantity", textBox4.Text);
            Command.Parameters.AddWithValue("@Pcategory", textBox2.Text);

            int a = Command.ExecuteNonQuery();
           
            if (a > 0)
            {
                MessageBox.Show("Data Deleted!");
            }
            else
            {
                MessageBox.Show("Can't Delete!");
            }
            Con.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM product";
            SqlCommand command = new SqlCommand(query, Con);
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            Con.Close();
        }
    }
}


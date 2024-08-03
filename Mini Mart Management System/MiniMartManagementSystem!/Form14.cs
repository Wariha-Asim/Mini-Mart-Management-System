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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");



        private void label2_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;

            Con.Open();
            string query = "SELECT * FROM product WHERE pname LIKE @Keyword";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            Con.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


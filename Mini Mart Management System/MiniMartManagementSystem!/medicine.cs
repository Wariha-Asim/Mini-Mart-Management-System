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
    public partial class medicine : Form
    {
        public medicine()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "exec categoryview 102;";
            SqlCommand command = new SqlCommand(query, Con);
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

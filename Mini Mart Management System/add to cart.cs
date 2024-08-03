using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace WinFormsApp6
{
    public partial class add_to_cart : Form
    {
        public add_to_cart()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_to_cart_Load(object sender, EventArgs e)
        {
            ClearCartItems();
            ResetCartItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(textBox1.Text);
            int quantity = int.Parse(textBox2.Text);
            AddItemToCart(productId, quantity);
            LoadCartItems();
            UpdateTotalBill(); // Update the total bill after adding an item
        }

        private void LoadCartItems()
        {
            string connectionString = "Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetCartItems", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void UpdateTotalBill()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                total += Convert.ToDecimal(row.Cells["total_price"].Value);
            }
            label5.Text = "Total Bill: $" + total.ToString("0.00");
        }

        private void AddItemToCart(int productId, int quantity)
        {
            string connectionString = "Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if the product ID exists
                SqlCommand checkProductCmd = new SqlCommand("SELECT COUNT(*) FROM product WHERE pid = @product_id", conn);
                checkProductCmd.Parameters.AddWithValue("@product_id", productId);

                int productExists = (int)checkProductCmd.ExecuteScalar();

                if (productExists == 0)
                {
                    MessageBox.Show("The product ID does not exist. Please enter a valid product ID.");
                    return;
                }

                // Proceed with adding the item to the cart
                SqlCommand cmd = new SqlCommand("AddToCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@customer_id", 1); // Assuming customer ID is 1
                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@quantity", quantity);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the item to the cart: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int productId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["pid"].Value);
                    RemoveItemFromCart(1, productId); // Assuming customer ID is 1
                    LoadCartItems();
                    UpdateTotalBill(); // Update the total bill after removing an item
                }
                else
                {
                    MessageBox.Show("Please select a product to remove.");
                }
            }
        }

        private void ResetCartItems()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            LoadCartItems();
            UpdateTotalBill();
        }

        private void RemoveItemFromCart(int customerId, int productId)
        {
            string connectionString = "Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RemoveFromCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", customerId);
                cmd.Parameters.AddWithValue("@product_id", productId);

                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while removing the item from the cart: " + ex.Message);
                }
            }
        }

        private void ClearCartItems()
        {
            string connectionString = "Data Source=DESKTOP-N5GG7NK\\SQLEXPRESS02;Initial Catalog=Hamarimehnat;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("ClearCart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", 1); // Assuming customer ID is 1

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while clearing the cart: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            checkout co = new checkout();
            co.Show();
        }
    }
}

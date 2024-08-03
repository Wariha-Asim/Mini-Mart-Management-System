using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class categorycus : Form
    {
        public categorycus()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            food food = new food();
            food.Show();


        }

        private void label5_Click(object sender, EventArgs e)
        {
            clothing c1 = new clothing();
            c1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            perfume p = new perfume();
            p.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            accessories a = new accessories();
            a.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            medicine medicine = new medicine();
            medicine.Show();
        }
    }
}

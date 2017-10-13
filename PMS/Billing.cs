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

namespace PMS
{
    public partial class Billing : Form
    {
        static int total;

        public string value
        {
            get { return textBox3.Text; }
        }
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select amount from stocks where Med_name='" + textBox1.Text + "'AND Qty-" + textBox2.Text + ">=0", con);
            int amt = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int qty = Convert.ToInt32(textBox2.Text.ToString());
            total += amt * qty;
            textBox3.Text = (total).ToString();
            cmd = new SqlCommand("Update stocks set Qty=Qty-" + textBox2.Text + "where Med_name='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();

        }

        private void button3_Click(object sender, EventArgs e)
        {
                Customer cust = new Customer();
            this.Hide();
            cust.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

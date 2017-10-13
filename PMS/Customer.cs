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
    public partial class Customer : Form
    {
        static int n;
        public Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
            textBox3.Text = "3000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlCommand c = new SqlCommand("Select count (*) from customer", con);
            n = Convert.ToInt32(c.ExecuteScalar().ToString());
            SqlCommand cmd = new SqlCommand("Insert into customer values(" +n+",'" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",getdate());", con);
            cmd.ExecuteNonQuery();
            n++;
            MessageBox.Show("Inserted");
            con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

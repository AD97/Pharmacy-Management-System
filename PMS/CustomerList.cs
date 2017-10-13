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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private DataTable getData()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select * from customer", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            SqlCommand cmd = new SqlCommand("Select * from customer where CustId =" + textBox1.Text + "OR Custname = '" + textBox2.Text + "' OR PhoneNo ='" + textBox3.Text+"'", con);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            msg.MdiParent = this;
            msg.Show();
        }
    }
}

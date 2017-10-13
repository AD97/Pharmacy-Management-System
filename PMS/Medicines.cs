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
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[stocks];", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda.Update(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[stocks] where MedID=" + textBox1.Text + ";", con);
            SqlDataAdapter adap = new SqlDataAdapter("Select  from [dbo].[stocks];",con);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[stocks]
           ([MedID]
           ,[Med_name]
           ,[Qty])
     VALUES
           (" + textBox1.Text + ", '" + textBox2.Text + "'," + textBox3.Text + ");", con);
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
                MessageBox.Show("Already Exists");
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
            }
            dataGridView1.DataSource = getMedicines();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[stocks] where MedID=" + textBox1.Text + ";", con);
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[stocks]
      WHERE MedID="+textBox1.Text+";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
                MessageBox.Show("Deleted Succesfully");
            else
                MessageBox.Show("No such item");
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = getMedicines();
        }

        private void pmsDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getMedicines();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ;
        }

        private DataTable getMedicines()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select * from stocks", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update stocks set Med_Name='" + textBox2.Text + "',Qty =" + textBox3.Text + "where MedId=" + textBox1.Text + ";",con);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = getMedicines();
            MessageBox.Show("Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if(textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if(textBox3.Text =="")
            {
                textBox3.Text = "0";
            }
            SqlCommand cmd = new SqlCommand("Select * from stocks where MedID =" + textBox1.Text + "OR Med_name = '" + textBox2.Text + "' OR Qty =" + textBox3.Text, con);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getMedicines();
        }
    }
}

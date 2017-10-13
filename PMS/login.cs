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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [Uname],[Password] FROM [dbo].[login] where Uname=" + "'" + textBox1.Text + "'" + "and Password=" + "'" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1) {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }

            else{
                MessageBox.Show("Invalid");
                button2_Click(sender, e);
            }
            

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

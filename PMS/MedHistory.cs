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
    public partial class MedHistory : Form
    {
        public MedHistory()
        {
            InitializeComponent();
        }

        private void MedHistory_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("Select distinct Med_name from MedHistory", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                DataRow temp = row;
                listBox1.Items.Add(temp["Med_name"]);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = AD\\SQLEXPRESS; Initial Catalog = pms; Integrated Security = True");
            con.Open();
            listBox2.Items.Clear();
            string tem = listBox1.SelectedItems[0].ToString();
            SqlDataAdapter ada = new SqlDataAdapter("Select date from MedHistory where Med_name = '" + tem + "'", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                DataRow temp = row;
                listBox2.Items.Add(temp["date"]);
            }
        }
    }
}

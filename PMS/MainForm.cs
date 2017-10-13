using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void medicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicines med = new Medicines();
            med.MdiParent = this;
            med.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.MdiParent = this;
            cust.Show();

        }

        private void existingCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList cust = new CustomerList();
            cust.MdiParent = this;
            cust.Show();

        }

        private void customerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerHistory cust = new CustomerHistory();
            cust.MdiParent = this;
            cust.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing bill = new PMS.Billing();
            bill.MdiParent = this;
            bill.Show();
        }

        private void medicineWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedHistory med = new MedHistory();
            med.MdiParent = this;
            med.Show();
        }
    }
}

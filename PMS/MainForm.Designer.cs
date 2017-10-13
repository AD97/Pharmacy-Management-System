namespace PMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.medicinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyOfSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicinesToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.historyOfSalesToolStripMenuItem,
            this.billingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(767, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // medicinesToolStripMenuItem
            // 
            this.medicinesToolStripMenuItem.Name = "medicinesToolStripMenuItem";
            this.medicinesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.medicinesToolStripMenuItem.Text = "Medicines";
            this.medicinesToolStripMenuItem.Click += new System.EventHandler(this.medicinesToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.existingCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // existingCustomersToolStripMenuItem
            // 
            this.existingCustomersToolStripMenuItem.Name = "existingCustomersToolStripMenuItem";
            this.existingCustomersToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.existingCustomersToolStripMenuItem.Text = "Existing Customers";
            this.existingCustomersToolStripMenuItem.Click += new System.EventHandler(this.existingCustomersToolStripMenuItem_Click);
            // 
            // historyOfSalesToolStripMenuItem
            // 
            this.historyOfSalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerWiseToolStripMenuItem,
            this.medicineWiseToolStripMenuItem});
            this.historyOfSalesToolStripMenuItem.Name = "historyOfSalesToolStripMenuItem";
            this.historyOfSalesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyOfSalesToolStripMenuItem.Text = "History";
            // 
            // customerWiseToolStripMenuItem
            // 
            this.customerWiseToolStripMenuItem.Name = "customerWiseToolStripMenuItem";
            this.customerWiseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerWiseToolStripMenuItem.Text = "Customer wise";
            this.customerWiseToolStripMenuItem.Click += new System.EventHandler(this.customerWiseToolStripMenuItem_Click);
            // 
            // medicineWiseToolStripMenuItem
            // 
            this.medicineWiseToolStripMenuItem.Name = "medicineWiseToolStripMenuItem";
            this.medicineWiseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medicineWiseToolStripMenuItem.Text = "Medicine wise";
            this.medicineWiseToolStripMenuItem.Click += new System.EventHandler(this.medicineWiseToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 468);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(767, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 490);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem medicinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyOfSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
    }
}




namespace CpAssignment
{
    partial class Dashboard
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnviewexpenses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(272, 18);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 22);
            this.txtsearch.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 52);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(907, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.expenseToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(907, 28);
            this.menuStrip3.TabIndex = 8;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.settingsToolStripMenuItem.Text = "Profile settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.reportsToolStripMenuItem.Text = "Reports ";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::CpAssignment.Properties.Resources.refreshlast1;
            this.btnrefresh.Location = new System.Drawing.Point(823, 12);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(32, 32);
            this.btnrefresh.TabIndex = 14;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnviewexpenses
            // 
            this.btnviewexpenses.Image = global::CpAssignment.Properties.Resources.view;
            this.btnviewexpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewexpenses.Location = new System.Drawing.Point(30, 343);
            this.btnviewexpenses.Name = "btnviewexpenses";
            this.btnviewexpenses.Size = new System.Drawing.Size(145, 53);
            this.btnviewexpenses.TabIndex = 13;
            this.btnviewexpenses.Text = "View expenses";
            this.btnviewexpenses.UseVisualStyleBackColor = true;
            this.btnviewexpenses.Click += new System.EventHandler(this.btnviewexpenses_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CpAssignment.Properties.Resources.add_green;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(30, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Expense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.btnlogout.Location = new System.Drawing.Point(869, 406);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(27, 28);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Image = global::CpAssignment.Properties.Resources.settinglast;
            this.btnsetting.Location = new System.Drawing.Point(861, 12);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(34, 28);
            this.btnsetting.TabIndex = 10;
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::CpAssignment.Properties.Resources.search2;
            this.btnsearch.Location = new System.Drawing.Point(466, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(44, 34);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(274, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 346);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.expenseToolStripMenuItem.Text = "Expense";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnviewexpenses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnviewexpenses;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
    }
}
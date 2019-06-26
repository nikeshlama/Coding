namespace CpAssignment
{
    partial class Setting
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnviewexpenses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileSettingToolStripMenuItem,
            this.expenseSettingToolStripMenuItem,
            this.reportSettingToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileSettingToolStripMenuItem
            // 
            this.profileSettingToolStripMenuItem.Name = "profileSettingToolStripMenuItem";
            this.profileSettingToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.profileSettingToolStripMenuItem.Text = "Profile setting";
            this.profileSettingToolStripMenuItem.Click += new System.EventHandler(this.profileSettingToolStripMenuItem_Click);
            // 
            // expenseSettingToolStripMenuItem
            // 
            this.expenseSettingToolStripMenuItem.Name = "expenseSettingToolStripMenuItem";
            this.expenseSettingToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.expenseSettingToolStripMenuItem.Text = "Expense setting";
            this.expenseSettingToolStripMenuItem.Click += new System.EventHandler(this.expenseSettingToolStripMenuItem_Click);
            // 
            // reportSettingToolStripMenuItem
            // 
            this.reportSettingToolStripMenuItem.Name = "reportSettingToolStripMenuItem";
            this.reportSettingToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.reportSettingToolStripMenuItem.Text = "Report setting";
            this.reportSettingToolStripMenuItem.Click += new System.EventHandler(this.reportSettingToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.btnlogout.Location = new System.Drawing.Point(867, 408);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(27, 28);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 346);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::CpAssignment.Properties.Resources.refreshlast1;
            this.btnrefresh.Location = new System.Drawing.Point(218, 270);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(32, 32);
            this.btnrefresh.TabIndex = 25;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnviewexpenses
            // 
            this.btnviewexpenses.Image = global::CpAssignment.Properties.Resources.view;
            this.btnviewexpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewexpenses.Location = new System.Drawing.Point(29, 313);
            this.btnviewexpenses.Name = "btnviewexpenses";
            this.btnviewexpenses.Size = new System.Drawing.Size(145, 53);
            this.btnviewexpenses.TabIndex = 24;
            this.btnviewexpenses.Text = "View expenses";
            this.btnviewexpenses.UseVisualStyleBackColor = true;
            this.btnviewexpenses.Click += new System.EventHandler(this.btnviewexpenses_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CpAssignment.Properties.Resources.add_green;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Expense";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.button2.Location = new System.Drawing.Point(868, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 28);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::CpAssignment.Properties.Resources.search2;
            this.btnsearch.Location = new System.Drawing.Point(465, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(44, 34);
            this.btnsearch.TabIndex = 17;
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(271, 19);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(188, 22);
            this.txtsearch.TabIndex = 16;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 76);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(901, 24);
            this.menuStrip2.TabIndex = 18;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Location = new System.Drawing.Point(0, 52);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(901, 24);
            this.menuStrip3.TabIndex = 19;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Location = new System.Drawing.Point(0, 28);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(901, 24);
            this.menuStrip4.TabIndex = 20;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnviewexpenses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip4);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnviewexpenses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}
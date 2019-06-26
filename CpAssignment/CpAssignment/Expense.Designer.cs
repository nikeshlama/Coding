namespace CpAssignment
{
    partial class Expense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Description = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rchdescription = new System.Windows.Forms.RichTextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Money spent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(77, 141);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(79, 17);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(222, 57);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(235, 22);
            this.txtmoney.TabIndex = 2;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(222, 229);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 53);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // rchdescription
            // 
            this.rchdescription.Location = new System.Drawing.Point(222, 141);
            this.rchdescription.Name = "rchdescription";
            this.rchdescription.Size = new System.Drawing.Size(235, 71);
            this.rchdescription.TabIndex = 6;
            this.rchdescription.Text = "";
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.btnlogout.Location = new System.Drawing.Point(980, 372);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(27, 28);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Food",
            "Water",
            "Rent",
            "Education",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(222, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(-4, -1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 32);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "<--";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(473, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 346);
            this.dataGridView1.TabIndex = 17;
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
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.rchdescription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rchdescription;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}
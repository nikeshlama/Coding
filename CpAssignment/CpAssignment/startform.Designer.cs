namespace CpAssignment
{
    partial class startform
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(181, 111);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(156, 22);
            this.txtpassword.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(180, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(156, 22);
            this.txtusername.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(181, 163);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(122, 38);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(181, 220);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(122, 38);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "New User?";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 298);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "startform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnnew;
    }
}
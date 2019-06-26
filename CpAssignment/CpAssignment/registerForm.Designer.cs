namespace CpAssignment
{
    partial class registerForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txthint = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hint";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(185, 43);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(118, 22);
            this.txtfirstname.TabIndex = 1;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(185, 90);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(118, 22);
            this.txtlastname.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(185, 136);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(118, 22);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(185, 188);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(118, 22);
            this.txtpassword.TabIndex = 1;
            // 
            // txthint
            // 
            this.txthint.Location = new System.Drawing.Point(185, 229);
            this.txthint.Name = "txthint";
            this.txthint.Size = new System.Drawing.Size(118, 22);
            this.txthint.TabIndex = 1;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(136, 297);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 40);
            this.btnregister.TabIndex = 2;
            this.btnregister.Text = "Register";
            this.btnregister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(228, 297);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 40);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.btnlogout.Location = new System.Drawing.Point(377, 395);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(27, 28);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 435);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txthint);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txthint;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout;
    }
}
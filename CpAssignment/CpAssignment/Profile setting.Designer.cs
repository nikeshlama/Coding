namespace CpAssignment
{
    partial class Profile_setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(101, 47);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 22);
            this.txtusername.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(101, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 3;
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.btnlogout.Location = new System.Drawing.Point(589, 292);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(27, 28);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(0, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 32);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "<--";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Profile_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 332);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile_setting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
    }
}
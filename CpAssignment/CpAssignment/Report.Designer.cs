namespace CpAssignment
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(10, 20);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Money";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1070, 429);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::CpAssignment.Properties.Resources.logoutlast;
            this.btnlogout.Location = new System.Drawing.Point(1053, 460);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(27, 28);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(509, 455);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(95, 33);
            this.btnload.TabIndex = 13;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1, -2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 32);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "<--";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 493);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.chart1);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnback;
    }
}
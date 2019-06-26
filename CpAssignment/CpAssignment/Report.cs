using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace CpAssignment
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Money"].Points.AddXY("Food", 300);
            this.chart1.Series["Money"].Points.AddXY("Water", 200);
            this.chart1.Series["Money"].Points.AddXY("Rent", 2500);
            this.chart1.Series["Money"].Points.AddXY("Education", 3000);
            this.chart1.Series["Money"].Points.AddXY("Others", 900);
            this.chart1.Series["Money"].Points.AddXY("Food", 500);
            this.chart1.Series["Money"].Points.AddXY("Others", 100);
            this.chart1.Series["Money"].Points.AddXY("Others", 400);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Setting s = new Setting();
            s.Show();
            this.Hide();
        }
    }
}

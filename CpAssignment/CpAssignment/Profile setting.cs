using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CpAssignment
{
    public partial class Profile_setting : Form
    {
        public Profile_setting()
        {
            InitializeComponent();
        }

        SqlConnection conection = new SqlConnection("Data source =DESKTOP-3FU1KJE\\NIKESHSERVER; Initial catalog = dailyexpensessystem; Integrated Security=True");
        string imgLocation = "";
      
       


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png| jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

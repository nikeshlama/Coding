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
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            login lo = new login();
            lo.Username = txtpassword.Text;
            lo.Password = txtusername.Text;
            SqlConnection con = new SqlConnection("Data source =DESKTOP-3FU1KJE\\NIKESHSERVER; Initial catalog = dailyexpensessystem; Integrated Security=True");
            string query = "select * from register_tbl where Username='" + txtpassword.Text + "'and Password='" + txtusername.Text + "'";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            DataTable ds = new DataTable();
            sa.Fill(ds);
            if (ds.Rows.Count == 1)
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password is invalid ");
                lo.Username = null;
                lo.Password = null;
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            registerForm rf = new registerForm();
            rf.Show();
            this.Hide();
        }
    }
}

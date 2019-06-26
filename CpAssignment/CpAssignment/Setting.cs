using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpAssignment
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void profileSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile_setting ps = new Profile_setting();
            ps.Show();
            this.Hide();
        }

        private void expenseSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense ee = new Expense();
            ee.Show();
            this.Hide();
        }

        private void reportSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rt = new Report();
            rt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Expense ex = new Expense();
            ex.Show();
            this.Hide();
        }

        private void btnviewexpenses_Click(object sender, EventArgs e)
        {

            Report r = new Report();
            r.Show();
            this.Hide();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            LoadStart();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadStart();
        }
        private void LoadStart()
        {
            try
            {
                string query = "Select * from expense_tbl";
                DatabaseConnect db = new DatabaseConnect();
                DataTable values = db.data(query);
                dataGridView1.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

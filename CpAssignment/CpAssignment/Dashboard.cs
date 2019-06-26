using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CpAssignment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        string imgLocation = "";
       


        private void button1_Click(object sender, EventArgs e)
        {
       
            Expense ex = new Expense();
            ex.Show();
            this.Hide();
        }

        private void addGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense ex = new Expense();
            ex.Show();
            this.Hide();
        }


        private void showReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report re = new Report();
            re.Show();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile_setting ps = new Profile_setting();
            ps.Show();
            this.Hide();
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            Setting se = new Setting();
            se.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatabaseConnect db = new DatabaseConnect();
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (Command.ToLower() == "delete")
            {
                DialogResult DialogDecision = MessageBox.Show("Are you sure you want to delete the entire row?", "", MessageBoxButtons.YesNo);
                if (DialogDecision == DialogResult.Yes)
                {
                    string query = "Delete from expense_tbl where id=" +id;
                    db.Executequery(query);

                    string query1 = "Delete from chart_tbl where id=" + id;
                    db.Executequery(query1);
                    MessageBox.Show("Expense deleted successfully");
                }

                else if (DialogDecision == DialogResult.No)
                {
                    MessageBox.Show("Be sure and come next time");
                }
            }
            try
            {
                string query = "Select * from expense_tbl";
                DataTable values = db.data(query);
                dataGridView1.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
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

        private void btnlogout_Click(object sender, EventArgs e)
        {
            startform sf = new startform();
            sf.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            LoadStart();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == null)
                {
                    MessageBox.Show("Enter a word to search Thank You!!!");
                }
                else
                {
                    string query = "Select * from expense_tbl where  title like'" + txtsearch.Text + "%'or description like'" + txtsearch.Text + "%' ";
                   DatabaseConnect db = new DatabaseConnect();
                    DataTable dt = db.data(query);
                    dataGridView1.DataSource = dt;
                    txtsearch.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnviewexpenses_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense ee = new Expense();
            ee.Show();
            this.Hide();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense ee = new Expense();
            ee.Show();
            this.Hide();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rr = new Report();
            rr.Show();
            this.Hide();
        }
    }
}

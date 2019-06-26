using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CpAssignment
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                expenses ep = new expenses();
                ep.title = comboBox1.Text;
                ep.money = txtmoney.Text;
                ep.date = DateTime.Now;
                ep.description = rchdescription.Text;

                chart1 cc = new chart1();
                cc.title = comboBox1.Text;
                cc.total = txtmoney.Text;



                if (errorTest.PresenceOfTitle(comboBox1.Text))
                {
                    MessageBox.Show("Sorry need a title of expenses");
                    return;
                }
                if (errorTest.PresenceOfmoney(txtmoney.Text))
                {
                    MessageBox.Show("Sorry you need to insert the amount you've spent");
                    return;
                }

                String query1 = "Insert into expense_tbl values('" + ep.title + "','" + ep.money + "','" + ep.date + "','" + ep.description + "')";
                DatabaseConnect db = new DatabaseConnect();
                db.Executequery(query1);

                String query2 = "Insert into chart_tbl values('" + cc.title + "','" + cc.total + "')";
                DatabaseConnect dt = new DatabaseConnect();
                dt.Executequery(query2);

                MessageBox.Show(" Expense successfully registered");
                comboBox1.Text = "";
                txtmoney.Text = "";
                rchdescription.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    string query = "Delete from expense_tbl where id=" + id;
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

        private void Expense_Load(object sender, EventArgs e)
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

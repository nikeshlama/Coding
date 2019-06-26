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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            try
            {
                register r = new register();
                r.FirstName = txtfirstname.Text;
                r.LastName = txtlastname.Text;
                r.Username = txtusername.Text;
                r.Password = txtpassword.Text;
                r.Hint = txthint.Text;
                string command = "insert into register_tbl (Firstname,Lastname,Username,Password,Hint) values ('" + r.FirstName + "','" + r.LastName + "'," +
                    "" + "'" + r.Username + "','" + r.Password + "','" + r.Hint + "')";
                DatabaseConnect dc = new DatabaseConnect();
                dc.Executequery(command);
                MessageBox.Show("Your account has been registered");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            startform sf = new startform();
            sf.Show();
            this.Hide();
        }
    }
}

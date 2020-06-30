using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITGS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_txt.Text)||string.IsNullOrEmpty(Pass_txt.Text))
            {
                MessageBox.Show("Please Enter Username and Password","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
            try
            {
                ITGSDataSetTableAdapters.AdminTableAdapter user = new ITGSDataSetTableAdapters.AdminTableAdapter();
                ITGSDataSet.AdminDataTable dt = user.GetDataByUsernamePassword(user_txt.Text,Pass_txt.Text);
                if (dt.Count>0)
                {
                    MessageBox.Show("WELCOME","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AdminMain adminMain = new AdminMain();
                    this.Hide();
                    adminMain.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();



        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

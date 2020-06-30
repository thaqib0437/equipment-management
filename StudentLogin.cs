using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ITGS
{
    public partial class StudentLogin : Form
    {

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ITGSDataSetTableAdapters.StudentUPTableAdapter user = new ITGSDataSetTableAdapters.StudentUPTableAdapter();
                ITGSDataSet.StudentUPDataTable dt = user.GetDataByStudUsernamePassword(username.Text,password.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Username and Password", "Message", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                }
                StudentMainForm studentMainForm = new StudentMainForm();
                studentMainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorr" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 first = new Form1();
            first.Show();
            this.Hide();

        }

        private void StudentLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

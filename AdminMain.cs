using System;
using System.Windows.Forms;

namespace ITGS
{
    public partial class AdminMain : Form
    {
        int count = 0;
        int count2 = 0;

        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTGSDataSet.DefaulterList' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'iTGSDataSet.StudentTable' table. You can move, or remove it, as needed.
            panel1.Hide();
            panel2.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            count++;

            if (count % 2 == 0)
            {
                panel1.Hide();

            }
            else
            {
                this.studentTableTableAdapter.Fill(this.iTGSDataSet.StudentTable);

                panel1.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            count2++;

            if (count2 % 2 == 0)
            {
                panel2.Hide();

            }
            else
            {
                this.defaulterListTableAdapter.Fill(this.iTGSDataSet.DefaulterList);

                panel2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditItems editItems = new EditItems();
            editItems.Show();
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

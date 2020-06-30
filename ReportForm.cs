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
    public partial class ReportForm : Form
    {
        string connectionString = (String)ITGS.Properties.Settings.Default.ITGSConnectionString;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();
            string query = "SELECT * FROM ItemList";

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Amount"].Points.AddXY(reader["Item Name"].ToString(), reader["Quantiy Issued"].ToString());
            }
           
            con.Close();


        }
    }
}

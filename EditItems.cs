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
    public partial class EditItems : Form
    {
        string connectionString = (String)ITGS.Properties.Settings.Default.ITGSConnectionString;

        public EditItems()
        {
            InitializeComponent();
        }

        private void EditItems_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(reader["Item Name"].ToString());
            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                OleDbConnection cone = new OleDbConnection(connectionString);

                OleDbCommand cmd = cone.CreateCommand();
                string query = "delete from ItemList where [Item Name] ='" + comboBox1.Text + "' ";
                cone.Open();

                cmd.Connection = cone;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Removed", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cone.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error Data not found" + ex, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)||String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {


                    OleDbConnection cone = new OleDbConnection(connectionString);


                    OleDbCommand cmd = cone.CreateCommand();
                    string query = "INSERT into ItemList([Item Name], [Quantiy Issued]) values('" + textBox1.Text + "','" + textBox2.Text + "')";

                    cone.Open();

                    cmd.Connection = cone;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cone.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
            



        }
    }
}

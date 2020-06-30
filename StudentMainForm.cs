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
using System.IO;


namespace ITGS
{
    

    public partial class StudentMainForm : Form
    {

        int i = 0;
        int j = 0;
        int k = 0;
        string connectionString = (String)ITGS.Properties.Settings.Default.ITGSConnectionString;
        


        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;


            for (int i = 0; i <10; i++)
            {
                quantity_box.Items.Add(i.ToString());
            }
            condition_box.Items.Add("Good");

            condition_box.Items.Add("Medium");
            condition_box.Items.Add("Bad");

            panel1.Hide();
            panel2.Hide();
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
                comboBox4.Items.Add(reader["Item Name"].ToString());
            }

            con.Close();
            panel1.Hide();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                panel1.Show();
                i = i++;
            }
            else
            {
                panel1.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (j % 2 == 0)
            {
                panel2.Show();
                j = j++;
            }
            else
            {
                panel1.Hide();
            }

        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            bool a = String.IsNullOrEmpty(name_txt.Text);
            bool b = comboBox1.SelectedItem == null;
            bool c = quantity_box.SelectedItem == null;
            bool d = condition_box.SelectedItem ==null;
            if (a||b||c||d)
            {
                MessageBox.Show("Enter All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                    

            try {


                OleDbConnection cone = new OleDbConnection(connectionString);



                var time = DateTime.Now;
                int quantity = System.Convert.ToInt32( quantity_box.Text);
                string formattedtime = time.ToString("yyyy-MM-dd hh:mm");
                OleDbCommand cmd = cone.CreateCommand();
                string query = "INSERT into StudentTable([Name], [Item Issued], [Quantity], [Time], [Condition]) values('" + name_txt.Text + "','" + comboBox1.Text + "','" + quantity_box.Text + "','" + formattedtime + "','" + condition_box.Text + "')";

                cone.Open();

                cmd.Connection = cone;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                panel1.Hide();
                cone.Close();

                OleDbCommand command2 = cone.CreateCommand();
                string query2 = "INSERT into DefaulterList([Name], [Item Issued], [Quantity], [Time], [Condition]) values('" + name_txt.Text + "','" + comboBox1.Text + "','" + quantity_box.Text + "','" + formattedtime + "','" + condition_box.Text + "')";

                cone.Open();
                command2.Connection = cone;
                command2.CommandText = query2;
                command2.ExecuteNonQuery();
                cone.Close();
                    name_txt.Clear();
                    comboBox1.ResetText();
                    quantity_box.ResetText();
                    condition_box.ResetText();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            bool a =String.IsNullOrEmpty(textBox2.Text);
            bool b = comboBox4.SelectedItem == null;
            if (a || b)
            {
                MessageBox.Show("Enter All Details", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

            try
            {


                OleDbConnection cone = new OleDbConnection(connectionString);
                
                 OleDbCommand cmd = cone.CreateCommand();
                string query = "delete from DefaulterList where [Name] ='"+textBox2.Text+"' AND [Item Issued] = '"+comboBox4.Text+"'";
                cone.Open();

                cmd.Connection = cone;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Returned", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel2.Hide();
                cone.Close();
                    textBox2.Clear();
                    comboBox4.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error Data not found" + ex,"Error 404",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

            }

        }

        private void condition_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void condition_box_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            if (e.Index ==0)
            {
                SolidBrush b = (SolidBrush)new SolidBrush(Color.Green);
                e.Graphics.DrawString("Good",new Font("Segoe UI",18,FontStyle.Regular), new SolidBrush(Color.Green),e.Bounds);
                e.DrawFocusRectangle();
            }
            if (e.Index == 1)
            {
                SolidBrush b = (SolidBrush)new SolidBrush(Color.Orange);
                e.Graphics.DrawString("Medium", new Font("Segoe UI", 18, FontStyle.Regular), new SolidBrush(Color.Orange), e.Bounds);
                e.DrawFocusRectangle();
            }
            if (e.Index == 2)
            {
                SolidBrush b = (SolidBrush)new SolidBrush(Color.Red);
                e.Graphics.DrawString("Bad", new Font("Segoe UI", 18, FontStyle.Regular), new SolidBrush(Color.Red), e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void quantity_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("This is restart the Application", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

                
                }
                else
                {

                }
                
           


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

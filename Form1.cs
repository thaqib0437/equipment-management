﻿using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\ITGS.accdb";

            try
            {
                connection.Open();
                MessageBox.Show("Connected to Database");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Database not found" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

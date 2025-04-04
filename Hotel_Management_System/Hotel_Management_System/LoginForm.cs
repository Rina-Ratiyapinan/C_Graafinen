﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `hotel_db` WHERE `username`=@usn AND `password`=@pass";
        
            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usernameTB.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordTB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if (usernameTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passwordTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    MessageBox.Show("This Username or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

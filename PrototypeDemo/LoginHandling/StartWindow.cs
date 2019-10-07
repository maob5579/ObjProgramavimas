﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginHandling;
using System.Data.SQLite;

namespace LoginHandling
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text.Trim() == "" && textBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Enter username and password!");
            }
            else
            {
                string query = "SELECT * From Table_Login WHERE Username == @Username and Password == @Password";
                SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=LoginDataBase.sqlite3;Version=3;");
                sqlConnection.Open();
                SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", textBox_Username.Text);
                sqlCommand.Parameters.AddWithValue("@Password", textBox_Password.Text);
                SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    this.Hide();
                    var mainForm = new MainWindow();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();

                }

                else
                {
                    MessageBox.Show("Login Failed");
                }




            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regForm = new RegisterWindow();
            regForm.Closed += (s, args) => this.Close();
            regForm.Show();
        }
    }
}
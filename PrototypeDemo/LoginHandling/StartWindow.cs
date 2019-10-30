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
using PrototypeDemo;

namespace LoginHandling
{
    public partial class StartWindow : Form
    {
        SQLiteConnection sqlConnection;
        SQLiteCommand sqlCommand;
        SQLiteDataAdapter sqlDataAdapter;

        public StartWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");

            MessageBox.Show(DataBase.GetUserID("admin").ToString());

        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text.Trim() == "" && textBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Enter username and password!");
                return;
            }

            string query = "SELECT * From User WHERE Username == @Username and Password == @Password";
            sqlConnection.Open();
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", textBox_Username.Text);
            sqlCommand.Parameters.AddWithValue("@Password", textBox_Password.Text);
            sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show(DataBase.GetUserID(textBox_Username.Text).ToString());
                switch (DataBase.GetUserID(textBox_Username.Text))
                {
                    case 2:
                        this.Hide();
                        var adminForm = new AdminForm();
                        adminForm.Closed += (s, args) => this.Close();
                        adminForm.Show();
                        break;
                    case 1:
                        this.Hide();
                        var resOwnerForm = new OwnerForm();
                        resOwnerForm.Closed += (s, args) => this.Close();
                        resOwnerForm.Show();
                        break;
                    case 0:
                        SQLiteDataReader reader = sqlCommand.ExecuteReader();
                        dataTable.Load(reader);
                        DataRow user= dataTable.Rows[0];
                        long loginId = user.Field<Int64>("LoginId");
//

                        this.Hide();
                        var newWindow = new PrototypeDemo.UserForm(textBox_Username.Text, loginId);
                        newWindow.ShowDialog();
                        this.Show();
                        break;
                    default:
                        MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            else
            {
                MessageBox.Show("Login Failed");
            }

            sqlConnection.Close();
        }

    

    private bool isAdmin(string username, string password)
    {
        string query = "SELECT UserType From User WHERE Username == @Username and Password == @Password and UserType == 1";
        SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
        sqlConnection.Open();
        SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
        sqlCommand.Parameters.AddWithValue("@Username", username);
        sqlCommand.Parameters.AddWithValue("@Password", password);
        SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
        DataTable dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        if (dataTable.Rows.Count > 0)
        {
            sqlConnection.Close();
            return true;
        }
        else
        {
            sqlConnection.Close();
            return false;
        }
    }

    private void button_Register_Click(object sender, EventArgs e)
    {
        this.Hide();
        var regForm = new RegisterWindow();
        regForm.Closed += (s, args) => this.Close();
        regForm.Show();
    }

    private void textBox_Username_TextChanged(object sender, EventArgs e)
    {

    }
}
}

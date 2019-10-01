using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LoginHandling
{
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logForm = new StartWindow();
            logForm.Closed += (s, args) => this.Close();
            logForm.Show();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text.Trim() == "" || textBox_Password.Text.Trim() == "" || textBox_PasswordComfirm.Text.Trim() == "")
            {
                MessageBox.Show("Fill all the fields");
            }
           else if (textBox_Password.Text.Trim() != textBox_PasswordComfirm.Text.Trim())
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (textBox_Password.Text.Length < 7)
            {
                MessageBox.Show("Password must include atleast 7 characters");
            }
            else
            {
                string query = "INSERT into Table_Login (Username,Password) values(@Username,@Password);";
              
                SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=LoginDataBase.sqlite3;Version=3;");
                sqlConnection.Open();
                SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", textBox_Username.Text);
                sqlCommand.Parameters.AddWithValue("@Password", textBox_Password.Text);
                sqlCommand.ExecuteNonQuery();
                
                
                

            }
        }
    }
}

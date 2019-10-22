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
                string query = "INSERT into User (Username,Password,FirstName,LastName,UserType) values(@Username,@Password,@FirstName,@LastName,0);";
              
                SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
                sqlConnection.Open();
                if (!usernameExists(textBox_Username.Text))
                {
                    SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Username", textBox_Username.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", textBox_Password.Text);
                    sqlCommand.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
                    sqlCommand.Parameters.AddWithValue("@LastName", textBox_LastName.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Registracija atlikta sekmingai");
                    button_SignIn.PerformClick();

                }
                else
                {
                    MessageBox.Show("This username already exists");
                    return;
                }



            }
        }
                    
        bool usernameExists (string username)
        {
            string query = "SELECT Username From User WHERE Username == @Username";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", username);
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
        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox_PasswordComfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

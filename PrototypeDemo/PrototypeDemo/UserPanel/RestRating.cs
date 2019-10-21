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

namespace PrototypeDemo
{
    public partial class RestRating : Form
    {
        SQLiteCommand sqlCommand;
        SQLiteDataReader sqlRead;
        public RestRating()
        {
            InitializeComponent();
        }

        private void RestRating_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            string query = "SELECT DISTINCT Name From Restaurant ORDER BY Name ASC";
            sqlConnection.Open();
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlRead = sqlCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                comboBox1.Items.Add(sqlRead[0]);
            }
            sqlRead.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar2.Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addRestaurant_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Add a restaurant!");
                return;
            }
            else 
            {
                SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
                sqlConnection.Open();
                if (restaurantExist(textBox1.Text))
                {
                    MessageBox.Show("This restaurant is already added!");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.ResetText();
                }
            }

        }

        bool restaurantExist(string restName)
        {
            string query = "SELECT Name From Restaurant WHERE Name == @Name";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", restName);
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

         private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // default mood rating - 10
            string query = "INSERT into Restaurant (Username, Name, MoodRating, Price, Experience) values(@Username,@Name,10,@Price,@Experience);";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();  
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", Account.Username);
            sqlCommand.Parameters.AddWithValue("@Name", comboBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Price", label3.Text);
            sqlCommand.Parameters.AddWithValue("@Experience", label6.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using PrototypeDemo.Models;

namespace PrototypeDemo
{
    public partial class RestRating : Form
    {
        SQLiteCommand sqlCommand;
        SQLiteDataReader sqlRead;
        private double happinessRating;
        public RestRating(double happy)
        {
            InitializeComponent();

            MoodModel mood = new MoodModel();
            this.happinessRating = Math.Round(happy*10, 2);
            label8.Text = happinessRating.ToString();
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
                    string query = "INSERT into Restaurant (Name) values(@Name);";
                    SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Name", textBox1.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
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
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            string query = "SELECT * From Restaurant WHERE Name == @Name";
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", comboBox1.Text);
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No restaurant selected!");
                return;
            }
            SQLiteDataReader reader = sqlCommand.ExecuteReader();
            dataTable.Load(reader);
            
            DataRow restaurant = dataTable.Rows[0];
            long restaurantId = restaurant.Field<Int64>("RestaurantId");

            InsertEvaluation(restaurantId);
            InsertAVGEvaluation(restaurantId);
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InsertEvaluation(long restId)
        {
            
            string query = "INSERT into Evaluation (UserId, RestaurantId, MoodRating, Price, Experience) values(@UserId,@RestaurantId,@MoodRating,@Price,@Experience);";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();  
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", Account.LoginId);
            sqlCommand.Parameters.AddWithValue("@RestaurantId", restId);
            sqlCommand.Parameters.AddWithValue("@MoodRating", happinessRating);
            sqlCommand.Parameters.AddWithValue("@Price", label3.Text);
            sqlCommand.Parameters.AddWithValue("@Experience", label6.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void InsertAVGEvaluation(long restId)
        {
            string query = "SELECT AVG(MoodRating) AS MoodRating, AVG(Price) AS Price, AVG(Experience) AS Experience From Evaluation WHERE RestaurantId == @RestId";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@RestId", restId);
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            SQLiteDataReader reader = sqlCommand.ExecuteReader();
            dataTable.Load(reader);

            DataRow evaluation = dataTable.Rows[0];
            double avgMood = evaluation.Field<double>("MoodRating");
            double avgPrice = evaluation.Field<double>("Price");
            double avgExperience = evaluation.Field<double>("Experience");

            string query1 = "UPDATE Restaurant SET AVGMood = @AVGMood, AVGPrice = @AVGPrice, AVGExperience = @AVGExperience WHERE RestaurantId = @RestId";
            SQLiteCommand sqlCommand1 = new SQLiteCommand(query1, sqlConnection);
            sqlCommand1.Parameters.AddWithValue("@RestId", restId);
            sqlCommand1.Parameters.AddWithValue("@AVGMood", avgMood);
            sqlCommand1.Parameters.AddWithValue("@AVGPrice", avgPrice);
            sqlCommand1.Parameters.AddWithValue("@AVGExperience", avgExperience);
            sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

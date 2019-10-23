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
    public partial class RatedRest : Form
    {
        public RatedRest()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RatedRest_Load(object sender, EventArgs e)
        {
             string query = "SELECT Name, ROUND(MoodRating,2) AS MoodRating, Price, Experience From Restaurant, Evaluation, User WHERE Evaluation.UserId == @User AND User.LoginId = Evaluation.UserId AND Restaurant.RestaurantId = Evaluation.RestaurantId";
             SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
             sqlConnection.Open();
             SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
             sqlCommand.Parameters.AddWithValue("@User", Account.LoginId);
             SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
             DataTable dataTable = new DataTable();
             sqlDataAdapter.Fill(dataTable);

             dataGridView1.DataSource = dataTable;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

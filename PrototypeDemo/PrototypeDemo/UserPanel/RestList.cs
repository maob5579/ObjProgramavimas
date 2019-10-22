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
    public partial class RestList : Form
    {
        
        public RestList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RestList_Load(object sender, EventArgs e)
        {
            FillMoodRating();
            FillExperienceRating();
            FillPriceRating();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillMoodRating()
        {

            string query = "SELECT Name, ROUND(AVGMood,2) As AVGMood From Restaurant ORDER BY AVGMood DESC";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }
        private void FillPriceRating()
        {
            string query = "SELECT Name, ROUND(AVGPrice,2) As AVGPrice From Restaurant ORDER BY AVGPrice DESC";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }
        private void FillExperienceRating()
        {
            string query = "SELECT Name, ROUND(AVGExperience,2) AS AVGExperience From Restaurant ORDER BY AVGExperience DESC";
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            sqlConnection.Open();
            SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;
        }
    }
}

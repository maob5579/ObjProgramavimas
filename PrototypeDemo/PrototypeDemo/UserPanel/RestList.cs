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
    public partial class RestList : Form
    {
        SQLiteCommand sqlCommand;
        SQLiteDataReader sqlRead;
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
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            string query = "SELECT DISTINCT Name From Restaurant ORDER BY MoodRating DESC";
            sqlConnection.Open();
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlRead = sqlCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                listBox1.Items.Add(sqlRead[0]);
            }
            sqlRead.Close();

            string query2 = "SELECT DISTINCT Name From Restaurant ORDER BY Price DESC";
            
            sqlCommand = new SQLiteCommand(query2, sqlConnection);
            sqlRead = sqlCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                listBox2.Items.Add(sqlRead[0]);
            }
            sqlRead.Close();

            string query3 = "SELECT DISTINCT Name From Restaurant ORDER BY Experience DESC";
            
            sqlCommand = new SQLiteCommand(query3, sqlConnection);
            sqlRead = sqlCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                listBox3.Items.Add(sqlRead[0]);
            }
            sqlRead.Close();

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
    }
}

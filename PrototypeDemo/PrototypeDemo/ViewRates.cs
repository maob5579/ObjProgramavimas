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
    public partial class ViewRates : Form
    {
        SQLiteCommand sqlCommand;
        SQLiteDataReader sqlRead;
        public ViewRates()
        {
            InitializeComponent();
            

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerForm newWindow = new OwnerForm();
            newWindow.Closed += (s, args) => this.Close();
            newWindow.Show();
        }

        private void comboRestaurantList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void ViewRates_Load(object sender, EventArgs e)
        {
            

            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            string query = "SELECT DISTINCT Name From Restaurant ORDER BY Name ASC";
            sqlConnection.Open();
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlRead = sqlCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                comboRestaurantList.Items.Add(sqlRead[0]);
            }
            sqlRead.Close();

            

        }

        

        private void RatingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

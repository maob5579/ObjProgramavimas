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
    public partial class RatedRest : Form
    {
        SQLiteCommand sqlCommand;
        SQLiteDataReader sqlRead;
        SQLiteDataAdapter sqlDataAdapter;
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
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            string query = "SELECT DISTINCT Name From Restaurant Where Username = @Username ORDER BY Name ASC";
            sqlConnection.Open();
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username",Account.Username);

            sqlRead = sqlCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                listBox1.Items.Add(sqlRead[0]);
            }
            sqlRead.Close();
           
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
    }
}

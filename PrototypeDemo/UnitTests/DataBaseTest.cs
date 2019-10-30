using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginHandling;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace UnitTests
{
    [TestClass]
    public class DataBaseTest
    {
        string dataBasePath = string.Empty;
        private static SQLiteConnection sqlConnection = null;
        private static SQLiteCommand sqlCommand;
        private static SQLiteDataAdapter sqlDataAdapter;
        private static DataTable dataTable;
        private static SQLiteDataReader dataReader;


        //Set the data base location
        private void CheckDataBaseFilePath()
        {
            if (sqlConnection == null)
            {

                OpenFileDialog ofd = new OpenFileDialog()
                {
                    Title = "Select MoodFull database",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Multiselect = false,
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dataBasePath = ofd.FileName;
                }

                string connectionProperties = string.Format(@"Data Source={0};Version=3;", ofd.FileName);
                sqlConnection = new SQLiteConnection(connectionProperties);
            }
            return;
        }

        //Negaliu tiesiogiai iskviesti GetUserID metodo. Nemato duombazes.
        //Copy paste GetUserID metoda.
        private int CheckUserID(string username)
        {
            CheckDataBaseFilePath();
            sqlConnection.Open();
            int ID = -1;
            string query = string.Empty;

            query = "SELECT UserType FROM User WHERE Username == @Username ORDER BY Username";


            if (query == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Error with SQL query");
                return -1;
            }
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue(@"Username", username);
            sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            object obj = 0;

            if (dataTable.Rows.Count > 0)
            {
                obj = dataTable.Rows[0]["UserType"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Vartotojas nerastas");
            }
            sqlConnection.Close();
            int.TryParse(obj.ToString(), out ID);
            return ID;
        }

        [TestMethod]
        public void CheckUserID_IsAdmin_ReturnsAdminID()
        {
            int ID = CheckUserID("admin");
            Assert.AreEqual(1, ID);
        }

        [TestMethod]
        public void CheckUserID_IsOwner_ReturnsOwnerID()
        {
            int ID = CheckUserID("owner");
            Assert.AreEqual(2, ID);
        }

        [TestMethod]
        public void CheckUserID_IsUser_ReturnsUserID()
        {
            int ID = CheckUserID("labas");
            Assert.AreEqual(0, ID);
        }


        //[TestMethod]
        //public void CheckRestaurantID_IdExists_ReturnsRestID()
        //{
        //    int restaurantID = DataBase.GetUserID("admin");
        //}



    }
}

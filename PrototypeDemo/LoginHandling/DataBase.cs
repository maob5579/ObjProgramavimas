using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace LoginHandling
{
    static class DataBase
    {
        private static SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
        private static SQLiteCommand sqlCommand;
        private static SQLiteDataAdapter sqlDataAdapter;
        private static DataTable dataTable;



        //Checks if User name exists. Returns data table
        public static DataTable CheckUsername(string name, string lastName)
        {
            string query = "SELECT * From User WHERE Username == @Username";
            sqlConnection.Open();
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", name);
            sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        /***
         *Gets user types
         * User Types:
         * 2 - ADMIN
         * 1 - Restaurant Owner
         * 0 - Simple use
        */
        public static int GetUserID(string userName)
        {
            sqlConnection.Open();
            int ID;
            string query = "SELECT UserType FROM User WHERE Username == @Username";
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue(@"Username", userName);
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



    }
}

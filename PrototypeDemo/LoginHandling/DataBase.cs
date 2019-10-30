using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace LoginHandling
{

    public static class DataBase
    {


        private static SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
        private static SQLiteCommand sqlCommand;
        private static SQLiteDataAdapter sqlDataAdapter;
        private static DataTable dataTable;
        private static SQLiteDataReader dataReader;

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
        public static int GetUserID(string userName, string password = null)
        {

            sqlConnection.Open();
            int ID;
            string query = string.Empty;
            if (password != null)
            {
                query = "SELECT UserType FROM User WHERE Username == @Username AND Password == @Password ORDER BY Username";

            }
            else
            {
                query = "SELECT UserType FROM User WHERE Username == @Username ORDER BY Username";
            }

            if (query == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Error with SQL query");
                return -1;
            }
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
        public static List<Evaluation> GetEvaluationList()
        {
            List<Evaluation> evaluationList = new List<Evaluation>();
            sqlConnection.Open();
            string query = "SELECT EvaluationId,UserId,RestaurantId,MoodRating,Price,Experience FROM Evaluation";
            sqlCommand = new SQLiteCommand(query, sqlConnection);

            using (dataReader = sqlCommand.ExecuteReader())
            {
                while (dataReader.Read())
                {

                    evaluationList.Add(new Evaluation(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetDouble(3), dataReader.GetInt32(4), dataReader.GetInt32(5)));


                }
            }
            sqlConnection.Close();

            return evaluationList;
        }


        public static string GetRestauranName(int ID)
        {
            sqlConnection.Open();
            string restaurantName;
            string query = "SELECT Name FROM Restaurant WHERE RestaurantId == @RestaurantId";
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue(@"RestaurantId", ID);
            sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            object obj = 0;

            if (dataTable.Rows.Count > 0)
            {
                obj = dataTable.Rows[0][0];
            }
            sqlConnection.Close();
            restaurantName = obj.ToString();
            Console.WriteLine(restaurantName);
            return restaurantName;
        }

        public static int GetRestaurantID(string name)
        {

            DataTable dataTable;
            sqlConnection.Open();
            int restaurantId;
            string query = "SELECT RestaurantId FROM Restaurant WHERE Name == @Name";
            sqlCommand = new SQLiteCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue(@"Name", name);
            sqlDataAdapter = new SQLiteDataAdapter(sqlCommand);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            object obj = 0;

            if (dataTable.Rows.Count > 0)
            {
                obj = dataTable.Rows[0][0];
            }
            sqlConnection.Close();
            int.TryParse(obj.ToString(), out restaurantId);
            Console.WriteLine(restaurantId);
            return restaurantId;
        }

    }
}

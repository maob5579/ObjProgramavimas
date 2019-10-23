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
        List<Evaluation> evaluationList = GetEvaluationList();
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
            
            listView_Evaluation.Items.Clear();
            foreach(Evaluation element in evaluationList)
            {
                if(element.getRestaurantId()==GetRestaurantID(comboRestaurantList.GetItemText(comboRestaurantList.SelectedItem)))
                {   ListViewItem data = new ListViewItem(new[] {element.getMoodRating().ToString(),element.getPrice().ToString(),element.getExperience().ToString() });
                    listView_Evaluation.Items.Add(data);
                    
                }
            }
            



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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public static string GetRestauranName(int ID)
        {
         SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
         SQLiteCommand sqlCommand;
         SQLiteDataAdapter sqlDataAdapter;
         DataTable dataTable;
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
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            SQLiteCommand sqlCommand;
            SQLiteDataAdapter sqlDataAdapter;
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

        public static List<Evaluation> GetEvaluationList()
        {
            SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=MoodfullDataBase.sqlite3;Version=3;");
            SQLiteCommand sqlCommand;
            SQLiteDataAdapter sqlDataAdapter;
            DataTable dataTable;
            SQLiteDataReader dataReader;
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

        private void listView_Evaluation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

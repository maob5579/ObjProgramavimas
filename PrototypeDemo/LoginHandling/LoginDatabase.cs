using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace LoginHandling
{
    class LoginDatabase
    {
        public SQLiteConnection dataBaseConnection;

        public LoginDatabase() {


            dataBaseConnection = new SQLiteConnection("Data Source = MoodfullDataBase.sqlite3");
            if (!File.Exists("./MoodfullDataBase.sqlite3"))
            {
                SQLiteConnection.CreateFile("MoodfullDataBase.sqlite3");

            }
            }

    }
}

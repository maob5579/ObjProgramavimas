using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginHandling;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UnitTests
{
    [TestClass]
    public class DataBaseTest
    {
        string dataBasePath = string.Empty;

        //Set the data base location
        public void CheckDataBaseFilePath()
        {
            //Get data base file
            if (dataBasePath == string.Empty)
            {
                OpenFileDialog ofd = new OpenFileDialog()
                {
                    Title = "Select MoodFull database",
                    InitialDirectory =Environment.GetFolderPath( Environment.SpecialFolder.Desktop),
                    Multiselect = false,
                };


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dataBasePath = ofd.FileName;
                }
                //if (dataBasePath == string.Empty)
                {
                    return;
                }
            }

            MessageBox.Show(DataBase.GetUserID("Admin").ToString());
        }

        /*
                [TestMethod]
                public void CheckUserID_IsAdmin_ReturnsAdminID()
                {

                    int UserID = DataBase.GetUserID("Admin");
                    MessageBox.Show(UserID.ToString());


                }
        */

        [TestMethod]
        public void CheckRestaurantID_IdExists_ReturnsRestID()
        {
            int restaurantID = DataBase.GetRestaurantID("can can");
          
          


        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototypeDemo.Models;

namespace PrototypeDemo
{
    public partial class UserForm : Form
    {
        public UserForm(string name, long loginId)
        {
            InitializeComponent();
            nameBox.Text = name;
            Account.Username = name;
            Account.LoginId = loginId;
        }

        private void btnRateRestaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newWindow = new Form1();
            newWindow.ShowDialog();
            this.Show();
            
            /*
            this.Hide();
            Form1 cameraWindow  = new Form1();
            cameraWindow.Closed += (s, args) => this.Close();
            cameraWindow.Show();
            */
        }

        private void btnShowRatedRestaurants_Click(object sender, EventArgs e)
        {
            this.Hide();
            RatedRest newWindow = new RatedRest();
            newWindow.ShowDialog();
            this.Show();
        }

        private void btnShowRestaurantList_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestList newWindow = new RestList();
            newWindow.ShowDialog();
            this.Show();
        }

        private void btnShowFavorites_Click(object sender, EventArgs e)
        {
            this.Hide();
            FavRest newWindow = new FavRest();
            newWindow.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}

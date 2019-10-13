using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDemo
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnRateRestaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 cameraWindow  = new Form1();
            cameraWindow.Closed += (s, args) => this.Close();
            cameraWindow.Show();
        }

        private void btnShowRatedRestaurants_Click(object sender, EventArgs e)
        {
            this.Hide();
            RatedRest newWindow = new RatedRest();
            newWindow.Closed += (s, args) => this.Close();
            newWindow.Show();
        }

        private void btnShowRestaurantList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 cameraWindow = new Form1();
            cameraWindow.Closed += (s, args) => this.Close();
            cameraWindow.Show();
        }

        private void btnShowFavorites_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 cameraWindow = new Form1();
            cameraWindow.Closed += (s, args) => this.Close();
            cameraWindow.Show();
        }
    }
}

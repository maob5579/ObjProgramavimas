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
    public partial class AddRestaurant : Form
    {
        public AddRestaurant()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerForm newWindow = new OwnerForm();
            newWindow.Closed += (s, args) => this.Close();
            newWindow.Show();
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regForm = new AddRestaurant();
            regForm.Closed += (s, args) => this.Close();
            regForm.Show();
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regForm = new DeleteRestaurant();
            regForm.Closed += (s, args) => this.Close();
            regForm.Show();
        }

        private void btnViewRatings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regForm = new ViewRates();
            regForm.Closed += (s, args) => this.Close();
            regForm.Show();

        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}

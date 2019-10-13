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
    public partial class DeleteRestaurant : Form
    {
        public DeleteRestaurant()
        {
            InitializeComponent();
        }
        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerForm newWindow = new OwnerForm();
            newWindow.Closed += (s, args) => this.Close();
            newWindow.Show();
        }
        private void DeleteRestaurant_Load(object sender, EventArgs e)
        {

        }

    }
}

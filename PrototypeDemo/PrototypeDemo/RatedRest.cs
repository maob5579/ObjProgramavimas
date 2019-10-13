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
    public partial class RatedRest : Form
    {
        public RatedRest()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm newWindow = new UserForm();
            newWindow.Closed += (s, args) => this.Close();
            newWindow.Show();
        }
    }
}

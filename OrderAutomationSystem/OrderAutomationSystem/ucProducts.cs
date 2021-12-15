using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomationSystem
{
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = string.Empty;
        }

        private void txtWeight_Click(object sender, EventArgs e)
        {
            txtWeight.Text = string.Empty;
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Text = string.Empty;
        }
    }
}

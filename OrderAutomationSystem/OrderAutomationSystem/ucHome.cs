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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }
        public ucHome(ICustomers customer) : this()
        {
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtBalance.Text = customer.Balance.ToString();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {

        }
    }
}

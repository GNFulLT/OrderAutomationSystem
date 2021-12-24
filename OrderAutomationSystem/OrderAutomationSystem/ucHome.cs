using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomationSystem
{
    public partial class ucHome : UserControl
    {
        Customers customer;
        public ucHome()
        {
            InitializeComponent();
        }
        public ucHome(Customers customer) : this()
        {
            this.customer = customer;
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtBalance.Text = customer.Balance.ToString();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {

        }

        private void ucHome_MouseMove(object sender, MouseEventArgs e)
        {
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cmd = $"UPDATE Customers SET Name = \"{txtName.Text}\", Surname = \"{txtSurname.Text}\", Address = \"{txtAddress.Text}\" WHERE CustomerID = {this.customer.CustomerID}";
            Crud.ARU(cmd);

        }
    }
    
    
}

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
    public partial class PaymentCredit : Form
    {
        Order order;
        internal event callBack completed;
        public PaymentCredit()
        {
            InitializeComponent();
        }
        internal void getOrder(Order order)
        {
            this.order = order;
            txtAmount.Text = order.Details.TotalAmount.ToString();
            txtAmount.Enabled = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            PaymentForm pf = Application.OpenForms["PaymentForm"] as PaymentForm;
            pf.lblExit_Click(null, null);
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            ExpDate exp = new ExpDate();
            exp.month = cmbMonth.SelectedItem.ToString();
            exp.year = cmbYear.SelectedItem.ToString();
            Credit crdt = new Credit(Convert.ToInt32(txtAmount.Text), txtNumber.Text, exp);
            PaymentEvents pe = new PaymentEvents();
            pe.Completed = true;
            order.Details.Address = txtAdress.Text;
            crdt.Name = txtName.Text;
            crdt.Surname = txtSurname.Text;
            pe.Order = order;

            orderPayment op = new orderPayment();

            op.Show();


            this.completed(crdt, pe);

        }
    }
}

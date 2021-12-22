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
        public PaymentCredit()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["PaymentForm"].Close();
            this.Dispose();
        }
        public static void FormClose(PaymentForm pf, PaymentCredit pc)
        {
            pc.Dispose();
            pf.Dispose();
        }
    }
}

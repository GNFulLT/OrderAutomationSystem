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
    public partial class ucBasket : UserControl
    {

        bool isStopped = true;
        Customers customer;
        public ucBasket()
        {
            InitializeComponent();
            //  ucItem.items; sepetteki itemleri çeker List şeklinde
            txtPrice.Enabled = false;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            lblLoading.Visible = false;

        }
        public ucBasket(Customers customers) : this()
        {
            this.customer = customers;
        }

        internal static void itemAdd(Item item)
        {
            ListBox list = (ListBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["listBasket"];
            list.Items.Add(item);
            Label lb = (Label)customerMenu.userControls[2].Controls["panelBasket"].Controls["groupBoxInfo"].Controls["lblCost2"];
            lb.Text = (Convert.ToInt32(lb.Text) + (item.Amount * item.Price)).ToString();
            TextBox txt = (TextBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["txtPrice"];

        }

        internal static void itemRemove(Item item)
        {
            ListBox list = (ListBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["listBasket"];

            list.Items.Remove(item);

        }

        private void panelBasket_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void pay_Click(object sender, EventArgs e)
        {
            if (!isStopped)
                return;
            List<Item> items = new List<Item>();
            int calc = 0;
            foreach (Item item in listBasket.Items)
            {
                items.Add(item);
                calc = calc + item.Amount;
            }
            OrderDetail details = new OrderDetail();
            Order order = new Order();
            lblLoading.Visible = true;
            await Task.Run(() =>
            {
                lblLoading.Visible = true;
                details.setDetail(items, calc);
                order.setOrder(details);

            });
            bool verify = order.verifyInternet();
            if (verify)
            {

            }
            else
            {
                MessageBox.Show("There is no internet connection.(To see the remainder of the project, Application will keep continue.");
                order.Date = DateTime.Now;
            }
            lblLoading.Visible = false;
            PaymentForm pf = new PaymentForm(order);
            pf.completed += closed;
            pf.Show();

        }


        private void closed(object sender, PaymentEvents e)
        {
            isStopped = true;
            if (sender == null)
            {

            }
            else
            {
                Payment p = sender as Payment;
                string cmd = $"SELECT seq from sqlite_sequence where name = \"Orders\"";

                int id = Crud.Quantity(cmd);
                if (id == -1)
                    id = 0;
                string sid = customer.CustomerID.ToString() + id.ToString();
                foreach (Item item in e.Order.Details.Items)
                {
                    cmd = $"INSERT INTO Orders (OrderIDs, ItemID, CustomerID, Quantity, Name, Surname, Address, Date, Status, TotalPrice) VALUES ('{sid}','{item.ItemID}','{customer.CustomerID}','{item.Amount}','{p.Name}','{p.Surname}','{e.Order.Details.Address}','{e.Order.Date}','{e.Order.State}','{e.Order.Details.TotalAmount}')";
                    Crud.ARU(cmd);
                }

                ucProfil home = customerMenu.userControls[1] as ucProfil;
                foreach (var item in home.Controls["itemPanel"].Controls)
                {
                    if (item is ucItem)
                    {
                        ucItem ucitem = item as ucItem;
                        ucitem.disable();
                    }
                }
                listBasket.Items.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtDescription.Clear();
                txtQuantitity.SelectedIndex = 0;
                lblCost2.Text = "0";
            }
        }
        private void listBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtName.Text = listBasket.SelectedItem.ToString();
            ListBox lbox = sender as ListBox;
            Item U1 = lbox.SelectedItem as Item;
            if (U1 == null)
                return;
            txtName.Text = U1.Name;
            txtQuantitity.SelectedIndex = txtQuantitity.FindStringExact((U1.Amount).ToString());
            txtPrice.Text = (U1.Price * Convert.ToInt32(txtQuantitity.Text)).ToString();
            txtDescription.Text = U1.Description;
        }
        private void enabledColor(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2TextBox box = sender as Guna.UI2.WinForms.Guna2TextBox;
            box.ForeColor = Color.FromArgb(125, 137, 149);
            box.FillColor = Color.White;


        }
        private void enabledColor_Paint(object sender, PaintEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox box = sender as Guna.UI2.WinForms.Guna2TextBox;

        }


        private void txtQuantitity_SelectedIndexChanged(object sender, EventArgs e)
        {

            Item U1 = listBasket.SelectedItem as Item;
            if (U1 == null)
                return;
            U1.Amount = Convert.ToInt32(txtQuantitity.Text);
            if (!(U1 is null))
                txtPrice.Text = (U1.Price * Convert.ToInt32(txtQuantitity.Text)).ToString();
            int total = 0;
            foreach (Item item in listBasket.Items)
            {
                total = total + item.Amount * item.Price;
            }
            lblCost2.Text = total.ToString();

        }
    }
}
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
       
        public ucBasket()
        {
            InitializeComponent();
            //  ucItem.items; sepetteki itemleri çeker List şeklinde
            txtPrice.Enabled = false;
            txtName.Enabled = false;
            txtDescription.Enabled = false;

        }

        internal static void itemAdd(Item item)
        {
            ListBox list = (ListBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["listBasket"];
            list.Items.Add(item);
            Label lb =(Label) customerMenu.userControls[2].Controls["panelBasket"].Controls["groupBoxInfo"].Controls["lblCost2"];
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

        private void pay_Click(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();
            int calc = 0;
            foreach(Item item in listBasket.Items)
            {
                items.Add(item);
                calc = calc + item.Amount;
            }
            /*OrderDetail details = new OrderDetail(items);*/
        }

        private void listBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtName.Text = listBasket.SelectedItem.ToString();
            ListBox lbox = sender as ListBox;
            Item U1 = lbox.SelectedItem as Item;
            txtName.Text = U1.Name;
            txtQuantitity.SelectedIndex =  txtQuantitity.FindStringExact((U1.Amount).ToString());
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
            U1.Amount = Convert.ToInt32(txtQuantitity.Text);
            if (!(U1 is null))
                txtPrice.Text = (U1.Price * Convert.ToInt32(txtQuantitity.Text)).ToString();
            int total = 0;
            foreach(Item item in listBasket.Items)
            {
                total = total + item.Amount * item.Price;
            }
            lblCost2.Text = total.ToString();

        }
    }
}
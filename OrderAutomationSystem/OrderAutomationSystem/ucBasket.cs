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
            TextBox txt = (TextBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["txtPrice"];

        }

        internal static void itemRemove(Item item)
        {
            ListBox list = (ListBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["listBasket"];
            list.Items.Remove(item);

        }

        private void ucBasket_Load(object sender, EventArgs e)
        {


        }



        private void panelBasket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void listBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtName.Text = listBasket.SelectedItem.ToString();
            ListBox lbox = (ListBox)sender;
            Item U1 = (Item)lbox.SelectedItem;
            txtName.Text = U1.Name;
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

        private void ucBasket_MouseMove(object sender, MouseEventArgs e)
        {
          
        }
        
    }
}
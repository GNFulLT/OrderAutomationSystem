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
    public partial class ucItem : UserControl
    {
       
        Item item;
        public ucItem()
        {
            InitializeComponent();
        }
        public ucItem(Item item) : this()
        {
            this.item = item;
            lblName.Text = item.Name;
            lblPrice.Text = item.Price.ToString();
            checkedBox.Visible = false;
            

        }
        public void disable()
        {
            checkedBox.Visible = false;
        }



        private void mainPanel_Click(object sender, EventArgs e)
        {
           
            checkedBox.Visible = !checkedBox.Visible;
            if (checkedBox.Visible)
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, true);

                ucBasket.itemAdd(item);
               
                
            }
            else
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, false);
                ucBasket.itemRemove(item);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            checkedBox.Visible = !checkedBox.Visible;
            if (checkedBox.Visible)
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, true);
                ucBasket.itemAdd(item);
            }
            else
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, false);
                ucBasket.itemRemove(item);
            }

        }

        private void ucItem_Load(object sender, EventArgs e)
        {

        }
    }
}

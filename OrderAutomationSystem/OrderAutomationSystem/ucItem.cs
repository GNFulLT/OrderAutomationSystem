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
        public static List<Item> items = new List<Item>();//Sepete eklenmiş eşyalar
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

      

        private void mainPanel_Click(object sender, EventArgs e)
        {
           
            checkedBox.Visible = !checkedBox.Visible;
            if (checkedBox.Visible)
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, true);
                items.Add(item);
            }
            else
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, false);
                items.Remove(item);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            checkedBox.Visible = !checkedBox.Visible;
            if (checkedBox.Visible)
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, true);
                items.Add(item);
            }
            else
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, false);
                items.Remove(item);

            }

        }

        private void ucItem_Load(object sender, EventArgs e)
        {

        }
    }
}

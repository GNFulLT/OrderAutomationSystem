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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maxi_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maxi.Visible = false;
            Reload.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Reload.Visible = false;
            Maxi.Visible = true;
           
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}

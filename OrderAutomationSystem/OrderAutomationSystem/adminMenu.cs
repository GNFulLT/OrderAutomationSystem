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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }
        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pctMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pctMaximize.Visible = false;
            pctRestore.Visible = true;
        }
        private void pctRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pctRestore.Visible = false;
            pctMaximize.Visible = true;
        }

        private void pctMenuSideBar_Click(object sender, EventArgs e)
        {
            if (gunaMenuBar.Width == 202)
            {
                gunaMenuBar.Width = 65;
                sidebarWrapper.Width = 90;
                btnPersonnels.Text = string.Empty;
                pnlLine.Width = 45;
            }
            else
            {
                gunaMenuBar.Width = 202;
                sidebarWrapper.Width = 300;
                btnPersonnels.Text = "Personnels";
                pnlLine.Width = 240;
            }
        }

        private void menuTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

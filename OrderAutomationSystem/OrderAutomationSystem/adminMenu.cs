using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OrderAutomationSystem
{
    public partial class adminMenu : Form
    {
        bool isLight = false;
        Task t1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int l,
        int t,
        int r,
        int b,
        int a,
        int qw
            );

        public adminMenu()
        {
            InitializeComponent();
            /*this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));*/
            loffBtn.Location = lightBtn.Location;

            
        }
        public adminMenu(bool isLight) : this()
        {
            
            this.isLight = isLight;
            if (isLight)
            {
                extButton2.Visible = true;//kapalı modda kapalı olucak
                menuTop.BackColor = Color.FromArgb(224, 224, 224);
                sidebarWrapper.BackColor = Color.FromArgb(240, 240, 240);
                this.BackColor = Color.FromArgb(240, 240, 240);

                gunaMenuBar.FillColor = Color.FromArgb(66, 204, 255);
                gunaMenuBar.FillColor2 = Color.FromArgb(66, 204, 255);

                btnDashboard.ForeColor = Color.WhiteSmoke;
                btnPersonnels.ForeColor = Color.WhiteSmoke;
                btnProducts.ForeColor = Color.WhiteSmoke;
                btnCustomers.ForeColor = Color.WhiteSmoke;
                lblMenuName.ForeColor = Color.FromArgb(127, 131, 134);
                lblUserName.ForeColor = Color.FromArgb(127, 131, 134);
            }

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
            if(!(t1 is null)) {
                if (!t1.IsCompleted || !AnimationSidebar.IsCompleted || !AnimatiomSidebarBack.IsCompleted)
                    return;
            }
            
            if (gunaMenuBar.Width == 200)
            {
                gunaMenuBar.Visible = false;
                btnPersonnels.Text = string.Empty;
                t1 = new Task(() =>
                {
                    int i = 200;
                    int t = 300;
                    int b = 240;
                    this.BeginInvoke(new Action(() =>
                    {

                        while (i != 65)
                        {
                            i = i - 9;
                            t = t - 14;
                            b = b - 13;
                            gunaMenuBar.Width = i;
                            sidebarWrapper.Width = t;
                            pnlLine.Width = b;
                            System.Threading.Thread.Sleep(5);
                        }

                    }));
                    


                });
                t1.Start();
                AnimationSidebar.Show(gunaMenuBar);
            }
            else
            {
                gunaMenuBar.Visible = false;
                btnPersonnels.Text = "Personnels";
                t1 = new Task(() =>
                {
                    int i = 65;
                    int t = 90;
                    int b = 45;
                    this.BeginInvoke(new Action(() =>
                    {

                    while (i != 200)
                        {
                            i = i + 9;
                            t = t + 9;
                            b = b - 13;
                            sidebarWrapper.Width = t;
                            gunaMenuBar.Width = i;
                            
                            pnlLine.Width = b;
                            System.Threading.Thread.Sleep(5);
                        }
                    }));
                });
                t1.Start();
                t1.ContinueWith((t) => {
                    this.BeginInvoke(new Action(() =>
                    {
                        pnlLine.Width = 180;

                    }));
                });
                AnimatiomSidebarBack.Show(gunaMenuBar);
            }
        }

       

       

        

        private void lightBtn_Click(object sender, EventArgs e)
        {
            if (!isLight)
            {
                isLight = true;
                loffBtn.Visible = true;
                lightBtn.Visible = false;
             
                extButton2.Visible = true;//kapalı modda kapalı olucak
                menuTop.BackColor = Color.FromArgb(224, 224, 224);
                sidebarWrapper.BackColor = Color.FromArgb(240, 240, 240);
                this.BackColor = Color.FromArgb(240, 240, 240);

                gunaMenuBar.FillColor = Color.FromArgb(66, 204, 255);
                gunaMenuBar.FillColor2 = Color.FromArgb(66, 204, 255);

                btnDashboard.ForeColor = Color.WhiteSmoke;
                btnPersonnels.ForeColor = Color.WhiteSmoke;
                btnProducts.ForeColor = Color.WhiteSmoke;
                btnCustomers.ForeColor = Color.WhiteSmoke;
                lblMenuName.ForeColor = Color.FromArgb(127, 131, 134);
                lblUserName.ForeColor = Color.FromArgb(127, 131, 134);
            }
            else
            {
                isLight = false;
                loffBtn.Visible = false;
                lightBtn.Visible = true;

                extButton2.Visible = false;//kapalı modda kapalı olucak
                menuTop.BackColor = Color.FromArgb(20, 20, 35);
                sidebarWrapper.BackColor = Color.FromArgb(30, 30, 48);
                this.BackColor = Color.FromArgb(30,30, 48);

                gunaMenuBar.FillColor = Color.FromArgb(30, 30, 48);
                gunaMenuBar.FillColor2 = Color.FromArgb(165, 21, 80);

                btnDashboard.ForeColor = Color.White;
                btnPersonnels.ForeColor = Color.White;
                btnProducts.ForeColor = Color.White;
                btnCustomers.ForeColor = Color.White;
                lblMenuName.ForeColor = Color.White;
                lblUserName.ForeColor = Color.White;
            }
        }
    }
}

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
    public partial class customerMenu : Form
    {
        private int formKoor, formKoorX, formKoorY;

        Timer t1 = new Timer();                   //
        Timer t2 = new Timer();                   // Yandan çıkan kutucuk için altta regionda yazılı
        static Guna.UI2.WinForms.Guna2Panel popup;//
        bool stopped = false;
        Guna.UI2.WinForms.Guna2PictureBox selectedBtn;//Alttaki butonlardaki seçili butonu tutar
        Customers customer;                         //Profil için customer
        UserControl selectedControl;                    //
       internal static UserControl[] userControls = new UserControl[3];// Alttaki butonlardan sonra çılan usercontrolleri tutar soldan sağa doğru 0 1 2

      
        public customerMenu()
        {
      
            InitializeComponent();
            selectedBtn = userBtn2;
            marketBtn2.Visible = false;
            homeBtn2.Visible = false;
            t1.Interval = 2;
            t1.Tick += new EventHandler(Tick);
            t2.Interval = 1000;
            t2.Tick += new EventHandler(Tick2);
        }
        public customerMenu(Customers customer) : this()
        {
            this.customer = customer;
            ucHome profil = new ucHome(customer);//
            ucProfil home = new ucProfil();
            ucBasket basket = new ucBasket();                                 //
                                                //
            
            profil.Location = new Point(76, 50);//
            profil.Visible = true;              // ilk seçili butonlar forumn altındaki 2 ile bitenler beyaz olur seçilmiş anlamına gelir 1 le bitenler normal
            home.Location = new Point(76, 50);  //
            home.Visible = false;               //
            this.Controls.Add(profil);          //
            this.Controls.Add(home);
            this.Controls.Add(basket);                                 //
            selectedControl = profil;           //        SEPET USER CONTROLÜNÜN POİNTİ VİSİBLİTİSİ AYARLANCAK ONDAN SONRA THİS.CONTROLS E VE
            userControls[0] = profil;           //       
            userControls[1] = home;
            userControls[2] = basket;     //        userControls[2] ye eklenicek
            home.Show();
        }
        
        private void marketBtn_Click(object sender, EventArgs e)//Sepet butonuna basılırsa sağdaki       SEPET AÇILDIĞINDA selectedControl.Visib
        {
            selectedControl.Visible = false;
            selectedControl = userControls[2];
            selectedControl.Visible = true;        
            selectedBtn.Visible = false;
            selectedBtn = marketBtn2;
            marketBtn2.Visible = true;
        }

        private void userBtn_Click(object sender, EventArgs e)//profil butonuna basılırsa soldaki
        {
            selectedControl.Visible = false;
            selectedControl = userControls[0];
            selectedControl.Visible = true;
            selectedBtn.Visible = false;
            selectedBtn = userBtn2;
            userBtn2.Visible = true;
        }

        private void homeBtn_Click(object sender, EventArgs e)//market butonuna basılırsa ortadaki buton
        {
            selectedControl.Visible = false;
            selectedControl = userControls[1];
            selectedControl.Visible = true;
            selectedBtn.Visible = false;
            selectedBtn = homeBtn2;
            homeBtn2.Visible = true;
        }

        private void ucHome1_Load(object sender, EventArgs e)
        {

        }

        private void customerMenu_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }     
        

        //Yandan çıkıcak kutucuk--------------------------------
        #region  ınfokutucugu
        internal static void InfoPopup(string Name,bool b)
        {          
            customerMenu cm = Application.OpenForms["customerMenu"] as customerMenu;
            if (popup != null)
            {
                cm.Controls.Remove(popup);
                popup.Dispose();
                popup = null;
                cm.AnimationPopup2();


            }
            Label labelInfo = new Label();
            Guna.UI2.WinForms.Guna2Panel panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            panelInfo.FillColor = System.Drawing.Color.DodgerBlue;
            panelInfo.Location = new System.Drawing.Point(1255, 637);
            panelInfo.Name = "panelInfo";
            panelInfo.ShadowDecoration.Parent = panelInfo;
            panelInfo.Size = new System.Drawing.Size(147, 75);
            panelInfo.BorderRadius = 10;
            panelInfo.TabIndex = 6;
            //Label Info
            labelInfo.AutoSize = true;
            labelInfo.BackColor = System.Drawing.Color.Transparent;
            labelInfo.ForeColor = Color.WhiteSmoke;
            labelInfo.Location = new System.Drawing.Point(10, 7);
            labelInfo.Name = "labelInfo";
            labelInfo.Parent = panelInfo;
            labelInfo.Size = new System.Drawing.Size(35, 13);
            labelInfo.TabIndex = 0;
            labelInfo.Font = new Font("Microsoft Sans Serif",9F);
            if (b)
            {
                labelInfo.Text = $"{Name} \nsepete eklendi";
            }
            else
            {
                labelInfo.Text = $"{Name} \nsepetten çıkarıldı";

            }
            popup = panelInfo;
            cm.Controls.Add(popup);
            cm.AnimationPopup(popup);
        }
        private void AnimationPopup(Guna.UI2.WinForms.Guna2Panel panelInfo)
        {            
            t1.Start();
        }
        private void AnimationPopup2()
        {
            t2.Stop();
            t2.Start();
        }
        private void Tick(object sender,EventArgs e)
        {
            
            popup.Location = new Point(popup.Location.X - 25, popup.Location.Y);
            if(popup.Location.X == 1005)
            {
                t1.Stop();
                t2.Start();
                
            }
        }
        private void Tick2(object sender,EventArgs e)
        {
            t2.Stop();
            popup.Dispose();
        }


        #endregion

        private void marketBtn2_Click(object sender, EventArgs e)
        {

        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            formKoor = 1;
            formKoorX = e.X;
            formKoorY = e.Y;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (formKoor==1)
            {
                this.SetDesktopLocation(MousePosition.X - formKoorX, MousePosition.Y - formKoorY);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            formKoor = 0;
        }
    }


}

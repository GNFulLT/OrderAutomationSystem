using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtgaranti.Text != "")
            {
                using (var db = new VeriEntities())
                {
                    Urun u = new Urun();
                    u.UrunAd = txtad.Text;
                    u.GarantiSuresi = txtgaranti.Text;
                    u.Fiyatı = txtfiyat.Text;
                    db.Urun.Add(u);
                    db.SaveChanges();
                    MessageBox.Show("Ürün Eklendi");
                    dataGridView1.DataSource = db.Urun.ToList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen ürün bilgileri giriniz!");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace OrderAutomationSystem
{
    public partial class ucProfil : UserControl
    {
        //Home kısmı
        DataSet ds;
        List<ucItem> items = new List<ucItem>();
        bool isShowed = false;
        public ucProfil()
        {
            InitializeComponent();
            ds = new DataSet();
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                SQLiteCommand cmd = sql.CreateCommand();
                cmd.CommandText = "SELECT * FROM Items";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                sql.Close();
            }
        }
        //Item değeri atancak
        


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            int startX = 15;
            int startY = 15;
            if (txtSearch.Text == string.Empty)
            {
                if (isShowed)
                    return;
                DataTable dt = ds.Tables[0];
                int count = ds.Tables[0].Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    object[] list = dt.Rows[i].ItemArray;
                    Item item = new Item(Convert.ToInt32(list[0]), list[1].ToString(), Convert.ToInt32(list[2]), Convert.ToInt32(list[3]), list[4].ToString(), Convert.ToInt32(list[5]), list[6].ToString());
                    ucItem ucitem = new ucItem(item);
                    if (startX <= 615)
                    {
                        ucitem.Location = new Point(startX, startY);
                        startX = startX + 300;
                    }
                    else
                    {
                        startX = 15;
                        startY = startY + 231;
                        ucitem.Location = new Point(startX, startY);
                    }
                    itemPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
                    itemPanel.Controls.Add(ucitem);
                    items.Add(ucitem);
                }
            }
            isShowed = true;
            
        }

        private void ucProfil_Load(object sender, EventArgs e)
        {

        }
    }
}

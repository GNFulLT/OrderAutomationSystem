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
    public partial class ucProducts : UserControl
    {

        int? id = null;
        public bool save = false;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();
        public ucProducts()
        {
            InitializeComponent();
            
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Items";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                sql.Close();
            }
            dgvProducts.DataSource = ds.Tables[0];
        }
        public ucProducts(int? Id = null) : this()
        {

            List();
            if (Id != null)
                this.id = Id;
        }

        void List()
        {
            string sql = "Select * from Items";
            dgvProducts.DataSource = Crud.List(sql);
        }
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = string.Empty;
        }

        private void txtWeight_Click(object sender, EventArgs e)
        {
            txtWeight.Text = string.Empty;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"INSERT INTO Items (Name, Quantity, Weight,Price,Description) VALUES ('" + txtName.Text + "','" + txtQuantity.Text + "','" + txtWeight.Text + "','" + txtPrice.Text + "','" + txtDescription.Text + "')";

                cmd.ExecuteNonQuery();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Items";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                dgvProducts.DataSource = null;
                sql.Close();
            }
            //dgvProducts.DataSource = ds.Tables[0];
        }
    }
}

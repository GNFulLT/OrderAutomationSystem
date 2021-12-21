
namespace OrderAutomationSystem
{
    partial class ucBasket
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBasket = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblCost2 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtQuantitity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.listBasket = new System.Windows.Forms.ListBox();
            this.lblBasket = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelBasket.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBasket
            // 
            this.panelBasket.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBasket.Controls.Add(this.groupBoxInfo);
            this.panelBasket.Controls.Add(this.listBasket);
            this.panelBasket.Location = new System.Drawing.Point(143, 165);
            this.panelBasket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.ShadowDecoration.Parent = this.panelBasket;
            this.panelBasket.Size = new System.Drawing.Size(1259, 694);
            this.panelBasket.TabIndex = 0;
            this.panelBasket.EnabledChanged += new System.EventHandler(this.enabledColor);
            this.panelBasket.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBasket_Paint);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.AutoSize = true;
            this.groupBoxInfo.Controls.Add(this.lblCost2);
            this.groupBoxInfo.Controls.Add(this.lblCost);
            this.groupBoxInfo.Controls.Add(this.txtQuantitity);
            this.groupBoxInfo.Controls.Add(this.txtDescription);
            this.groupBoxInfo.Controls.Add(this.txtPrice);
            this.groupBoxInfo.Controls.Add(this.txtName);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.lblQuantity);
            this.groupBoxInfo.Controls.Add(this.lblPrice);
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(305, 25);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfo.Size = new System.Drawing.Size(666, 610);
            this.groupBoxInfo.TabIndex = 9;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Selected Item Information:";
            this.groupBoxInfo.Enter += new System.EventHandler(this.groupBoxInfo_Enter);
            // 
            // lblCost2
            // 
            this.lblCost2.AutoSize = true;
            this.lblCost2.Location = new System.Drawing.Point(212, 520);
            this.lblCost2.Name = "lblCost2";
            this.lblCost2.Size = new System.Drawing.Size(32, 36);
            this.lblCost2.TabIndex = 11;
            this.lblCost2.Text = "0";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(22, 520);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(158, 36);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Total Cost:";
            // 
            // txtQuantitity
            // 
            this.txtQuantitity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantitity.BorderRadius = 12;
            this.txtQuantitity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtQuantitity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQuantitity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantitity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantitity.FocusedState.Parent = this.txtQuantitity;
            this.txtQuantitity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantitity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtQuantitity.HoverState.Parent = this.txtQuantitity;
            this.txtQuantitity.ItemHeight = 30;
            this.txtQuantitity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.txtQuantitity.ItemsAppearance.Parent = this.txtQuantitity;
            this.txtQuantitity.Location = new System.Drawing.Point(180, 118);
            this.txtQuantitity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantitity.Name = "txtQuantitity";
            this.txtQuantitity.ShadowDecoration.Parent = this.txtQuantitity;
            this.txtQuantitity.Size = new System.Drawing.Size(101, 36);
            this.txtQuantitity.StartIndex = 0;
            this.txtQuantitity.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 15;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(176, 245);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(348, 221);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.EnabledChanged += new System.EventHandler(this.enabledColor);
            this.txtDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.enabledColor_Paint);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(176, 184);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(194, 26);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.EnabledChanged += new System.EventHandler(this.enabledColor);
            this.txtPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.enabledColor_Paint);
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(176, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(194, 26);
            this.txtName.TabIndex = 5;
            this.txtName.EnabledChanged += new System.EventHandler(this.enabledColor);
            this.txtName.Paint += new System.Windows.Forms.PaintEventHandler(this.enabledColor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(46, 118);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 29);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(76, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 29);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(68, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // listBasket
            // 
            this.listBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBasket.FormattingEnabled = true;
            this.listBasket.ItemHeight = 29;
            this.listBasket.Location = new System.Drawing.Point(20, 25);
            this.listBasket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBasket.Name = "listBasket";
            this.listBasket.Size = new System.Drawing.Size(250, 584);
            this.listBasket.TabIndex = 0;
            this.listBasket.SelectedIndexChanged += new System.EventHandler(this.listBasket_SelectedIndexChanged);
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.BackColor = System.Drawing.Color.Transparent;
            this.lblBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasket.ForeColor = System.Drawing.Color.White;
            this.lblBasket.Location = new System.Drawing.Point(137, 117);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(242, 36);
            this.lblBasket.TabIndex = 1;
            this.lblBasket.Text = "Shopping Basket";
            // 
            // ucBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.panelBasket);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucBasket";
            this.Size = new System.Drawing.Size(1552, 940);
            this.Load += new System.EventHandler(this.ucBasket_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucBasket_MouseMove);
            this.panelBasket.ResumeLayout(false);
            this.panelBasket.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBasket;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.ListBox listBasket;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCost2;
        private System.Windows.Forms.Label lblCost;
        private Guna.UI2.WinForms.Guna2ComboBox txtQuantitity;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
    }
}

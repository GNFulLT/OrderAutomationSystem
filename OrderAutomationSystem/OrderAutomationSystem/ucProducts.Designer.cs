
namespace OrderAutomationSystem
{
    partial class ucProducts
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRemove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(27, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 15;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "Enter Name";
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
            this.txtName.Location = new System.Drawing.Point(150, 29);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.SelectionStart = 10;
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(277, 36);
            this.txtName.TabIndex = 2;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(27, 92);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(91, 25);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BorderRadius = 15;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "Enter Quantity";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(150, 81);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 14;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(277, 36);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Click += new System.EventHandler(this.txtQuantity_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(27, 145);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 25);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Transparent;
            this.txtWeight.BorderRadius = 15;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "Enter Weight";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.Parent = this.txtWeight;
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.FocusedState.Parent = this.txtWeight;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.HoverState.Parent = this.txtWeight;
            this.txtWeight.Location = new System.Drawing.Point(150, 134);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.SelectedText = "";
            this.txtWeight.SelectionStart = 12;
            this.txtWeight.ShadowDecoration.Parent = this.txtWeight;
            this.txtWeight.Size = new System.Drawing.Size(277, 36);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.Click += new System.EventHandler(this.txtWeight_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(27, 196);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderRadius = 15;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "Enter Description";
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
            this.txtDescription.Location = new System.Drawing.Point(150, 185);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionStart = 17;
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(277, 36);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 21;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(150, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(125, 45);
            this.btnAdd.TabIndex = 255;
            this.btnAdd.Text = "Add";
            // 
            // btnRemove
            // 
            this.btnRemove.Animated = true;
            this.btnRemove.AutoRoundedCorners = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderRadius = 21;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.DisabledState.Parent = this.btnRemove;
            this.btnRemove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(302, 247);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(125, 45);
            this.btnRemove.TabIndex = 256;
            this.btnRemove.Text = "Remove";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 21;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(150, 298);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(277, 45);
            this.btnUpdate.TabIndex = 257;
            this.btnUpdate.Text = "Update";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(32, 373);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(675, 413);
            this.dgvProducts.TabIndex = 258;
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(1100, 820);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label lblWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemove;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}

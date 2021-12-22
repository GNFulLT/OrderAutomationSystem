
namespace OrderAutomationSystem
{
    partial class PaymentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlCash = new Guna.UI2.WinForms.Guna2Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlCheck = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCredit = new Guna.UI2.WinForms.Guna2Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.pctCash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pctCheck = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pctCredit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.pnlCash.SuspendLayout();
            this.pnlCheck.SuspendLayout();
            this.pnlCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnlCash
            // 
            this.pnlCash.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCash.Controls.Add(this.lblCash);
            this.pnlCash.Controls.Add(this.pctCash);
            this.pnlCash.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlCash.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pnlCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCash.Location = new System.Drawing.Point(250, 0);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.ShadowDecoration.Parent = this.pnlCash;
            this.pnlCash.Size = new System.Drawing.Size(250, 576);
            this.pnlCash.TabIndex = 7;
            this.pnlCash.Click += new System.EventHandler(this.pnlCash_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.Location = new System.Drawing.Point(220, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 25);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pnlCheck
            // 
            this.pnlCheck.Controls.Add(this.lblCheck);
            this.pnlCheck.Controls.Add(this.lblExit);
            this.pnlCheck.Controls.Add(this.pctCheck);
            this.pnlCheck.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCheck.Location = new System.Drawing.Point(500, 0);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.ShadowDecoration.Parent = this.pnlCheck;
            this.pnlCheck.Size = new System.Drawing.Size(250, 576);
            this.pnlCheck.TabIndex = 6;
            this.pnlCheck.Click += new System.EventHandler(this.pnlCheck_Click);
            // 
            // pnlCredit
            // 
            this.pnlCredit.Controls.Add(this.lblCredit);
            this.pnlCredit.Controls.Add(this.pctCredit);
            this.pnlCredit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCredit.Location = new System.Drawing.Point(0, 0);
            this.pnlCredit.Name = "pnlCredit";
            this.pnlCredit.ShadowDecoration.Parent = this.pnlCredit;
            this.pnlCredit.Size = new System.Drawing.Size(250, 576);
            this.pnlCredit.TabIndex = 5;
            this.pnlCredit.Click += new System.EventHandler(this.pnlCredit_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCredit.Location = new System.Drawing.Point(64, 305);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(94, 36);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "Credit";
            this.lblCredit.Click += new System.EventHandler(this.pnlCredit_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCash.Location = new System.Drawing.Point(80, 305);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(84, 36);
            this.lblCash.TabIndex = 1;
            this.lblCash.Text = "Cash";
            this.lblCash.Click += new System.EventHandler(this.pnlCash_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCheck.Location = new System.Drawing.Point(89, 305);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(99, 36);
            this.lblCheck.TabIndex = 1;
            this.lblCheck.Text = "Check";
            this.lblCheck.Click += new System.EventHandler(this.pnlCheck_Click);
            // 
            // pctCash
            // 
            this.pctCash.BackColor = System.Drawing.Color.Transparent;
            this.pctCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctCash.BackgroundImage")));
            this.pctCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctCash.FillColor = System.Drawing.Color.Transparent;
            this.pctCash.ImageRotate = 0F;
            this.pctCash.Location = new System.Drawing.Point(72, 176);
            this.pctCash.Name = "pctCash";
            this.pctCash.ShadowDecoration.Parent = this.pctCash;
            this.pctCash.Size = new System.Drawing.Size(105, 105);
            this.pctCash.TabIndex = 3;
            this.pctCash.TabStop = false;
            this.pctCash.Click += new System.EventHandler(this.pnlCash_Click);
            // 
            // pctCheck
            // 
            this.pctCheck.BackColor = System.Drawing.Color.Transparent;
            this.pctCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctCheck.BackgroundImage")));
            this.pctCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctCheck.FillColor = System.Drawing.Color.Transparent;
            this.pctCheck.ImageRotate = 0F;
            this.pctCheck.Location = new System.Drawing.Point(85, 176);
            this.pctCheck.Name = "pctCheck";
            this.pctCheck.ShadowDecoration.Parent = this.pctCheck;
            this.pctCheck.Size = new System.Drawing.Size(103, 101);
            this.pctCheck.TabIndex = 4;
            this.pctCheck.TabStop = false;
            this.pctCheck.Click += new System.EventHandler(this.pnlCheck_Click);
            // 
            // pctCredit
            // 
            this.pctCredit.BackColor = System.Drawing.Color.Transparent;
            this.pctCredit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctCredit.BackgroundImage")));
            this.pctCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctCredit.FillColor = System.Drawing.Color.Transparent;
            this.pctCredit.ImageRotate = 0F;
            this.pctCredit.Location = new System.Drawing.Point(55, 176);
            this.pctCredit.Name = "pctCredit";
            this.pctCredit.ShadowDecoration.Parent = this.pctCredit;
            this.pctCredit.Size = new System.Drawing.Size(103, 101);
            this.pctCredit.TabIndex = 0;
            this.pctCredit.TabStop = false;
            this.pctCredit.Click += new System.EventHandler(this.pnlCredit_Click);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(750, 576);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.pnlCheck);
            this.Controls.Add(this.pnlCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlCheck.ResumeLayout(false);
            this.pnlCheck.PerformLayout();
            this.pnlCredit.ResumeLayout(false);
            this.pnlCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Panel pnlCash;
        private Guna.UI2.WinForms.Guna2PictureBox pctCash;
        private Guna.UI2.WinForms.Guna2PictureBox pctCheck;
        private System.Windows.Forms.Label lblExit;
        private Guna.UI2.WinForms.Guna2Panel pnlCheck;
        private Guna.UI2.WinForms.Guna2PictureBox pctCredit;
        private Guna.UI2.WinForms.Guna2Panel pnlCredit;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}
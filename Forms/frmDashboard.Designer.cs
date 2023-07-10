
namespace RAloverasPharmacyPOSSystem.Forms
{
    partial class frmDashboard
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1024, 61);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "R-ALOVERA\'S PHARMACY";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel2.Controls.Add(this.btnHistory);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.btnReports);
            this.guna2Panel2.Controls.Add(this.btnLogout);
            this.guna2Panel2.Controls.Add(this.btnProducts);
            this.guna2Panel2.Controls.Add(this.btnProfile);
            this.guna2Panel2.Controls.Add(this.btnUsers);
            this.guna2Panel2.Controls.Add(this.btnOrder);
            this.guna2Panel2.Controls.Add(this.btnPayment);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 61);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(137, 539);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.OliveDrab;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(0, 183);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(137, 36);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "HISTORY (F10)";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Animated = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.OliveDrab;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "EXIT (ESC)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.OliveDrab;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 147);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(137, 36);
            this.btnReports.TabIndex = 11;
            this.btnReports.TabStop = false;
            this.btnReports.Text = "REPORTS (F9)";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Animated = true;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.OliveDrab;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 465);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "LOGOUT (F12)";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Animated = true;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducts.FillColor = System.Drawing.Color.OliveDrab;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(0, 75);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(137, 36);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.TabStop = false;
            this.btnProducts.Text = "PRODUCTS (F7)";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProfile.Animated = true;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.OliveDrab;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 429);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(137, 36);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.TabStop = false;
            this.btnProfile.Text = "PROFILE (F11)";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.OliveDrab;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 111);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(137, 36);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.TabStop = false;
            this.btnUsers.Text = "USERS (F8)";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.OliveDrab;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(0, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(137, 36);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "ORDER (F5)";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Animated = true;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.OliveDrab;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(0, 39);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(137, 36);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.TabStop = false;
            this.btnPayment.Text = "PAYMENT (F6)";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(137, 61);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(887, 539);
            this.pnlMain.TabIndex = 3;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
    }
}
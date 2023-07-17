
namespace RAloverasPharmacyPOSSystem.Forms
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAmountToPay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscounted = new Guna.UI2.WinForms.Guna2TextBox();
            this.gridForPaymentTransaction = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCart = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridForPaymentTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "FOR PAYMENT TRANSACTION";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL AMOUNT TO PAY";
            // 
            // txtTotalAmountToPay
            // 
            this.txtTotalAmountToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalAmountToPay.Animated = true;
            this.txtTotalAmountToPay.BorderRadius = 3;
            this.txtTotalAmountToPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmountToPay.DefaultText = "";
            this.txtTotalAmountToPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmountToPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmountToPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmountToPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmountToPay.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtTotalAmountToPay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTotalAmountToPay.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmountToPay.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtTotalAmountToPay.Location = new System.Drawing.Point(16, 283);
            this.txtTotalAmountToPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmountToPay.Name = "txtTotalAmountToPay";
            this.txtTotalAmountToPay.PasswordChar = '\0';
            this.txtTotalAmountToPay.PlaceholderText = "";
            this.txtTotalAmountToPay.SelectedText = "";
            this.txtTotalAmountToPay.Size = new System.Drawing.Size(320, 36);
            this.txtTotalAmountToPay.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "DISCOUNT (PERCENTAGE)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiscount.Animated = true;
            this.txtDiscount.BorderRadius = 3;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscount.Location = new System.Drawing.Point(17, 353);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(320, 36);
            this.txtDiscount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "AMOUNT";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmount.Animated = true;
            this.txtAmount.BorderRadius = 3;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtAmount.Location = new System.Drawing.Point(16, 423);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(320, 36);
            this.txtAmount.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "CHANGE";
            // 
            // txtChange
            // 
            this.txtChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtChange.Animated = true;
            this.txtChange.BorderRadius = 3;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.DefaultText = "";
            this.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChange.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtChange.ForeColor = System.Drawing.Color.Black;
            this.txtChange.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtChange.Location = new System.Drawing.Point(16, 493);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.PlaceholderText = "";
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(320, 36);
            this.txtChange.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Animated = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.OliveDrab;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(649, 493);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 36);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "PRINT (F2)";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.OliveDrab;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(765, 493);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(110, 36);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.TabStop = false;
            this.guna2Button1.Text = "SAVE (F1)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "DISCOUNTED";
            // 
            // txtDiscounted
            // 
            this.txtDiscounted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiscounted.Animated = true;
            this.txtDiscounted.BorderRadius = 3;
            this.txtDiscounted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscounted.DefaultText = "";
            this.txtDiscounted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscounted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscounted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscounted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscounted.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscounted.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiscounted.ForeColor = System.Drawing.Color.Black;
            this.txtDiscounted.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscounted.Location = new System.Drawing.Point(343, 353);
            this.txtDiscounted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscounted.Name = "txtDiscounted";
            this.txtDiscounted.PasswordChar = '\0';
            this.txtDiscounted.PlaceholderText = "";
            this.txtDiscounted.SelectedText = "";
            this.txtDiscounted.Size = new System.Drawing.Size(320, 36);
            this.txtDiscounted.TabIndex = 2;
            // 
            // gridForPaymentTransaction
            // 
            this.gridForPaymentTransaction.AllowUserToAddRows = false;
            this.gridForPaymentTransaction.AllowUserToDeleteRows = false;
            this.gridForPaymentTransaction.AllowUserToResizeColumns = false;
            this.gridForPaymentTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridForPaymentTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridForPaymentTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridForPaymentTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridForPaymentTransaction.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForPaymentTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridForPaymentTransaction.ColumnHeadersHeight = 36;
            this.gridForPaymentTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridForPaymentTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn10});
            this.gridForPaymentTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridForPaymentTransaction.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridForPaymentTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridForPaymentTransaction.Location = new System.Drawing.Point(12, 34);
            this.gridForPaymentTransaction.MultiSelect = false;
            this.gridForPaymentTransaction.Name = "gridForPaymentTransaction";
            this.gridForPaymentTransaction.ReadOnly = true;
            this.gridForPaymentTransaction.RowHeadersVisible = false;
            this.gridForPaymentTransaction.RowTemplate.Height = 36;
            this.gridForPaymentTransaction.Size = new System.Drawing.Size(394, 216);
            this.gridForPaymentTransaction.TabIndex = 19;
            this.gridForPaymentTransaction.TabStop = false;
            this.gridForPaymentTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridForPaymentTransaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridForPaymentTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridForPaymentTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridForPaymentTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridForPaymentTransaction.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridForPaymentTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridForPaymentTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OliveDrab;
            this.gridForPaymentTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridForPaymentTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridForPaymentTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridForPaymentTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridForPaymentTransaction.ThemeStyle.HeaderStyle.Height = 36;
            this.gridForPaymentTransaction.ThemeStyle.ReadOnly = true;
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.Height = 36;
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridForPaymentTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 17;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "STAFF NAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "ACTION";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "CART";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "ACTION";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 77;
            // 
            // clmSubTotal
            // 
            this.clmSubTotal.HeaderText = "SUB TOTAL";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            this.clmSubTotal.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 64;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 17;
            // 
            // gridCart
            // 
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.AllowUserToDeleteRows = false;
            this.gridCart.AllowUserToResizeColumns = false;
            this.gridCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCart.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridCart.ColumnHeadersHeight = 36;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.clmSubTotal,
            this.dataGridViewTextBoxColumn11});
            this.gridCart.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCart.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridCart.Location = new System.Drawing.Point(412, 34);
            this.gridCart.MultiSelect = false;
            this.gridCart.Name = "gridCart";
            this.gridCart.ReadOnly = true;
            this.gridCart.RowHeadersVisible = false;
            this.gridCart.RowTemplate.Height = 36;
            this.gridCart.Size = new System.Drawing.Size(463, 216);
            this.gridCart.TabIndex = 5;
            this.gridCart.TabStop = false;
            this.gridCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridCart.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OliveDrab;
            this.gridCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridCart.ThemeStyle.HeaderStyle.Height = 36;
            this.gridCart.ThemeStyle.ReadOnly = true;
            this.gridCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridCart.ThemeStyle.RowsStyle.Height = 36;
            this.gridCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridForPaymentTransaction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiscounted);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAmountToPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(887, 539);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYMENT";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridForPaymentTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmountToPay;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtChange;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscounted;
        private Guna.UI2.WinForms.Guna2DataGridView gridForPaymentTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2DataGridView gridCart;
    }
}
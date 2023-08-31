
namespace RAloverasPharmacyPOSSystem.Forms
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPackagingUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGeneric = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDiscounted = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceFromSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(520, 87);
            this.guna2Panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "ADD NEW PRODUCT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "R-ALOVERA\'S PHARMACY";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Animated = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.OliveDrab;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(398, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "SAVE (F1)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.OliveDrab;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(282, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 32);
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "CLOSE (F2)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "DESCRIPTION";
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderRadius = 3;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDescription.Location = new System.Drawing.Point(15, 175);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.MaxLength = 55;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(240, 32);
            this.txtDescription.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "CODE";
            // 
            // txtCode
            // 
            this.txtCode.Animated = true;
            this.txtCode.BorderRadius = 3;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.Enabled = false;
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtCode.Location = new System.Drawing.Point(15, 114);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.MaxLength = 55;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(240, 32);
            this.txtCode.TabIndex = 0;
            this.txtCode.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 276);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "QUANTITY";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.BorderRadius = 3;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtQuantity.Location = new System.Drawing.Point(16, 295);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.MaxLength = 55;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(240, 32);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 216);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "PACKAGING UNIT";
            // 
            // txtPackagingUnit
            // 
            this.txtPackagingUnit.Animated = true;
            this.txtPackagingUnit.BorderRadius = 3;
            this.txtPackagingUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPackagingUnit.DefaultText = "";
            this.txtPackagingUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPackagingUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPackagingUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPackagingUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPackagingUnit.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtPackagingUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPackagingUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPackagingUnit.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtPackagingUnit.Location = new System.Drawing.Point(16, 235);
            this.txtPackagingUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackagingUnit.MaxLength = 55;
            this.txtPackagingUnit.Name = "txtPackagingUnit";
            this.txtPackagingUnit.PasswordChar = '\0';
            this.txtPackagingUnit.PlaceholderText = "";
            this.txtPackagingUnit.SelectedText = "";
            this.txtPackagingUnit.Size = new System.Drawing.Size(240, 32);
            this.txtPackagingUnit.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(258, 95);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "DISCOUNT";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Animated = true;
            this.txtDiscount.BorderRadius = 3;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "0.00";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscount.Location = new System.Drawing.Point(261, 114);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.MaxLength = 55;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(240, 32);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 336);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "PRICE";
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.BorderRadius = 3;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtPrice.Location = new System.Drawing.Point(16, 355);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.MaxLength = 55;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(240, 32);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(258, 216);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "GENERIC";
            // 
            // txtGeneric
            // 
            this.txtGeneric.Animated = true;
            this.txtGeneric.BorderRadius = 3;
            this.txtGeneric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGeneric.DefaultText = "";
            this.txtGeneric.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGeneric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGeneric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGeneric.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGeneric.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtGeneric.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGeneric.ForeColor = System.Drawing.Color.Black;
            this.txtGeneric.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtGeneric.Location = new System.Drawing.Point(261, 235);
            this.txtGeneric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeneric.MaxLength = 55;
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.PasswordChar = '\0';
            this.txtGeneric.PlaceholderText = "";
            this.txtGeneric.SelectedText = "";
            this.txtGeneric.Size = new System.Drawing.Size(240, 32);
            this.txtGeneric.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(258, 156);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 15);
            this.label20.TabIndex = 41;
            this.label20.Text = "DISCOUNTED";
            // 
            // txtDiscounted
            // 
            this.txtDiscounted.Animated = true;
            this.txtDiscounted.BorderRadius = 3;
            this.txtDiscounted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscounted.DefaultText = "0.00";
            this.txtDiscounted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDiscounted.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDiscounted.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtDiscounted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscounted.Enabled = false;
            this.txtDiscounted.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscounted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscounted.ForeColor = System.Drawing.Color.Black;
            this.txtDiscounted.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtDiscounted.Location = new System.Drawing.Point(261, 175);
            this.txtDiscounted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscounted.MaxLength = 55;
            this.txtDiscounted.Name = "txtDiscounted";
            this.txtDiscounted.PasswordChar = '\0';
            this.txtDiscounted.PlaceholderText = "";
            this.txtDiscounted.SelectedText = "";
            this.txtDiscounted.Size = new System.Drawing.Size(240, 32);
            this.txtDiscounted.TabIndex = 6;
            this.txtDiscounted.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "SUPPLIER";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Animated = true;
            this.txtSupplier.BorderRadius = 3;
            this.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplier.DefaultText = "";
            this.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtSupplier.Location = new System.Drawing.Point(261, 295);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplier.MaxLength = 55;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PlaceholderText = "";
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(240, 32);
            this.txtSupplier.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "PRICE FROM SUPPLIER";
            // 
            // txtPriceFromSupplier
            // 
            this.txtPriceFromSupplier.Animated = true;
            this.txtPriceFromSupplier.BorderRadius = 3;
            this.txtPriceFromSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceFromSupplier.DefaultText = "0.00";
            this.txtPriceFromSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceFromSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceFromSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceFromSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceFromSupplier.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtPriceFromSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPriceFromSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtPriceFromSupplier.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtPriceFromSupplier.Location = new System.Drawing.Point(261, 355);
            this.txtPriceFromSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceFromSupplier.MaxLength = 55;
            this.txtPriceFromSupplier.Name = "txtPriceFromSupplier";
            this.txtPriceFromSupplier.PasswordChar = '\0';
            this.txtPriceFromSupplier.PlaceholderText = "";
            this.txtPriceFromSupplier.SelectedText = "";
            this.txtPriceFromSupplier.Size = new System.Drawing.Size(240, 32);
            this.txtPriceFromSupplier.TabIndex = 9;
            this.txtPriceFromSupplier.TextChanged += new System.EventHandler(this.txtPriceFromSupplier_TextChanged);
            this.txtPriceFromSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceFromSupplier_KeyPress);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPriceFromSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtDiscounted);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtGeneric);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPackagingUnit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(520, 442);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD PRODUCT";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddProduct_KeyDown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtPackagingUnit;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtGeneric;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscounted;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplier;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceFromSupplier;
    }
}
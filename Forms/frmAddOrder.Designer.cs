
namespace RAloverasPharmacyPOSSystem.Forms
{
    partial class frmAddOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAvailableProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gridCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToPay = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalAmountToPay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvailableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAvailableProducts
            // 
            this.gridAvailableProducts.AllowUserToAddRows = false;
            this.gridAvailableProducts.AllowUserToDeleteRows = false;
            this.gridAvailableProducts.AllowUserToResizeColumns = false;
            this.gridAvailableProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.gridAvailableProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridAvailableProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAvailableProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridAvailableProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAvailableProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridAvailableProducts.ColumnHeadersHeight = 36;
            this.gridAvailableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridAvailableProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAvailableProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridAvailableProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridAvailableProducts.Location = new System.Drawing.Point(15, 59);
            this.gridAvailableProducts.MultiSelect = false;
            this.gridAvailableProducts.Name = "gridAvailableProducts";
            this.gridAvailableProducts.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAvailableProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridAvailableProducts.RowHeadersVisible = false;
            this.gridAvailableProducts.RowTemplate.Height = 36;
            this.gridAvailableProducts.Size = new System.Drawing.Size(863, 196);
            this.gridAvailableProducts.TabIndex = 1;
            this.gridAvailableProducts.TabStop = false;
            this.gridAvailableProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridAvailableProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridAvailableProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridAvailableProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridAvailableProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridAvailableProducts.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridAvailableProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridAvailableProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OliveDrab;
            this.gridAvailableProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridAvailableProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAvailableProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridAvailableProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridAvailableProducts.ThemeStyle.HeaderStyle.Height = 36;
            this.gridAvailableProducts.ThemeStyle.ReadOnly = true;
            this.gridAvailableProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridAvailableProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridAvailableProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAvailableProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridAvailableProducts.ThemeStyle.RowsStyle.Height = 36;
            this.gridAvailableProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridAvailableProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridAvailableProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAvailableProducts_CellContentClick);
            // 
            // gridCart
            // 
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.AllowUserToDeleteRows = false;
            this.gridCart.AllowUserToResizeColumns = false;
            this.gridCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.gridCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gridCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCart.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridCart.ColumnHeadersHeight = 36;
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.clmSubTotal});
            this.gridCart.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCart.DefaultCellStyle = dataGridViewCellStyle15;
            this.gridCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridCart.Location = new System.Drawing.Point(12, 283);
            this.gridCart.MultiSelect = false;
            this.gridCart.Name = "gridCart";
            this.gridCart.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gridCart.RowHeadersVisible = false;
            this.gridCart.RowTemplate.Height = 36;
            this.gridCart.Size = new System.Drawing.Size(863, 175);
            this.gridCart.TabIndex = 2;
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
            this.gridCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCart_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "AVAILABLE PRODUCTS";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CART";
            // 
            // btnToPay
            // 
            this.btnToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToPay.Animated = true;
            this.btnToPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToPay.FillColor = System.Drawing.Color.OliveDrab;
            this.btnToPay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnToPay.ForeColor = System.Drawing.Color.White;
            this.btnToPay.Location = new System.Drawing.Point(765, 491);
            this.btnToPay.Name = "btnToPay";
            this.btnToPay.Size = new System.Drawing.Size(110, 36);
            this.btnToPay.TabIndex = 44;
            this.btnToPay.TabStop = false;
            this.btnToPay.Text = "TO PAY (F1)";
            this.btnToPay.Click += new System.EventHandler(this.btnToPay_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 466);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "TOTAL AMOUNT TO PAY";
            // 
            // txtTotalAmountToPay
            // 
            this.txtTotalAmountToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalAmountToPay.Animated = true;
            this.txtTotalAmountToPay.BorderRadius = 3;
            this.txtTotalAmountToPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmountToPay.DefaultText = "0.00";
            this.txtTotalAmountToPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtTotalAmountToPay.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtTotalAmountToPay.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmountToPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmountToPay.Enabled = false;
            this.txtTotalAmountToPay.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtTotalAmountToPay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTotalAmountToPay.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmountToPay.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtTotalAmountToPay.Location = new System.Drawing.Point(15, 491);
            this.txtTotalAmountToPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmountToPay.Name = "txtTotalAmountToPay";
            this.txtTotalAmountToPay.PasswordChar = '\0';
            this.txtTotalAmountToPay.PlaceholderText = "";
            this.txtTotalAmountToPay.SelectedText = "";
            this.txtTotalAmountToPay.Size = new System.Drawing.Size(320, 36);
            this.txtTotalAmountToPay.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, -9);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.txtSearch.Location = new System.Drawing.Point(567, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(320, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 64;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // clmSubTotal
            // 
            this.clmSubTotal.HeaderText = "SUB TOTAL";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            this.clmSubTotal.Width = 85;
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalAmountToPay);
            this.Controls.Add(this.btnToPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCart);
            this.Controls.Add(this.gridAvailableProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(887, 539);
            this.Name = "frmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD ORDER";
            this.Load += new System.EventHandler(this.frmAddOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvailableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridAvailableProducts;
        private Guna.UI2.WinForms.Guna2DataGridView gridCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnToPay;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmountToPay;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
    }
}
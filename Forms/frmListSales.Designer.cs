﻿
namespace RAloverasPharmacyPOSSystem.Forms
{
    partial class frmListSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListSales));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gridSales = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalAmountReturned = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalItemsReturned = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 90);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.lblTotalAmountReturned);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(648, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(212, 84);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.White;
            this.lblTotalTransactions.Location = new System.Drawing.Point(4, 41);
            this.lblTotalTransactions.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(28, 32);
            this.lblTotalTransactions.TabIndex = 27;
            this.lblTotalTransactions.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "TOTAL AMOUNT RETURNED";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel1.Controls.Add(this.lblTotalSales);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(209, 84);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(3, 41);
            this.lblTotalSales.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(28, 32);
            this.lblTotalSales.TabIndex = 28;
            this.lblTotalSales.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "TOTAL SALES";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(605, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "TO";
            // 
            // dateTo
            // 
            this.dateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTo.Animated = true;
            this.dateTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dateTo.Checked = true;
            this.dateTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTo.FillColor = System.Drawing.Color.OliveDrab;
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTo.ForeColor = System.Drawing.Color.White;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.dateTo.Location = new System.Drawing.Point(635, 33);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(240, 32);
            this.dateTo.TabIndex = 1;
            this.dateTo.Value = new System.DateTime(2023, 7, 24, 21, 12, 5, 425);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(309, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "FROM";
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFrom.Animated = true;
            this.dateFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dateFrom.Checked = true;
            this.dateFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateFrom.FillColor = System.Drawing.Color.OliveDrab;
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFrom.ForeColor = System.Drawing.Color.White;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.HoverState.BorderColor = System.Drawing.Color.OliveDrab;
            this.dateFrom.Location = new System.Drawing.Point(359, 33);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(240, 32);
            this.dateFrom.TabIndex = 0;
            this.dateFrom.Value = new System.DateTime(2023, 7, 24, 21, 12, 5, 425);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            this.gridSales.AllowUserToResizeColumns = false;
            this.gridSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSales.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.ColumnHeadersHeight = 32;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridSales.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSales.Location = new System.Drawing.Point(12, 167);
            this.gridSales.MultiSelect = false;
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.RowTemplate.Height = 32;
            this.gridSales.Size = new System.Drawing.Size(863, 322);
            this.gridSales.TabIndex = 44;
            this.gridSales.TabStop = false;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridSales.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OliveDrab;
            this.gridSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridSales.ThemeStyle.HeaderStyle.Height = 32;
            this.gridSales.ThemeStyle.ReadOnly = true;
            this.gridSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.gridSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridSales.ThemeStyle.RowsStyle.Height = 32;
            this.gridSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellContentClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Animated = true;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.OliveDrab;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(779, 495);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 32);
            this.btnPrevious.TabIndex = 51;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Animated = true;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.OliveDrab;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(830, 495);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 32);
            this.btnNext.TabIndex = 50;
            this.btnNext.TabStop = false;
            this.btnNext.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 52;
            this.label5.Text = "LIST OF SALES";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel3.Controls.Add(this.lblTotalTransactions);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(218, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(209, 84);
            this.guna2Panel3.TabIndex = 2;
            // 
            // lblTotalAmountReturned
            // 
            this.lblTotalAmountReturned.AutoSize = true;
            this.lblTotalAmountReturned.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountReturned.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountReturned.Location = new System.Drawing.Point(3, 41);
            this.lblTotalAmountReturned.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalAmountReturned.Name = "lblTotalAmountReturned";
            this.lblTotalAmountReturned.Size = new System.Drawing.Size(28, 32);
            this.lblTotalAmountReturned.TabIndex = 27;
            this.lblTotalAmountReturned.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "TOTAL TRANSACTIONS";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Controls.Add(this.lblTotalItemsReturned);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(433, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(209, 84);
            this.guna2Panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "TOTAL ITEM RETURNED";
            // 
            // lblTotalItemsReturned
            // 
            this.lblTotalItemsReturned.AutoSize = true;
            this.lblTotalItemsReturned.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsReturned.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsReturned.Location = new System.Drawing.Point(3, 41);
            this.lblTotalItemsReturned.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalItemsReturned.Name = "lblTotalItemsReturned";
            this.lblTotalItemsReturned.Size = new System.Drawing.Size(28, 32);
            this.lblTotalItemsReturned.TabIndex = 27;
            this.lblTotalItemsReturned.Text = "0";
            // 
            // frmListSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.gridSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(887, 539);
            this.Name = "frmListSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIST OF SALES";
            this.Load += new System.EventHandler(this.frmListSales_Load);
            this.VisibleChanged += new System.EventHandler(this.frmListSales_VisibleChanged);
            this.Leave += new System.EventHandler(this.frmListSales_Leave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private Guna.UI2.WinForms.Guna2DataGridView gridSales;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalAmountReturned;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalItemsReturned;
    }
}
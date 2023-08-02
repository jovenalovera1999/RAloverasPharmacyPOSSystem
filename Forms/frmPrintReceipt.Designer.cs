
namespace RAloverasPharmacyPOSSystem.Forms
{
    partial class frmPrintReceipt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rprtReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CartBindingSource
            // 
            this.CartBindingSource.DataSource = typeof(RAloverasPharmacyPOSSystem.Forms.frmPayment.Cart);
            // 
            // rprtReceipt
            // 
            this.rprtReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsCart";
            reportDataSource1.Value = this.CartBindingSource;
            this.rprtReceipt.LocalReport.DataSources.Add(reportDataSource1);
            this.rprtReceipt.LocalReport.ReportEmbeddedResource = "RAloverasPharmacyPOSSystem.Reports.rprtReceipt.rdlc";
            this.rprtReceipt.Location = new System.Drawing.Point(12, 12);
            this.rprtReceipt.Name = "rprtReceipt";
            this.rprtReceipt.Size = new System.Drawing.Size(374, 501);
            this.rprtReceipt.TabIndex = 0;
            this.rprtReceipt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
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
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(276, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "CLOSE (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 567);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rprtReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(398, 567);
            this.Name = "frmPrintReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINT RECEIPT";
            this.Load += new System.EventHandler(this.frmPrintReceipt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrintReceipt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtReceipt;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.BindingSource CartBindingSource;
    }
}
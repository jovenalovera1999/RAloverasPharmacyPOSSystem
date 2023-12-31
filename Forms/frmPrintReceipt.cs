﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAloverasPharmacyPOSSystem.Forms
{
    public partial class frmPrintReceipt : Form
    {
        public frmPrintReceipt()
        {
            InitializeComponent();
        }

        private void frmPrintReceipt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmPrintReceipt_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.rprtReceipt.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

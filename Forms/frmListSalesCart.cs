using System;
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
    public partial class frmListSalesCart : Form
    {
        public frmListSalesCart()
        {
            InitializeComponent();
        }

        Components.Value val = new Components.Value();
        Functions.Sale sale = new Functions.Sale();

        private void BackToListSalesForm()
        {
            this.Close();
        }

        private void frmListSalesCart_VisibleChanged(object sender, EventArgs e)
        {
            this.gridSalesCart.ClearSelection();
        }

        private void frmListSalesCart_KeyDown(object sender, KeyEventArgs e)
        {
            BackToListSalesForm();
        }

        private void frmListSalesCart_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListSalesCart_Load(object sender, EventArgs e)
        {
            sale.LoadSalesCart(val.TransactionId, this.gridSalesCart);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToListSalesForm();
        }
    }
}

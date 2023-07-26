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
            Forms.frmDashboard dashboard = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];

            pnlMain.Controls.Clear();
            Forms.frmListSales listSales = new Forms.frmListSales();
            listSales.TopLevel = false;
            pnlMain.Controls.Add(listSales);
            listSales.Dock = DockStyle.Fill;
            listSales.Show();

            this.Close();
        }

        private void frmListSalesCart_KeyDown(object sender, KeyEventArgs e)
        {
            BackToListSalesForm();
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

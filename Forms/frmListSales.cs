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
    public partial class frmListSales : Form
    {
        public frmListSales()
        {
            InitializeComponent();
        }

        Functions.Sale sale = new Functions.Sale();

        private void LoadSalesSumCount()
        {
            sale.LoadSalesWithDateRange(this.dateFrom.Value.Date, this.dateTo.Value.Date, this.gridSales);
            sale.SumTotalSalesWithDateRange(this.dateFrom.Value.Date, this.dateTo.Value.Date, this.lblTotalSales);
            sale.CountTransactionsWithDateRange(this.dateFrom.Value.Date, this.dateTo.Value.Date, this.lblTotalTransactions);
            sale.CountItemsReturnedWithDateRange(this.dateFrom.Value.Date, this.dateTo.Value.Date, this.lblTotalItemsReturned);
            sale.SumTotalAmountReturnedWithDateRange(this.dateFrom.Value.Date, this.dateTo.Value.Date, this.lblTotalAmountReturned);

            this.gridSales.ClearSelection();
        }

        private void frmListSales_VisibleChanged(object sender, EventArgs e)
        {
            this.gridSales.ClearSelection();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesSumCount();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesSumCount();
        }

        private void frmListSales_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListSales_Load(object sender, EventArgs e)
        {
            this.dateFrom.Value = DateTime.Now;
            this.dateTo.Value = DateTime.Now.AddDays(1);

            LoadSalesSumCount();

            DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.HeaderText = "ACTION";
            btnView.Name = "btnView";
            btnView.Text = "VIEW";
            btnView.UseColumnTextForButtonValue = true;
            this.gridSales.Columns.Insert(0, btnView);
        }

        private void gridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridSales.Columns[e.ColumnIndex].Name == "btnView")
            {
                if(sale.GetTransaction(long.Parse(this.gridSales.SelectedCells[1].Value.ToString())))
                {
                    Forms.frmListSalesCart listSalesCart = new Forms.frmListSalesCart();
                    listSalesCart.ShowDialog();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            sale.NextPage(this.gridSales);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            sale.PreviousPage(this.gridSales);
        }
    }
}

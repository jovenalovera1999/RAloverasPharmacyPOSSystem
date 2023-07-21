using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RAloverasPharmacyPOSSystem.Forms
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        Functions.Payment payment = new Functions.Payment();

        private void CalculateTotalAmountToPay()
        {
            double total = 0;

            for (int i = 0; i < this.gridCart.Rows.Count; i++)
            {
                total += double.Parse(this.gridCart.Rows[i].Cells[4].Value.ToString());
            }

            this.txtTotalAmountToPay.Text = total.ToString("0.00");

            this.txtAmount.Focus();
        }

        private void CalculateDiscount()
        {
            if(String.IsNullOrWhiteSpace(this.txtDiscount.Text))
            {
                this.txtDiscount.Text = "0";
                this.txtDiscounted.Text = "0";
            }
            else
            {
                double discount = double.Parse(this.txtTotalAmountToPay.Text) * (double.Parse(this.txtDiscount.Text) / 100);
                this.txtDiscounted.Text = (double.Parse(this.txtTotalAmountToPay.Text) - discount).ToString("0.00");
            }
        }

        private void CalculatePayment()
        {
            double total = 0;

            if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                total = 0;
            }
            else if (this.txtDiscount.Text == "0")
            {
                total = double.Parse(this.txtAmount.Text) - double.Parse(this.txtTotalAmountToPay.Text);
            }
            else
            {
                total = double.Parse(this.txtAmount.Text) - double.Parse(this.txtDiscounted.Text);
            }

            this.txtChange.Text = (total == 0) ? "0" : total.ToString("0.00");
        }

        private void gridForPaymentTransaction_MouseClick(object sender, MouseEventArgs e)
        {
            payment.LoadCartsForPayment(long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString()), this.gridCart);
            this.gridCart.ClearSelection();

            CalculateTotalAmountToPay();
        }

        private void frmPayment_VisibleChanged(object sender, EventArgs e)
        {
            this.gridCart.ClearSelection();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
            CalculatePayment();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculatePayment();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            payment.LoadUsersForPayment(this.gridForPaymentTransaction);
            payment.LoadCartsForPayment(long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString()), this.gridCart);

            CalculateTotalAmountToPay();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public class Cart
        {
            public string description { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }
            public double subTotal { get; set; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string totalAmountPaid = string.Empty;

            if(this.txtDiscounted.Text == "0")
            {
                totalAmountPaid = this.txtTotalAmountToPay.Text;
            }
            else
            {
                totalAmountPaid = this.txtDiscounted.Text;
            }

            List<Cart> cart = new List<Cart>();
            cart.Clear();

            for(int i = 0; i < this.gridCart.Rows.Count; i++)
            {
                cart.Add(new Cart() 
                {
                    description = this.gridCart.Rows[i].Cells[1].Value.ToString(),
                    price = double.Parse(this.gridCart.Rows[i].Cells[2].Value.ToString()),
                    quantity = int.Parse(this.gridCart.Rows[i].Cells[3].Value.ToString()),
                    subTotal = double.Parse(this.gridCart.Rows[i].Cells[4].Value.ToString())
                });
            }

            Forms.frmPrintReceipt printReceipt = new Forms.frmPrintReceipt();
            ReportViewer rprtReceipt = (ReportViewer)printReceipt.Controls["rprtReceipt"];

            ReportDataSource source = new ReportDataSource("dsCart", cart);
            rprtReceipt.LocalReport.DataSources.Clear();
            rprtReceipt.LocalReport.DataSources.Add(source);

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pDateToday", DateTime.Now.ToString("D")));
            parameters.Add(new ReportParameter("pTotal", totalAmountPaid));
            parameters.Add(new ReportParameter("pAmount", this.txtAmount.Text));
            parameters.Add(new ReportParameter("pDiscount", string.Format("{0}%", this.txtDiscount.Text)));
            parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
            rprtReceipt.LocalReport.SetParameters(parameters);

            printReceipt.ShowDialog();
        }
    }
}

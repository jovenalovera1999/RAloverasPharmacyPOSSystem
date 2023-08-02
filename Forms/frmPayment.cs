﻿using System;
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

        Components.Value val = new Components.Value();
        Functions.Payment payment = new Functions.Payment();
        Functions.Product product = new Functions.Product();
        Functions.Exist exist = new Functions.Exist();

        string transactionNo = string.Empty;

        private void AutoGenNum()
        {
            Random number = new Random();
            var generateId = new StringBuilder();

            while (generateId.Length < 9)
            {
                generateId.Append(number.Next(10).ToString());
            }

            transactionNo = generateId.ToString();
        }

        private void CalculateTotalAmountToPay()
        {
            this.gridCart.ClearSelection();

            double total = 0;

            for (int i = 0; i < this.gridCart.Rows.Count; i++)
            {
                total += double.Parse(this.gridCart.Rows[i].Cells[5].Value.ToString());
            }

            this.txtTotalAmountToPay.Text = total.ToString("0.00");

            this.txtAmount.Focus();
        }

        private void CalculateDiscount()
        {
            if(String.IsNullOrWhiteSpace(this.txtDiscount.Text) || double.IsNaN(double.Parse(this.txtDiscount.Text)) || this.txtDiscount.Text == "0")
            {
                this.txtDiscount.Text = "0";
                this.txtDiscounted.Text = "0";
            }
            else
            {
                this.txtDiscounted.Text = (double.Parse(this.txtTotalAmountToPay.Text) - double.Parse(this.txtDiscount.Text)).ToString("0.00");
            }
        }

        private void CalculatePayment()
        {
            double total = 0;

            if (String.IsNullOrWhiteSpace(this.txtAmount.Text) || double.IsNaN(double.Parse(this.txtAmount.Text)))
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

        private void LoadCarts()
        {
            payment.LoadUsersForPayment(this.gridForPaymentTransaction);

            if(this.gridForPaymentTransaction.Rows.Count < 1)
            {
                this.txtDiscount.Text = "0";
            }
            else
            {
                this.txtDiscount.Text = this.gridForPaymentTransaction.SelectedCells[2].Value.ToString();
            }

            if (this.gridForPaymentTransaction.Rows.Count > 0)
            {
                payment.LoadCartsForPaymentWithFilter(long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString()), this.gridCart);
            }
            else
            {
                payment.LoadCartsForPaymentWithoutFilter(this.gridCart);
            }
        }

        private void SaveTransaction()
        {
            if (this.gridCart.Rows.Count < 1)
            {
                MessageBox.Show("Failed to save transaction, there are no products!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Failed to save transaction, input amount first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else if (this.txtDiscount.Text == "0" && double.Parse(this.txtAmount.Text) < double.Parse(this.txtTotalAmountToPay.Text))
            {
                MessageBox.Show("Failed to save transaction, insufficient amount!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else if (double.Parse(this.txtDiscounted.Text) < 0)
            {
                MessageBox.Show("Discount is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiscount.Focus();
            }
            else if (this.txtDiscount.Text != "0" && double.Parse(this.txtAmount.Text) < double.Parse(this.txtDiscounted.Text))
            {
                MessageBox.Show("Failed to save transaction, insufficient amount!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else
            {
                bool isInserted = false;

                if (payment.InsertTransaction(transactionNo, double.Parse(this.txtTotalAmountToPay.Text), double.Parse(this.txtDiscount.Text),
                    double.Parse(this.txtDiscounted.Text), double.Parse(this.txtAmount.Text), double.Parse(this.txtChange.Text), val.MyUserId))
                {
                    for (int i = 0; i < this.gridCart.Rows.Count; i++)
                    {
                        if (payment.InsertTransactionIdToCarts(long.Parse(this.gridCart.Rows[i].Cells[0].Value.ToString()), val.TransactionId,
                            long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString())))
                        {
                            if (i == this.gridCart.Rows.Count - 1)
                            {
                                isInserted = true;
                            }
                        }
                    }

                    if (payment.UpdateDiscountIdAfterPaymentTransaction(long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString()),
                        double.Parse(this.txtDiscount.Text)) && isInserted == true)
                    {
                        MessageBox.Show("Transaction was successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AutoGenNum();

                        if (exist.IsTransactionNoExist(transactionNo))
                        {
                            AutoGenNum();
                        }

                        LoadCarts();

                        this.txtDiscount.Text = "0";
                        this.txtDiscounted.Text = "0";
                        this.txtChange.Text = "0";

                        this.txtAmount.ResetText();

                        if(this.gridForPaymentTransaction.Rows.Count > 0)
                        {
                            this.txtDiscount.Text = this.gridForPaymentTransaction.SelectedCells[2].Value.ToString();
                        }
                        else
                        {
                            this.txtDiscount.Text = "0";
                        }

                        CalculateTotalAmountToPay();
                        CalculateDiscount();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save transaction!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to insert transaction!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrintReceipt()
        {
            if(this.gridCart.Rows.Count < 1)
            {
                MessageBox.Show("Failed to print, there are no products!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Failed to print, input amount first!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else if (this.txtDiscount.Text == "0" && double.Parse(this.txtAmount.Text) < double.Parse(this.txtTotalAmountToPay.Text))
            {
                MessageBox.Show("Failed to print, insufficient amount!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else if (this.txtDiscount.Text != "0" && double.Parse(this.txtAmount.Text) < double.Parse(this.txtDiscounted.Text))
            {
                MessageBox.Show("Failed to print, insufficient amount!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else
            {
                string totalAmountPaid = string.Empty;

                if (this.txtDiscounted.Text == "0")
                {
                    totalAmountPaid = this.txtTotalAmountToPay.Text;
                }
                else
                {
                    totalAmountPaid = this.txtDiscounted.Text;
                }

                List<Cart> cart = new List<Cart>();
                cart.Clear();

                for (int i = 0; i < this.gridCart.Rows.Count; i++)
                {
                    cart.Add(new Cart()
                    {
                        description = this.gridCart.Rows[i].Cells[2].Value.ToString(),
                        price = double.Parse(this.gridCart.Rows[i].Cells[3].Value.ToString()),
                        quantity = int.Parse(this.gridCart.Rows[i].Cells[4].Value.ToString()),
                        subTotal = double.Parse(this.gridCart.Rows[i].Cells[5].Value.ToString())
                    });
                }

                Forms.frmPrintReceipt printReceipt = new Forms.frmPrintReceipt();
                ReportViewer rprtReceipt = (ReportViewer)printReceipt.Controls["rprtReceipt"];

                ReportDataSource source = new ReportDataSource("dsCart", cart);
                rprtReceipt.LocalReport.DataSources.Clear();
                rprtReceipt.LocalReport.DataSources.Add(source);

                ReportParameterCollection parameters = new ReportParameterCollection();
                parameters.Add(new ReportParameter("pTransactionNo", transactionNo));
                parameters.Add(new ReportParameter("pDateToday", DateTime.Now.ToString("g")));
                parameters.Add(new ReportParameter("pTotal", totalAmountPaid));
                parameters.Add(new ReportParameter("pAmount", double.Parse(this.txtAmount.Text).ToString("0.00")));
                parameters.Add(new ReportParameter("pDiscount", double.Parse(this.txtDiscount.Text).ToString("0.00")));
                parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
                rprtReceipt.LocalReport.SetParameters(parameters);

                printReceipt.ShowDialog();
            }
        }

        private void gridForPaymentTransaction_MouseClick(object sender, MouseEventArgs e)
        {
            payment.LoadCartsForPaymentWithFilter(long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString()), this.gridCart);

            this.txtDiscount.Text = this.gridForPaymentTransaction.SelectedCells[2].Value.ToString();
            this.gridCart.ClearSelection();

            this.txtAmount.ResetText();

            CalculateTotalAmountToPay();
            CalculateDiscount();
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
            CalculateDiscount();
            CalculatePayment();
        }

        private void frmPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                SaveTransaction();
            }
            else if(e.KeyCode == Keys.F2)
            {
                PrintReceipt();
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace and period
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }

            // Checks to make sure only 1 period is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace and period
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }

            // Checks to make sure only 1 period is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void frmPayment_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            AutoGenNum();

            if(exist.IsTransactionNoExist(transactionNo))
            {
                AutoGenNum();
            }

            LoadCarts();
            CalculateTotalAmountToPay();
            CalculateDiscount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTransaction();
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
            PrintReceipt();
        }
    }
}

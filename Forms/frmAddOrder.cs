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
    public partial class frmAddOrder : Form
    {
        public frmAddOrder()
        {
            InitializeComponent();
        }

        Components.Value val = new Components.Value();
        Functions.Product product = new Functions.Product();
        Functions.Order order = new Functions.Order();

        private void ToPay() {
            if (this.gridCart.Rows.Count < 1) {
                MessageBox.Show("Failed to send to payment transaction, there are no products added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (double.Parse(this.txtAmount.Text) == 0) { 
            
            } else if (double.Parse(this.txtTotalAmountToPay.Text) < 0) {
                MessageBox.Show("Discount is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiscount.Focus();
            } else if (double.Parse(this.txtTotalAmountToPay.Text) > double.Parse(this.txtAmount.Text)) {
                MessageBox.Show("Failed to send to payment transaction, insufficient amount!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else {
                bool isInserted = false;

                if (order.InsertUserForPayment(val.MyUserId, double.Parse(this.txtDiscount.Text), double.Parse(this.txtAmount.Text))) {
                    for (int i = 0; i < this.gridCart.Rows.Count; i++) {
                        if (order.ToPay(val.UserForPaymentId, long.Parse(this.gridCart.Rows[i].Cells[1].Value.ToString()),
                            int.Parse(this.gridCart.Rows[i].Cells[4].Value.ToString()), double.Parse(this.gridCart.Rows[i].Cells[5].Value.ToString())) &&
                            product.DeductProduct(long.Parse(this.gridCart.Rows[i].Cells[1].Value.ToString()),
                            int.Parse(this.gridCart.Rows[i].Cells[4].Value.ToString()))) {
                            if (i == this.gridCart.Rows.Count - 1) {
                                isInserted = true;
                            }
                        }
                    }
                }

                if (isInserted) {
                    MessageBox.Show("Transaction has been sent for payment!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsWithOrWithoutSearch();

                    this.gridCart.Rows.Clear();

                    this.txtTotalAmountToPay.Text = "0.00";
                    this.txtDiscount.Text = "0.00";
                    this.txtAmount.Text = "0.00";

                    this.gridAvailableProducts.Focus();
                } else {
                    MessageBox.Show("Failed to send transaction for payment!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenQuantityForm() {
            Forms.frmAddOrderQuantity addOrderQuantity = new Forms.frmAddOrderQuantity();
            addOrderQuantity.ShowDialog();
        }

        private void LoadProductsWithOrWithoutSearch() {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text)) {
                product.LoadProducts(this.gridAvailableProducts);
            } else {
                product.SearchProduct(this.txtSearch.Text, this.gridAvailableProducts);
            }
        }

        private void gridAvailableProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridAvailableProducts.Columns[e.ColumnIndex].Name == "btnAddToCart") {
                OpenQuantityForm();
            }
        }

        private void gridCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridCart.Columns[e.ColumnIndex].Name == "btnRemove") {
                foreach (DataGridViewRow row in this.gridCart.SelectedRows) {
                    this.gridCart.Rows.Remove(row);
                    this.gridCart.ClearSelection();

                    double totalAmountToPay = 0;

                    for (int i = 0; i < this.gridCart.Rows.Count; i++) {
                        totalAmountToPay += double.Parse(this.gridCart.Rows[i].Cells[5].Value.ToString());
                    }

                    this.txtTotalAmountToPay.Text = (totalAmountToPay - double.Parse(this.txtDiscount.Text)).ToString("0.00");
                }
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace and period
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46) {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 period is allowed
            if (e.KeyChar == 46) {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1) {
                    e.Handled = true;
                }
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace and period
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46) {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 period is allowed
            if (e.KeyChar == 46) {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1) {
                    e.Handled = true;
                }
            }
        }

        private void frmAddOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1) {
                ToPay();
            } else if(e.KeyCode == Keys.F2) {
                OpenQuantityForm();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProductsWithOrWithoutSearch();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double totalAmountToPay = 0;

            for (int i = 0; i < gridCart.Rows.Count; i++) {
                totalAmountToPay += double.Parse(gridCart.Rows[i].Cells[5].Value.ToString());
            }

            txtTotalAmountToPay.Text = totalAmountToPay.ToString("0.00");

            if (String.IsNullOrEmpty(this.txtDiscount.Text) || double.IsNaN(double.Parse(this.txtDiscount.Text))) {
                this.txtTotalAmountToPay.Text = totalAmountToPay.ToString("0.00");
                this.txtDiscount.Text = "0.00";
            } else if(this.txtDiscount.Text != "0") {
                this.txtTotalAmountToPay.Text = (totalAmountToPay - double.Parse(this.txtDiscount.Text)).ToString("0.00");
            } else {
                this.txtTotalAmountToPay.Text = totalAmountToPay.ToString("0.00");
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtAmount.Text)) {
                this.txtAmount.Text = "0.00";
            }
        }

        private void frmAddOrder_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.txtSearch.CharacterCasing = CharacterCasing.Upper;

            product.LoadProducts(this.gridAvailableProducts);

            DataGridViewButtonColumn btnAddToCart = new DataGridViewButtonColumn();
            btnAddToCart.HeaderText = "ACTION";
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Text = "ADD TO CART (F2)";
            btnAddToCart.UseColumnTextForButtonValue = true;
            this.gridAvailableProducts.Columns.Insert(0, btnAddToCart);

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.HeaderText = "ACTION";
            btnRemove.Name = "btnRemove";
            btnRemove.Text = "REMOVE";
            btnRemove.UseColumnTextForButtonValue = true;
            this.gridCart.Columns.Insert(0, btnRemove);

            this.gridAvailableProducts.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            product.NextPageAtOrder(this.gridAvailableProducts);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            product.PreviousPageAtOrder(this.gridAvailableProducts);
        }

        private void btnToPay_Click(object sender, EventArgs e)
        {
            ToPay();
        }
    }
}

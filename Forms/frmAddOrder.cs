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

        private void ToPay()
        {
            if (this.gridCart.Rows.Count < 1)
            {
                MessageBox.Show("Failed to send to payment transaction, there are no products added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(this.txtDiscount.Text))
            {
                MessageBox.Show("Discount is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiscount.Focus();
            }
            else
            {
                bool isInserted = false;

                if (order.InsertUserForPayment(val.MyUserId, double.Parse(this.txtDiscount.Text)))
                {
                    for (int i = 0; i < this.gridCart.Rows.Count; i++)
                    {
                        if (order.ToPay(val.UserForPaymentId, long.Parse(this.gridCart.Rows[i].Cells[1].Value.ToString()),
                            int.Parse(this.gridCart.Rows[i].Cells[4].Value.ToString()), double.Parse(this.gridCart.Rows[i].Cells[5].Value.ToString())))
                        {
                            if (i == this.gridCart.Rows.Count - 1)
                            {
                                isInserted = true;
                            }
                        }
                    }
                }

                if (isInserted == true)
                {
                    MessageBox.Show("Transaction has been sent for payment!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsWithOrWithoutSearch();

                    this.gridCart.Rows.Clear();

                    this.txtTotalAmountToPay.Text = "0.00";
                    this.txtDiscount.Text = "0";

                    this.gridAvailableProducts.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to send transaction for payment!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenQuantityForm()
        {
            Forms.frmAddOrderQuantity addOrderQuantity = new Forms.frmAddOrderQuantity();
            addOrderQuantity.ShowDialog();
        }

        private void LoadProductsWithOrWithoutSearch()
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                product.LoadProducts(this.gridAvailableProducts);
            }
            else
            {
                product.SearchProduct(this.txtSearch.Text, this.gridAvailableProducts);
            }
        }

        private void gridAvailableProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridAvailableProducts.Columns[e.ColumnIndex].Name == "btnAddToCart")
            {
                OpenQuantityForm();
            }
        }

        private void gridCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridCart.Columns[e.ColumnIndex].Name == "btnRemove")
            {
                foreach (DataGridViewRow row in this.gridCart.SelectedRows)
                {
                    this.gridCart.Rows.Remove(row);
                    this.gridCart.ClearSelection();

                    double totalAmountToPay = 0;

                    for (int i = 0; i < this.gridCart.Rows.Count; i++)
                    {
                        totalAmountToPay += double.Parse(this.gridCart.Rows[i].Cells[5].Value.ToString());
                    }

                    this.txtTotalAmountToPay.Text = totalAmountToPay.ToString("0.00");
                }
            }
        }

        private void frmAddOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                ToPay();
            }
            else if(e.KeyCode == Keys.F2)
            {
                OpenQuantityForm();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProductsWithOrWithoutSearch();
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
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

        private void frmAddOrder_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

        Functions.Product product = new Functions.Product();
        Functions.Order order = new Functions.Order();

        private void OpenQuantityForm()
        {
            Forms.frmAddOrderQuantity addOrderQuantity = new Forms.frmAddOrderQuantity();
            addOrderQuantity.ShowDialog();
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
            if(e.KeyCode == Keys.F2)
            {
                OpenQuantityForm();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                product.LoadProducts(this.gridAvailableProducts);
            }
            else
            {
                product.SearchProduct(this.txtSearch.Text, this.gridAvailableProducts);
            }
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

        private void btnToPay_Click(object sender, EventArgs e)
        {
            // if(order.ToPay())
            // {
            // 
            // }
        }
    }
}

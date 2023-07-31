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
    public partial class frmListProducts : Form
    {
        public frmListProducts()
        {
            InitializeComponent();
        }

        Functions.Product product = new Functions.Product();

        private void OpenAddProductForm()
        {
            this.gridProducts.ClearSelection();

            Forms.frmAddProduct addProduct = new Forms.frmAddProduct();
            addProduct.ShowDialog();
        }

        private void frmListProducts_VisibleChanged(object sender, EventArgs e)
        {
            this.gridProducts.ClearSelection();
        }

        private void frmListProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                OpenAddProductForm();
            }
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridProducts.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                if(product.GetProduct(long.Parse(this.gridProducts.SelectedCells[2].Value.ToString())))
                {
                    Forms.frmUpdateProduct updateProduct = new Forms.frmUpdateProduct();
                    updateProduct.ShowDialog();
                }
            }
            else if(this.gridProducts.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(product.DeleteProduct(long.Parse(this.gridProducts.SelectedCells[2].Value.ToString())))
                    {
                        MessageBox.Show("Product was successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        product.LoadProducts(this.gridProducts);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete prodct!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.gridProducts.ClearSelection();
                this.txtSearch.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                product.LoadProducts(this.gridProducts);
            }
            else
            {
                product.SearchProduct(this.txtSearch.Text, this.gridProducts);
            }

            this.gridProducts.ClearSelection();
        }

        private void frmListProducts_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            product.LoadProducts(this.gridProducts);

            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "ACTION";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseColumnTextForButtonValue = true;
            this.gridProducts.Columns.Insert(0, btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "DELETE";
            btnDelete.UseColumnTextForButtonValue = true;
            this.gridProducts.Columns.Insert(1, btnDelete);

            this.txtSearch.Focus();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenAddProductForm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            product.NextPage(this.gridProducts);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            product.PreviousPage(this.gridProducts);
        }
    }
}

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

        Components.Value val = new Components.Value();
        Functions.Product product = new Functions.Product();

        bool isProducts = false;
        bool isReturnedProducts = false;

        private void LoadProductsAction()
        {
            if (val.MyUserLevel == "ADMIN")
            {
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
            }
        }

        private void LoadProducts()
        {
            isReturnedProducts = false;
            isProducts = true;

            this.gridProducts.Columns.Clear();
            product.LoadProducts(this.gridProducts);
            LoadProductsAction();

            this.gridProducts.ClearSelection();
            this.txtSearch.Focus();
        }

        private void LoadReturnedProducts()
        {
            isProducts = false;
            isReturnedProducts = true;

            this.gridProducts.Columns.Clear();
            product.LoadReturnedProducts(this.gridProducts);
            LoadProductsAction();

            this.gridProducts.ClearSelection();
            this.txtSearch.Focus();
        }

        private void OpenAddProductForm()
        {
            this.gridProducts.ClearSelection();

            Forms.frmAddProduct addProduct = new Forms.frmAddProduct();
            addProduct.ShowDialog();
        }

        private void OpenAddReturnProductForm()
        {
            Forms.frmDashboard dashboard = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];

            pnlMain.Controls.Clear();
            Forms.frmAddReturnProduct returnProduct = new Forms.frmAddReturnProduct();
            returnProduct.TopLevel = false;
            pnlMain.Controls.Add(returnProduct);
            returnProduct.Dock = DockStyle.Fill;
            returnProduct.Show();
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
            else if(e.KeyCode == Keys.F2)
            {
                OpenAddReturnProductForm();
            }
            else if(e.KeyCode == Keys.F3)
            {
                LoadProducts();
            }
            else if(e.KeyCode == Keys.F4)
            {
                LoadReturnedProducts();
            }
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(isProducts && this.gridProducts.Columns[e.ColumnIndex].Name == "btnUpdate") 
            {
                if(product.GetProduct(long.Parse(this.gridProducts.SelectedCells[2].Value.ToString())))
                {
                    Forms.frmUpdateProduct updateProduct = new Forms.frmUpdateProduct();
                    updateProduct.ShowDialog();
                }
            }
            else if(isProducts && this.gridProducts.Columns[e.ColumnIndex].Name == "btnDelete") 
            {
                if(MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
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
            else if(isReturnedProducts && this.gridProducts.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                if(product.GetReturnedProduct(long.Parse(this.gridProducts.SelectedCells[2].Value.ToString())))
                {
                    Forms.frmDashboard dashboard = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
                    Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];
                    
                    pnlMain.Controls.Clear();
                    Forms.frmUpdateReturnProduct updateReturnProduct = new Forms.frmUpdateReturnProduct();
                    updateReturnProduct.TopLevel = false;
                    pnlMain.Controls.Add(updateReturnProduct);
                    updateReturnProduct.Dock = DockStyle.Fill;
                    updateReturnProduct.Show();
                }
            }
            else if(isReturnedProducts && this.gridProducts.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this returned product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes) 
                { 
                    if(product.DeleteReturnedProduct(long.Parse(this.gridProducts.SelectedCells[2].Value.ToString()))) 
                    {
                        MessageBox.Show("Returned product was successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                        product.LoadReturnedProducts(this.gridProducts);
                        this.gridProducts.ClearSelection();
                    } 
                    else 
                    {
                        MessageBox.Show("Failed to delete returned product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(isProducts)
                {
                    product.LoadProducts(this.gridProducts);
                }
                else
                {
                    product.LoadReturnedProducts(this.gridProducts);
                }
            }
            else
            {
                if(isProducts)
                {
                    product.SearchProduct(this.txtSearch.Text, this.gridProducts);
                }
                else
                {
                    product.SearchReturnedProduct(this.txtSearch.Text, this.gridProducts);
                }
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
            this.txtSearch.CharacterCasing = CharacterCasing.Upper;

            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenAddProductForm();
        }

        private void btnAddReturnProduct_Click(object sender, EventArgs e)
        {
            OpenAddReturnProductForm();
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnLoadReturnedProducts_Click(object sender, EventArgs e)
        {
            LoadReturnedProducts();
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

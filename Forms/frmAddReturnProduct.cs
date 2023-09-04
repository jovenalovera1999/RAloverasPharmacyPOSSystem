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
    public partial class frmAddReturnProduct : Form
    {
        public frmAddReturnProduct()
        {
            InitializeComponent();
        }

        Functions.Product product = new Functions.Product();

        private void CapsLock() {
            this.txtDescription.CharacterCasing = CharacterCasing.Upper;
            this.txtSearch.CharacterCasing = CharacterCasing.Upper;
        }

        private void LoadReturnedProductsAction() {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.HeaderText = "ACTION";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseColumnTextForButtonValue = true;
            this.gridReturnProducts.Columns.Insert(0, btnUpdate);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "DELETE";
            btnDelete.UseColumnTextForButtonValue = true;
            this.gridReturnProducts.Columns.Insert(1, btnDelete);
        }

        private void SaveReturnedProduct() {
            if (double.Parse(this.txtQuantity.Text) < 1) {
                MessageBox.Show("Failed to save returned product, quantity must be greater than zero.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtQuantity.Text = "0";
                this.txtQuantity.Focus();
            } else if (double.Parse(this.txtAmountReturned.Text) < 1) {
                MessageBox.Show("Failed to save returned product, amount returned must be greater than zeo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmountReturned.Text = "0.00";
                this.txtAmountReturned.Focus();
            } else if (this.gridReturnProducts.SelectedRows.Count < 1) {
                MessageBox.Show("Select the product code and packaging unit of the description you just typed first to add back the quantity of the returned product.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (product.InsertReturnedProduct(long.Parse(this.gridReturnProducts.SelectedCells[0].Value.ToString()),
                    int.Parse(this.txtQuantity.Text), double.Parse(this.txtAmountReturned.Text)) &&
                    product.updateProductQuantityWhenReturnedProduct(long.Parse(this.gridReturnProducts.SelectedCells[0].Value.ToString()),
                    int.Parse(this.txtQuantity.Text))) {
                    MessageBox.Show("Returned product was successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txtDescription.ResetText();

                    this.txtQuantity.Text = "0";
                    this.txtAmountReturned.Text = "0.00";

                    product.LoadReturnedProducts(this.gridReturnProducts);

                    this.txtDescription.Focus();
                } else {
                    MessageBox.Show("Failed to save returned product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenListProductsForm() {
            Forms.frmDashboard dashboard = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];

            pnlMain.Controls.Clear();
            Forms.frmListProducts products = new Forms.frmListProducts();
            products.TopLevel = false;
            pnlMain.Controls.Add(products);
            products.Dock = DockStyle.Fill;
            products.Show();
        }

        private void gridReturnProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridReturnProducts.Columns[e.ColumnIndex].Name == "btnUpdate") { 
            } else if(this.gridReturnProducts.Columns[e.ColumnIndex].Name == "btnDelete") {
                if(MessageBox.Show("Are you sure you want to delete this returned product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes) { 
                    if(product.DeleteReturnedProduct(long.Parse(this.gridReturnProducts.SelectedCells[2].Value.ToString()))) {
                        MessageBox.Show("Returned product was successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        product.LoadReturnedProducts(this.gridReturnProducts);
                        this.gridReturnProducts.ClearSelection();

                        this.txtDescription.Focus();
                    } else {
                        MessageBox.Show("Failed to delete returned product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtDescription.Text)) {
                this.lblMessage.Visible = false;

                product.LoadReturnedProducts(this.gridReturnProducts);
                LoadReturnedProductsAction();

                this.gridReturnProducts.ClearSelection();
            } else {
                this.lblMessage.Visible = true;

                for(int i = 0; i < this.gridReturnProducts.Columns.Count; i++) {
                    if(this.gridReturnProducts.Columns[i].Name == "btnUpdate") { 
                        this.gridReturnProducts.Columns.Remove("btnUpdate");
                    } 
                    
                    if(this.gridReturnProducts.Columns[i].Name == "btnDelete") { 
                        this.gridReturnProducts.Columns.Remove("btnDelete");
                    }
                }

                product.SearchProduct(this.txtDescription.Text, this.gridReturnProducts);
                this.gridReturnProducts.ClearSelection();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtQuantity.Text)) {
                this.txtQuantity.Text = "0";
            }
        }

        private void txtAmountReturned_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtAmountReturned.Text)) {
                this.txtAmountReturned.Text = "0.00";
            }
        }

        private void frmAddReturnProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) {
                SaveReturnedProduct();
            } else if (e.KeyCode == Keys.F2) {
                OpenListProductsForm();
            }
        }

        private void frmAddReturnProduct_VisibleChanged(object sender, EventArgs e)
        {
            this.gridReturnProducts.ClearSelection();
        }

        private void frmAddReturnProduct_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddReturnProduct_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            CapsLock();

            product.LoadReturnedProducts(this.gridReturnProducts);
            LoadReturnedProductsAction();

            this.txtDescription.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveReturnedProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenListProductsForm();
        }
    }
}

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
    public partial class frmUpdateReturnProduct : Form
    {
        public frmUpdateReturnProduct()
        {
            InitializeComponent();

            this.txtQuantity.Click += TextBoxOnClick;
            this.txtAmountReturned.Click += TextBoxOnClick;
        }

        Components.Value val = new Components.Value();
        Functions.Product product = new Functions.Product();

        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void CapsLock()
        {
            this.txtDescription.CharacterCasing = CharacterCasing.Upper;
        }

        private void LoadProducts()
        {
            if (String.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                product.LoadProducts(this.gridProducts);
            }
            else
            {
                product.SearchProduct(this.txtDescription.Text, this.gridProducts);
            }

            this.gridProducts.ClearSelection();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtQuantity.Text))
            {
                this.txtQuantity.Text = "0";
            }
        }

        private void txtAmountReturned_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtAmountReturned.Text))
            {
                this.txtAmountReturned.Text = "0.00";
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtAmountReturned_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmUpdateReturnProduct_VisibleChanged(object sender, EventArgs e)
        {
            this.gridProducts.ClearSelection();
        }

        private void frmUpdateReturnProduct_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            CapsLock();

            this.txtDescription.Text = val.ReturnProductDescription;
            this.txtQuantity.Text = val.ReturnProductQuantity.ToString();
            this.txtAmountReturned.Text = val.ReturnProductAmountReturned.ToString();

            LoadProducts();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            product.NextPage(this.gridProducts);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            product.PreviousPage(this.gridProducts);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (double.Parse(this.txtQuantity.Text) < 1)
            {
                MessageBox.Show("Failed to update returned product, quantity must be greater than zero!");
                this.txtQuantity.Focus();
            }
            else if (double.Parse(this.txtAmountReturned.Text) < 1)
            {
                MessageBox.Show("Failed to update returned product, amount returned must be greater than zero!");
                this.txtAmountReturned.Focus();
            }
            else if (this.gridProducts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select the product code and packaging unit of the description you just typed first to add back the quantity of the returned product!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (product.UpdateReturnedProduct(val.ProductId, val.ReturnProductQuantity, val.ReturnProductId, long.Parse(this.gridProducts.SelectedCells[0].Value.ToString()),
                    int.Parse(this.txtQuantity.Text), double.Parse(this.txtAmountReturned.Text)))
                {
                    MessageBox.Show("Returned product was successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frmDashboard dashboard = (Forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlMain = (Panel)dashboard.Controls["pnlMain"];

            pnlMain.Controls.Clear();
            Forms.frmListProducts products = new Forms.frmListProducts();
            products.TopLevel = false;
            pnlMain.Controls.Add(products);
            products.Dock = DockStyle.Fill;
            products.Show();
        }

        private void frmUpdateReturnProduct_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmUpdateProduct : Form
    {
        public frmUpdateProduct()
        {
            InitializeComponent();

            this.txtQuantity.Click += TextBoxOnClick;
            this.txtPrice.Click += TextBoxOnClick;
            this.txtDiscount.Click += TextBoxOnClick;
            this.txtPriceFromSupplier.Click += TextBoxOnClick;
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
            this.txtCode.CharacterCasing = CharacterCasing.Upper;
            this.txtDescription.CharacterCasing = CharacterCasing.Upper;
            this.txtPackagingUnit.CharacterCasing = CharacterCasing.Upper;
            this.txtGeneric.CharacterCasing = CharacterCasing.Upper;
            this.txtSupplier.CharacterCasing = CharacterCasing.Upper;
        }

        private void CalculateDiscount() 
        {
            if (String.IsNullOrWhiteSpace(this.txtPrice.Text) || double.Parse(this.txtPrice.Text) < 1)
            {
                this.txtPrice.Text = "0.00";
                this.txtDiscounted.Text = "0.00";
            } 
            else if (String.IsNullOrWhiteSpace(this.txtDiscount.Text) || double.Parse(this.txtDiscount.Text) < 1)
            {
                this.txtDiscount.Text = "0.00";
                this.txtDiscounted.Text = "0.00";
            } 
            else if (double.IsNaN(double.Parse(this.txtPrice.Text)) || double.IsNaN(double.Parse(this.txtDiscount.Text))) 
            {
                this.txtDiscounted.Text = "0.00";
            }
            else
            {
                double discount = double.Parse(this.txtPrice.Text) * (double.Parse(this.txtDiscount.Text) / 100);
                this.txtDiscounted.Text = (double.Parse(this.txtPrice.Text) - discount).ToString();
            }
        }

        private void UpdateProduct() {
            if (String.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                MessageBox.Show("Description is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDescription.Focus();
            } 
            else if (String.IsNullOrWhiteSpace(this.txtPackagingUnit.Text))
            {
                MessageBox.Show("Packaging unit is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPackagingUnit.Focus();
            } 
            else if (String.IsNullOrWhiteSpace(this.txtQuantity.Text)) 
            {
                MessageBox.Show("Quantity is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtQuantity.Focus();
            } 
            else if (String.IsNullOrWhiteSpace(this.txtPrice.Text)) 
            {
                MessageBox.Show("Price is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPrice.Focus();
            } 
            else
            {
                if (product.UpdateProduct(val.ProductId, this.txtDescription.Text, this.txtPackagingUnit.Text, int.Parse(this.txtQuantity.Text),
                    double.Parse(this.txtPrice.Text), double.Parse(this.txtDiscount.Text), double.Parse(this.txtDiscounted.Text), this.txtGeneric.Text,
                    this.txtSupplier.Text, double.Parse(this.txtPriceFromSupplier.Text)))
                {
                    MessageBox.Show("Product was successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Forms.frmListProducts listProducts = (Forms.frmListProducts)Application.OpenForms["frmListProducts"];
                    Guna.UI2.WinForms.Guna2TextBox txtSearch = (Guna.UI2.WinForms.Guna2TextBox)listProducts.Controls["txtSearch"];
                    DataGridView gridProducts = (DataGridView)listProducts.Controls["gridProducts"];
                    
                    if(String.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        product.LoadProducts(gridProducts);
                    }
                    else
                    {
                        product.SearchProduct(txtSearch.Text, gridProducts);
                    }

                    gridProducts.ClearSelection();
                    this.txtDescription.Focus();
                }
                else 
                {
                    MessageBox.Show("Failed to save product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseUpdateProductForm() 
        {
            Forms.frmListProducts listProducts = (Forms.frmListProducts)Application.OpenForms["frmListProducts"];
            DataGridView gridProducts = (DataGridView)listProducts.Controls["gridProducts"];
            gridProducts.ClearSelection();

            this.Close();
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPriceFromSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void frmUpdateProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                UpdateProduct();
            }
            else if (e.KeyCode == Keys.F2)
            {
                CloseUpdateProductForm();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void txtPriceFromSupplier_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtPriceFromSupplier.Text))
            {
                this.txtPriceFromSupplier.Text = "0.00";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtQuantity.Text))
            {
                this.txtQuantity.Text = "0";
            }
        }

        private void frmUpdateProduct_VisibleChanged(object sender, EventArgs e)
        {
            Forms.frmListProducts listProducts = (Forms.frmListProducts)Application.OpenForms["frmListProducts"];
            Guna.UI2.WinForms.Guna2TextBox txtSearch = (Guna.UI2.WinForms.Guna2TextBox)listProducts.Controls["txtSearch"];
            txtSearch.Focus();
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            this.txtCode.Text = val.ProductCode;
            this.txtDescription.Text = val.ProductDescription;
            this.txtPackagingUnit.Text = val.ProductPackagingUnit;
            this.txtQuantity.Text = val.ProductQuantity.ToString();
            this.txtPrice.Text = val.ProductPrice.ToString();
            this.txtDiscount.Text = val.ProductDiscount.ToString();
            this.txtDiscounted.Text = val.ProductDiscounted.ToString();
            this.txtGeneric.Text = val.ProductGeneric;
            this.txtSupplier.Text = val.ProductSupplier;
            this.txtPriceFromSupplier.Text = val.ProductPriceFromSupplier.ToString();

            CapsLock();
            this.KeyPreview = true;

            this.txtDescription.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseUpdateProductForm();
        }
    }
}

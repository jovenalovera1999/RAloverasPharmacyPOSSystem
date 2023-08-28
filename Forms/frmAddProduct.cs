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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        Components.Value val = new Components.Value();
        Functions.Product product = new Functions.Product();
        Functions.Exist exist = new Functions.Exist();

        private void CapsLock() {
            this.txtCode.CharacterCasing = CharacterCasing.Upper;
            this.txtDescription.CharacterCasing = CharacterCasing.Upper;
            this.txtPackagingUnit.CharacterCasing = CharacterCasing.Upper;
            this.txtGeneric.CharacterCasing = CharacterCasing.Upper;
            this.txtSupplier.CharacterCasing = CharacterCasing.Upper;
        }

        private void CalculateDiscount() {
            if(String.IsNullOrWhiteSpace(this.txtPrice.Text) || double.Parse(this.txtPrice.Text) == 0) {
                this.txtPrice.Text = null;
                this.txtDiscounted.Text = "0.00";
            } else if(String.IsNullOrWhiteSpace(this.txtDiscount.Text) || double.Parse(this.txtDiscount.Text) == 0) {
                this.txtDiscount.Text = "0.00";
                this.txtDiscounted.Text = "0.00";
            } else if(double.IsNaN(double.Parse(this.txtPrice.Text)) || double.IsNaN(double.Parse(this.txtDiscount.Text))) {
                this.txtDiscounted.Text = "0.00";
            } else {
                this.txtDiscounted.Text = (double.Parse(this.txtPrice.Text) - double.Parse(this.txtDiscount.Text)).ToString("0.00");
            }
        }

        private void AutoGenNum() {
            Random number = new Random();
            var generateId = new StringBuilder();

            while(generateId.Length < 9) {
                generateId.Append(number.Next(10).ToString());
            }

            this.txtCode.Text = generateId.ToString();
        }

        private void SaveProduct()
        {
            if (String.IsNullOrWhiteSpace(this.txtDescription.Text)) {
                MessageBox.Show("Description is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDescription.Focus();
            } else if (String.IsNullOrWhiteSpace(this.txtPackagingUnit.Text)) {
                MessageBox.Show("Packaging unit is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPackagingUnit.Focus();
            } else if (String.IsNullOrWhiteSpace(this.txtQuantity.Text)) {
                MessageBox.Show("Quantity is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtQuantity.Focus();
            } else if (String.IsNullOrWhiteSpace(this.txtPrice.Text)) {
                MessageBox.Show("Price is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPrice.Focus();
            } else if (!String.IsNullOrWhiteSpace(this.txtDiscounted.Text) && double.Parse(this.txtDiscounted.Text) < 0) {
                MessageBox.Show("Discount is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiscount.Focus();
            } else {
                if (product.InsertProduct(this.txtCode.Text, this.txtDescription.Text, this.txtPackagingUnit.Text, int.Parse(this.txtQuantity.Text),
                    double.Parse(this.txtPrice.Text), double.Parse(this.txtDiscount.Text), double.Parse(this.txtDiscounted.Text), this.txtGeneric.Text,
                    this.txtSupplier.Text, double.Parse(this.txtPriceFromSupplier.Text), val.MyUserId)) {
                    MessageBox.Show("Product was successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Forms.frmListProducts listProducts = (Forms.frmListProducts)Application.OpenForms["frmListProducts"];
                    DataGridView gridProducts = (DataGridView)listProducts.Controls["gridProducts"];
                    product.LoadProducts(gridProducts);
                    gridProducts.ClearSelection();

                    this.txtCode.ResetText();
                    this.txtDescription.ResetText();
                    this.txtPackagingUnit.ResetText();
                    this.txtQuantity.ResetText();
                    this.txtPrice.ResetText();
                    this.txtGeneric.ResetText();
                    this.txtSupplier.ResetText();

                    this.txtDiscount.Text = "0.00";
                    this.txtDiscounted.Text = "0.00";
                    this.txtPriceFromSupplier.Text = "0.00";

                    AutoGenNum();
                    this.txtDescription.Focus();
                } else {
                    MessageBox.Show("Failed to save product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) {
                e.Handled = true;
                return;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPriceFromSupplier_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAddProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1) {
                SaveProduct();
            } else if(e.KeyCode == Keys.F2) {
                this.Close();
            }
        }

        private void txtPriceFromSupplier_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtPriceFromSupplier.Text)) {
                this.txtPriceFromSupplier.Text = "0.00";
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

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            CapsLock();
            AutoGenNum();

            if (exist.IsCodeExist(this.txtCode.Text)) {
                this.txtCode.ResetText();
                AutoGenNum();
            }

            this.KeyPreview = true;
            this.txtDescription.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

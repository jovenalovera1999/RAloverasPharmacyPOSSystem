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
        }

        Components.Value val = new Components.Value();
        Functions.Product product = new Functions.Product();

        private void CapsLock()
        {
            this.txtCode.CharacterCasing = CharacterCasing.Upper;
            this.txtDescription.CharacterCasing = CharacterCasing.Upper;
            this.txtPackagingUnit.CharacterCasing = CharacterCasing.Upper;
            this.txtGeneric.CharacterCasing = CharacterCasing.Upper;
        }

        private void CalculateDiscount()
        {
            if (String.IsNullOrWhiteSpace(this.txtPrice.Text) && this.txtDiscount.Text == "0" || String.IsNullOrWhiteSpace(this.txtPrice.Text) ||
                this.txtDiscount.Text == "0")
            {
                this.txtDiscount.Text = "0";
                this.txtDiscounted.Text = "0";
            }
            else if (String.IsNullOrWhiteSpace(this.txtPrice.Text) && String.IsNullOrWhiteSpace(this.txtDiscount.Text) || String.IsNullOrWhiteSpace(this.txtPrice.Text) ||
                String.IsNullOrWhiteSpace(this.txtDiscount.Text))
            {
                this.txtDiscount.Text = "0";
                this.txtDiscounted.Text = "0";
            }
            else
            {
                double discount = double.Parse(this.txtPrice.Text) * (double.Parse(this.txtDiscount.Text) / 100);
                this.txtDiscounted.Text = (double.Parse(this.txtPrice.Text) - discount).ToString();
            }
        }

        private void SaveProduct()
        {
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
            else if (String.IsNullOrWhiteSpace(this.txtGeneric.Text))
            {
                MessageBox.Show("Generic is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtGeneric.Focus();
            }
            else
            {
                if (product.UpdateProduct(val.ProductId, this.txtDescription.Text, this.txtPackagingUnit.Text, int.Parse(this.txtQuantity.Text),
                    double.Parse(this.txtPrice.Text), double.Parse(this.txtDiscount.Text), double.Parse(this.txtDiscounted.Text), this.txtGeneric.Text))
                {
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

                    this.txtDiscount.Text = "0";
                    this.txtDiscounted.Text = "0";

                    this.txtDescription.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to save product!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmUpdateProduct_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

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

            CapsLock();
            this.KeyPreview = true;

            this.txtDescription.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

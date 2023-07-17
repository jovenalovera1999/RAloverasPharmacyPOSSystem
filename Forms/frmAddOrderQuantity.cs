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
    public partial class frmAddOrderQuantity : Form
    {
        public frmAddOrderQuantity()
        {
            InitializeComponent();
        }

        private void AddToCart()
        {
            if(String.IsNullOrWhiteSpace(this.txtQuantity.Text))
            {
                MessageBox.Show("Quantity is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtQuantity.Focus();
            }
            else
            {
                Forms.frmAddOrder addOrder = (Forms.frmAddOrder)Application.OpenForms["frmAddOrder"];
                DataGridView gridAvailableProducts = (DataGridView)addOrder.Controls["gridAvailableProducts"];
                DataGridView gridCart = (DataGridView)addOrder.Controls["gridCart"];
                Guna.UI2.WinForms.Guna2TextBox txtTotalAmountToPay = (Guna.UI2.WinForms.Guna2TextBox)addOrder.Controls["txtTotalAmountToPay"];

                int n = gridCart.Rows.Add();
                gridCart.Rows[n].Cells[1].Value = gridAvailableProducts.SelectedCells[1].Value;
                gridCart.Rows[n].Cells[2].Value = gridAvailableProducts.SelectedCells[3].Value;

                double subTotal = 0;

                if (double.Parse(gridAvailableProducts.SelectedCells[8].Value.ToString()) == 0)
                {
                    gridCart.Rows[n].Cells[3].Value = gridAvailableProducts.SelectedCells[6].Value;
                    subTotal = double.Parse(gridAvailableProducts.SelectedCells[6].Value.ToString()) * int.Parse(this.txtQuantity.Text);
                }
                else
                {
                    gridCart.Rows[n].Cells[3].Value = gridAvailableProducts.SelectedCells[8].Value;
                    subTotal = double.Parse(gridAvailableProducts.SelectedCells[8].Value.ToString()) * int.Parse(this.txtQuantity.Text);
                }

                gridCart.Rows[n].Cells[4].Value = this.txtQuantity.Text;
                gridCart.Rows[n].Cells[5].Value = subTotal.ToString("0.00");

                double totalAmountToPay = 0;

                for (int i = 0; i < gridCart.Rows.Count; i++)
                {
                    totalAmountToPay += double.Parse(gridCart.Rows[i].Cells[5].Value.ToString());
                }

                txtTotalAmountToPay.Text = totalAmountToPay.ToString("0.00");

                gridCart.ClearSelection();

                this.Close();
            }
        }

        private void frmAddOrderQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                AddToCart();
            }
            else if(e.KeyCode == Keys.F2)
            {
                this.Close();
            }
        }

        private void frmAddOrderQuantity_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.txtQuantity.Focus();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

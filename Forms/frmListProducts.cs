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
            Forms.frmAddProduct addProduct = new Forms.frmAddProduct();
            addProduct.ShowDialog();
        }

        private void frmListProducts_VisibleChanged(object sender, EventArgs e)
        {
            this.gridProducts.ClearSelection();
        }

        private void frmListProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
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
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            product.LoadProducts(this.gridProducts);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenAddProductForm();
        }
    }
}

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

        private void OpenAddProductForm()
        {
            Forms.frmAddProduct addProduct = new Forms.frmAddProduct();
            addProduct.ShowDialog();
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmListProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "F1")
            {
                OpenAddProductForm();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            OpenAddProductForm();
        }
    }
}

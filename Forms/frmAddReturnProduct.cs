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

        private void frmAddReturnProduct_Load(object sender, EventArgs e)
        {
            this.txtDescription.Focus();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtDescription.Text)) { 
            } else {
                product.SearchProduct(this.txtDescription.Text, this.gridReturnProducts);
            }
        }
    }
}

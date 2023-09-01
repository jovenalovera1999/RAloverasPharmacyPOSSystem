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

        private void frmAddReturnProduct_Load(object sender, EventArgs e)
        {
            this.txtDescription.Focus();

            if(String.IsNullOrWhiteSpace(this.txtDescription.Text)) {
                product.LoadReturnedProduct(this.gridReturnProducts);
                LoadReturnedProductsAction();
            } else {
                product.SearchProduct(this.txtDescription.Text, this.gridReturnProducts);
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtDescription.Text)) {
                product.LoadReturnedProduct(this.gridReturnProducts);

                lblMessageOne.Visible = false;
                lblMessageTwo.Visible = false;
                lblMessageThree.Visible = false;

                this.gridReturnProducts.Columns.RemoveAt(0);
                this.gridReturnProducts.Columns.RemoveAt(1);

                LoadReturnedProductsAction();
            } else {
                product.SearchProduct(this.txtDescription.Text, this.gridReturnProducts);

                lblMessageOne.Visible = true;
                lblMessageTwo.Visible = true;
                lblMessageThree.Visible = true;

                this.gridReturnProducts.Columns.RemoveAt(0);

                if(this.txtDescription.Text.Length == 1) {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.HeaderText = "";
                    btnDelete.Name = "btnDelete";
                    btnDelete.Text = "DELETE";
                    btnDelete.UseColumnTextForButtonValue = true;
                    this.gridReturnProducts.Columns.Insert(1, btnDelete);

                    for(int i = 0; i < this.gridReturnProducts.Columns.Count; i++) { 
                        this.gridReturnProducts.Columns.Remove("btnDelete");
                    }
                }

                DataGridViewButtonColumn btnSelect = new DataGridViewButtonColumn();
                btnSelect.HeaderText = "ACTION";
                btnSelect.Name = "btnSelect";
                btnSelect.Text = "SELECT";
                btnSelect.UseColumnTextForButtonValue = true;
                this.gridReturnProducts.Columns.Insert(0, btnSelect);
            }
        }
    }
}

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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void OpenOrderForm()
        {
            this.pnlMain.Controls.Clear();
            Forms.frmAddOrder addOrder = new Forms.frmAddOrder();
            addOrder.TopLevel = false;
            this.pnlMain.Controls.Add(addOrder);
            addOrder.Dock = DockStyle.Fill;
            addOrder.Show();

            this.Focus();
        }

        private void OpenPaymentForm()
        {
            this.pnlMain.Controls.Clear();
            Forms.frmPayment payment = new Forms.frmPayment();
            payment.TopLevel = false;
            this.pnlMain.Controls.Add(payment);
            payment.Dock = DockStyle.Fill;
            payment.Show();

            this.Focus();
        }

        private void OpenListProductsForm()
        {
            this.pnlMain.Controls.Clear();
            Forms.frmListProducts listProducts = new Forms.frmListProducts();
            listProducts.TopLevel = false;
            this.pnlMain.Controls.Add(listProducts);
            listProducts.Dock = DockStyle.Fill;
            listProducts.Show();

            this.Focus();
        }

        private void OpenListUsersForm()
        {
            this.pnlMain.Controls.Clear();
            Forms.frmListUsers listUsers = new Forms.frmListUsers();
            listUsers.TopLevel = false;
            this.pnlMain.Controls.Add(listUsers);
            listUsers.Dock = DockStyle.Fill;
            listUsers.Show();

            this.Focus();
        }

        private void LogoutUser()
        {
            if (MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Forms.frmLogin login = new Forms.frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void ExitApplication()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                OpenOrderForm();
            }
            else if(e.KeyCode == Keys.F6)
            {
                OpenPaymentForm();
            }
            else if(e.KeyCode == Keys.F7)
            {
                OpenListProductsForm();
            }
            else if(e.KeyCode == Keys.F8)
            {
                OpenListUsersForm();
            }
            else if(e.KeyCode == Keys.F12)
            {
                LogoutUser();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                ExitApplication();
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenOrderForm();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenPaymentForm();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenListProductsForm();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenListUsersForm();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
    }
}

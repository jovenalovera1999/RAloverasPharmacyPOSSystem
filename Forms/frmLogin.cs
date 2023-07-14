using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace RAloverasPharmacyPOSSystem.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Components.Value val = new Components.Value();
        Functions.User user = new Functions.User();

        private void CapsLock()
        {
            this.txtUsername.CharacterCasing = CharacterCasing.Upper;
        }

        private void LoginUser()
        {
            if (String.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
            else
            {
                if (user.LoginUser(this.txtUsername.Text, this.txtPassword.Text))
                {
                    Forms.frmDashboard dashboard = new Forms.frmDashboard();
                    dashboard.Show();

                    MessageBox.Show("Welcome " + val.MyFullName + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and password do not match in record!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.txtUsername.ResetText();
                    this.txtPassword.ResetText();

                    this.txtUsername.Focus();
                }
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                LoginUser();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            CapsLock();
            this.txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

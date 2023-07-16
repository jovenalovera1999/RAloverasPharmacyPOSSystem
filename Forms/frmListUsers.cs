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
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        Functions.User user = new Functions.User();

        private void OpenAddUserForm()
        {
            this.gridUsers.ClearSelection();

            Forms.frmAddUser addUser = new Forms.frmAddUser();
            addUser.ShowDialog();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            user.LoadUsers(this.gridUsers);

            DataGridViewButtonColumn btnResetPassword = new DataGridViewButtonColumn();
            btnResetPassword.HeaderText = "ACTION";
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Text = "RESET PASSWORD";
            btnResetPassword.UseColumnTextForButtonValue = true;
            this.gridUsers.Columns.Insert(0, btnResetPassword);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "DELETE";
            btnDelete.UseColumnTextForButtonValue = true;
            this.gridUsers.Columns.Insert(1, btnDelete);

            this.Focus();
        }

        private void frmListUsers_VisibleChanged(object sender, EventArgs e)
        {
            this.gridUsers.ClearSelection();
        }

        private void frmListUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                OpenAddUserForm();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenAddUserForm();
        }
    }
}

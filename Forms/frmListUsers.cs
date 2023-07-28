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

        private void gridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.gridUsers.Columns[e.ColumnIndex].Name == "btnResetPassword")
            {
                if(MessageBox.Show("Are you sure do you want to reset the password of this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if(user.ResetPasswordUser(long.Parse(this.gridUsers.SelectedCells[2].Value.ToString())))
                    {
                        MessageBox.Show("User's password has been reset to default!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.LoadUsers(this.gridUsers);
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset the password of the user to default!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.gridUsers.ClearSelection();
            }
            else if(this.gridUsers.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if(MessageBox.Show("Are you sure you want to delete this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(user.DeleteUser(long.Parse(this.gridUsers.SelectedCells[2].Value.ToString())))
                    {
                        MessageBox.Show("User was successfully deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.LoadUsers(this.gridUsers);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.gridUsers.ClearSelection();
            }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            user.NextPage(this.gridUsers);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            user.PreviousPage(this.gridUsers);
        }
    }
}

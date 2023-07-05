using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RAloverasPharmacyPOSSystem.Forms
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        Functions.User user = new Functions.User();

        private void CapsLock()
        {
            this.txtFirstName.CharacterCasing = CharacterCasing.Upper;
            this.txtMiddleName.CharacterCasing = CharacterCasing.Upper;
            this.txtLastName.CharacterCasing = CharacterCasing.Upper;
            this.txtAddress.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            CapsLock();
            this.txtFirstName.Focus();
        }

        string imgLocation = string.Empty;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                this.picProfilePicture.ImageLocation = imgLocation;
            }

            this.txtFirstName.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            imgLocation = string.Empty;
            this.picProfilePicture.ImageLocation = null;
            this.picProfilePicture.Image = null;

            this.txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] profilePicture = null;

            if(!String.IsNullOrWhiteSpace(imgLocation))
            {
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profilePicture = br.ReadBytes((int)fs.Length);
            }

            if(user.InsertUser(profilePicture, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.txtAddress.Text, this.txtContactNumber.Text,
                txtEmail.Text, this.txtUsername.Text, this.txtPassword.Text))
            {
                MessageBox.Show("User successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                profilePicture = null;
                this.txtFirstName.ResetText();
                this.txtMiddleName.ResetText();
                this.txtLastName.ResetText();
                this.txtAddress.ResetText();
                this.txtContactNumber.ResetText();
                this.txtEmail.ResetText();
                this.txtUsername.ResetText();
                this.txtPassword.ResetText();
                this.txtConfirmPassword.ResetText();

                imgLocation = string.Empty;
                this.picProfilePicture.ImageLocation = null;
                this.picProfilePicture.Image = null;

                this.txtFirstName.Focus();
            }
            else
            {
                MessageBox.Show("Failed to save user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

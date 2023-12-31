﻿using System;
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
        Functions.Exist exist = new Functions.Exist();

        private void CapsLock()
        {
            this.txtFirstName.CharacterCasing = CharacterCasing.Upper;
            this.txtMiddleName.CharacterCasing = CharacterCasing.Upper;
            this.txtLastName.CharacterCasing = CharacterCasing.Upper;
            this.txtAddress.CharacterCasing = CharacterCasing.Upper;
            this.txtUsername.CharacterCasing = CharacterCasing.Upper;
        }

        private void SaveUser()
        {
            if (String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last name is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtContactNumber.Text) && String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Contact number or email is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtContactNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
            else if(exist.IsUsernameExist(this.txtUsername.Text))
            {
                MessageBox.Show("Username is already exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtUsername.ResetText();
                this.txtUsername.Focus();
            }
            else
            {
                byte[] profilePicture = null;

                if (!String.IsNullOrWhiteSpace(imgLocation))
                {
                    FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    profilePicture = br.ReadBytes((int)fs.Length);
                }

                if (user.InsertUser(profilePicture, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.txtAddress.Text, this.txtContactNumber.Text,
                    txtEmail.Text, this.txtUsername.Text, this.cmbUserLevel.Text))
                {
                    MessageBox.Show("User was successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Forms.frmListUsers listUsers = (Forms.frmListUsers)Application.OpenForms["frmListUsers"];
                    DataGridView gridUsers = (DataGridView)listUsers.Controls["gridUsers"];
                    user.LoadUsers(gridUsers);
                    gridUsers.ClearSelection();

                    profilePicture = null;
                    this.cmbUserLevel.Text = null;
                    this.txtFirstName.ResetText();
                    this.txtMiddleName.ResetText();
                    this.txtLastName.ResetText();
                    this.txtAddress.ResetText();
                    this.txtContactNumber.ResetText();
                    this.txtEmail.ResetText();
                    this.txtUsername.ResetText();

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
        }

        private void UploadPicture()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                this.picProfilePicture.ImageLocation = imgLocation;
            }

            this.txtFirstName.Focus();
        }

        private void RemovePicture()
        {
            imgLocation = string.Empty;
            this.picProfilePicture.ImageLocation = null;
            this.picProfilePicture.Image = null;

            this.txtFirstName.Focus();
        }

        private void frmAddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SaveUser();
            }
            else if(e.KeyCode == Keys.F2)
            {
                this.Close();
            }
            else if(e.KeyCode == Keys.F3)
            {
                UploadPicture();
            }
            else if(e.KeyCode == Keys.F4)
            {
                RemovePicture();
            }
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
            this.KeyPreview = true;

            user.LoadUserLevels(this.cmbUserLevel);

            this.txtFirstName.Focus();
        }

        string imgLocation = string.Empty;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadPicture();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemovePicture();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

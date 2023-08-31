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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        Components.Value val = new Components.Value();
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

        private void UpdateOn()
        {
            this.btnUpload.Visible = true;
            this.btnRemove.Visible = true;
            this.btnSave.Visible = true;

            this.btnUpdate.Visible = false;

            this.txtFirstName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtContactNumber.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;
            this.lblConfirmPassword.Visible = true;
            this.txtConfirmPassword.Visible = true;
            this.txtConfirmPassword.Enabled = true;

            this.txtFirstName.Focus();
        }

        private void SaveProcedure()
        {
            byte[] profilePicture = null;

            if (!String.IsNullOrWhiteSpace(imgLocation))
            {
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profilePicture = br.ReadBytes((int)fs.Length);
                val.MyProfilePicture = profilePicture;
            }

            if (user.UpdateUser(val.MyUserId, val.MyProfilePicture, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.txtAddress.Text,
                this.txtContactNumber.Text, txtEmail.Text, this.txtUsername.Text, this.txtPassword.Text))
            {
                MessageBox.Show("User was successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.LoginUser(this.txtUsername.Text, this.txtPassword.Text);

                this.txtConfirmPassword.ResetText();

                this.btnUpload.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;

                this.btnUpdate.Visible = true;

                this.txtFirstName.Enabled = false;
                this.txtMiddleName.Enabled = false;
                this.txtLastName.Enabled = false;
                this.txtAddress.Enabled = false;
                this.txtContactNumber.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtUsername.Enabled = false;
                this.txtPassword.Enabled = false;
                this.lblConfirmPassword.Visible = false;
                this.txtConfirmPassword.Visible = false;
                this.txtConfirmPassword.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save user!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            else if(String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtConfirmPassword.Text))
            {
                MessageBox.Show("Confirm password is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtConfirmPassword.Focus();
            }
            else if(this.txtPassword.Text != this.txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtPassword.ResetText();
                this.txtConfirmPassword.ResetText();

                this.txtPassword.Focus();
            }
            else if(exist.ProceedUpdateUserWithExistingUsername(val.MyUserId, this.txtUsername.Text))
            {
                SaveProcedure();
            }
            else if(exist.IsUsernameExist(this.txtUsername.Text))
            {
                MessageBox.Show("Username is already exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtUsername.ResetText();
                this.txtUsername.Focus();
            }
            else
            {
                SaveProcedure();
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
            val.MyProfilePicture = null;
            this.picProfilePicture.ImageLocation = null;
            this.picProfilePicture.Image = null;

            this.txtFirstName.Focus();
        }

        private void frmProfile_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.btnUpdate.Visible == true && this.btnSave.Visible == false && e.KeyCode == Keys.F1)
            {
                UpdateOn();
            }
            else if(this.btnUpdate.Visible == false && this.btnSave.Visible == true && e.KeyCode == Keys.F1)
            {
                SaveUser();
            }
            else if(e.KeyCode == Keys.F2)
            {
                user.LoginUser(val.MyUsername, val.MyPassword);
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

        private void frmProfile_Load(object sender, EventArgs e)
        {
            CapsLock();
            this.KeyPreview = true;

            if(val.MyProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.MyProfilePicture);
                this.picProfilePicture.Image = Image.FromStream(ms);
            }

            this.txtFirstName.Text = val.MyFirstName;
            this.txtMiddleName.Text = val.MyMiddleName;
            this.txtLastName.Text = val.MyLastName;
            this.txtAddress.Text = val.MyAddress;
            this.txtContactNumber.Text = val.MyContactNumber;
            this.txtEmail.Text = val.MyEmail;
            this.txtUsername.Text = val.MyUsername;
            this.txtPassword.Text = val.MyPassword;
            this.txtUserLevel.Text = val.MyUserLevel;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOn();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            user.LoginUser(val.MyUsername, val.MyPassword);
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

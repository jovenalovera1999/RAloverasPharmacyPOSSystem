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

        private void CapsLock()
        {
            this.txtUsername.CharacterCasing = CharacterCasing.Upper;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CapsLock();
            this.txtUsername.Focus();
        }
    }
}

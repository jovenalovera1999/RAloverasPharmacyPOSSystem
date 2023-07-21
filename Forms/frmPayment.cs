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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        Functions.Payment payment = new Functions.Payment();

        private void frmPayment_Load(object sender, EventArgs e)
        {
            payment.LoadUsersForPayment(this.gridForPaymentTransaction);
            payment.LoadCartsForPayment(long.Parse(this.gridForPaymentTransaction.SelectedCells[0].Value.ToString()), this.gridCart);
        }
    }
}

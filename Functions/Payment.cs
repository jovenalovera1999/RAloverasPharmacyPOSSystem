using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace RAloverasPharmacyPOSSystem.Functions
{
    class Payment
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        public void LoadUsersForPayment(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"loadUsersForPayment();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["userForPaymentId"].Visible = false;
                        grid.Columns["CONCAT(u.lastName, ', ', u.firstName, ' ', u.middleName)"].HeaderText = "FULL NAME";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading users for payment from database: " + ex.ToString());
            }
        }

        public void LoadCartsForPayment(long userForPaymentId, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL loadCartsForPayment(@userForPaymentId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["cartId"].Visible = false;
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["price"].HeaderText = "PRICE";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["subTotal"].HeaderText = "SUB TOTAL";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading carts for payment from database: " + ex.ToString());
            }
        }
    }
}

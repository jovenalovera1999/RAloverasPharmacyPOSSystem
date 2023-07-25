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
    class History
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        public void LoadSalesWithDateRange(DateTime from, DateTime to, DataGridView grid)
        {
            using (MySqlConnection connection = new MySqlConnection(con.conString()))
            {
                string sql = @"CALL loadSalesWithDateRange(@from, @to);";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to);

                    connection.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    dt.Clear();
                    da.Fill(dt);

                    grid.DataSource = dt;
                    grid.Columns["transactionId"].Visible = false;
                    grid.Columns["FORMAT(t.amountToPay, 2)"].HeaderText = "AMOUNT TO PAY";
                    grid.Columns["FORMAT(d.discount, 0)"].HeaderText = "DISCOUNT";
                    grid.Columns["FORMAT(t.discounted, 2)"].HeaderText = "DISCOUNTED";
                    grid.Columns["FORMAT(t.amount, 2)"].HeaderText = "AMOUNT";
                    grid.Columns["FORMAT(t.change, 2)"].HeaderText = "CHANGE";
                    grid.Columns["CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 2))"].HeaderText = "TRANSACTED BY";

                    connection.Close();
                }
            }
        }
    }
}

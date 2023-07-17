using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RAloverasPharmacyPOSSystem.Functions
{
    class Order
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        public bool ToPay(long productId, int quantity, double subTotal)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL insertUserForPayment(@userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", val.MyUserId);

                        connection.Open();

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"CALL getUserForPaymentIdDesc();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        val.UserForPaymentId = dt.Rows[0].Field<long>("userForPaymentId");
                    }

                    sql = @"CALL insertCart(@userForPaymentId, @productId, @quantity, @subTotal);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userForPaymentId", val.UserForPaymentId);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@subTotal", subTotal);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error inserting cart or to pay to database: " + ex.ToString());
                return false;
            }
        }
    }
}

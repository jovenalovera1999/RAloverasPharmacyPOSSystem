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

        public bool InsertUserForPayment(long userId, double discount)
        {
            try
            {
                bool isDiscountExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL getDiscountId(@discount);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@discount", discount);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            isDiscountExist = true;
                            val.DiscountId = dt.Rows[0].Field<long>("discountId");
                        }
                    }

                    if(isDiscountExist == false)
                    {
                        sql = @"CALL insertDiscount(@discount);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@discount", discount);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getDiscountId(@discount);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@discount", discount);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                isDiscountExist = true;
                                val.DiscountId = dt.Rows[0].Field<long>("discountId");
                            }
                        }
                    }
                    
                    sql = @"CALL insertUserForPayment(@userId, @discountId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@discountId", val.DiscountId);

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

                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error inserting user for payment to database: " + ex.ToString());
                return false;
            }
        }

        public bool ToPay(long userForPaymentId, long productId, int quantity, double subTotal)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL insertCart(@userForPaymentId, @productId, @quantity, @subTotal);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);
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

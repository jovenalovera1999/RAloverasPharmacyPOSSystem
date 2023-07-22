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
                        grid.Columns["FORMAT(c.subTotal, 2)"].HeaderText = "SUB TOTAL";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading carts for payment from database: " + ex.ToString());
            }
        }

        public bool InsertTransaction(double totalAmountToPay, double discount, double discounted, double amount, double change)
        {
            try
            {
                bool isDiscountExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL getDiscountId(@discount);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@discount", discount);

                        connection.Open();

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

                    sql = @"CALL insertTransaction(@totalAmountToPay, @discountId, @discounted, @amount, @change);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@totalAmountToPay", totalAmountToPay);
                        cmd.Parameters.AddWithValue("@discountId", val.DiscountId);
                        cmd.Parameters.AddWithValue("@discounted", discounted);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@change", change);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                    }
                    
                    sql = @"CALL getTransactionIdDesc();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        val.TransactionId = dt.Rows[0].Field<long>("transactionId");

                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error inserting transaction to database and fetch transaction id in descending order limit to 1: " + ex.ToString());
                return false;
            }
        }

        public bool InsertTransactionIdToCarts(long cartId, long transactionId, long userForPaymentId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL insertTransactionIdToCarts(@cartId, @transactionId, @userForPaymentId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);

                        connection.Open();

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error inserting transaction id to carts in database: " + ex.ToString());
                return false;
            }
        }
    }
}

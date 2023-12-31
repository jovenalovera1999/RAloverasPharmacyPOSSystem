﻿using System;
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

        public void LoadUsersForPayment(DataGridView grid) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"loadUsersForPayment();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["userForPaymentId"].Visible = false;
                        grid.Columns["CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END"].HeaderText = "CLERK";
                        grid.Columns["FORMAT(d.discount, 2)"].HeaderText = "DISCOUNT";
                        grid.Columns["FORMAT(ufp.amount, 2)"].HeaderText = "AMOUNT";

                        connection.Close();
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error loading users for payment from database: " + ex.ToString());
            }
        }

        public void LoadCartsForPaymentWithFilter(long userForPaymentId, DataGridView grid) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL loadCartsForPaymentWithFilter(@userForPaymentId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["cartId"].Visible = false;
                        grid.Columns["productId"].Visible = false;
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["CASE WHEN dis.discount = 0 THEN FORMAT(p.price, 2) ELSE FORMAT(p.discounted, 2) END"].HeaderText = "PRICE";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(c.subTotal, 2)"].HeaderText = "SUB TOTAL";

                        connection.Close();
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error loading carts for payment from database: " + ex.ToString());
            }
        }

        public void LoadCartsForPaymentWithoutFilter(DataGridView grid) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL loadCartsForPaymentWithoutFilter();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.Columns["cartId"].Visible = false;
                        grid.Columns["productId"].Visible = false;
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["price"].HeaderText = "PRICE";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(c.subTotal, 2)"].HeaderText = "SUB TOTAL";

                        connection.Close();
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error loading carts for payment from database: " + ex.ToString());
            }
        }

        public bool InsertTransaction(string transactionNo, double totalAmountToPay, double discount, double discounted, double amount, double change,
            long userId) {
            try {
                bool isDiscountExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL getDiscountId(@discount);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@discount", discount);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) {
                            isDiscountExist = true;
                            val.DiscountId = dt.Rows[0].Field<long>("discountId");
                        }
                    }

                    if(!isDiscountExist) {
                        sql = @"CALL insertDiscount(@discount);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                            cmd.Parameters.AddWithValue("@discount", discount);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getDiscountId(@discount);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                            cmd.Parameters.AddWithValue("@discount", discount);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) {
                                isDiscountExist = true;
                                val.DiscountId = dt.Rows[0].Field<long>("discountId");
                            }
                        }
                    }

                    sql = @"CALL insertTransaction(@transactionNo, @totalAmountToPay, @discountId, @discounted, @amount, @change, @userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@transactionNo", transactionNo);
                        cmd.Parameters.AddWithValue("@totalAmountToPay", totalAmountToPay);
                        cmd.Parameters.AddWithValue("@discountId", val.DiscountId);
                        cmd.Parameters.AddWithValue("@discounted", discounted);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@change", change);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                    }
                    
                    sql = @"CALL getTransactionIdDesc();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        val.TransactionId = dt.Rows[0].Field<long>("transactionId");

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error inserting transaction to database and fetch transaction id in descending order limit to 1: " + ex.ToString());
                return false;
            }
        }

        public bool InsertTransactionIdToCarts(long cartId, long transactionId, long userForPaymentId) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL insertTransactionIdToCarts(@cartId, @transactionId, @userForPaymentId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error inserting transaction id to carts in database: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateDiscountIdAndAmountAfterPaymentTransaction(long userForPaymentId, double discount, double amount) {
            try {
                bool isDiscountExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL getDiscountId(@discount);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@discount", discount);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) {
                            isDiscountExist = true;
                            val.DiscountId = dt.Rows[0].Field<long>("discountId");
                        }
                    }

                    if (!isDiscountExist) {
                        sql = @"CALL insertDiscount(@discount);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                            cmd.Parameters.AddWithValue("@discount", discount);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getDiscountId(@discount);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                            cmd.Parameters.AddWithValue("@discount", discount);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) {
                                isDiscountExist = true;
                                val.DiscountId = dt.Rows[0].Field<long>("discountId");
                            }
                        }
                    }

                    sql = @"CALL updateDiscountIdAndAmountAfterPaymentTransaction(@userForPaymentId, @discountId, @amount);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);
                        cmd.Parameters.AddWithValue("@discountId", val.DiscountId);
                        cmd.Parameters.AddWithValue("@amount", amount);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error updating discount id after payment transaction in database: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateUserForPaymentToCancelled(long userForPaymentId) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL updateUserForPaymentToCancelled(@userForPaymentId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@userForPaymentId", userForPaymentId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error updating user for payment to cancelled in database: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateProductQuantityWhenCancelled(long productId, int quantity, long cartId) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL updateProductQuantityWhenCancelled(@productId, @quantity, @cartId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {

                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@cartId", cartId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error updating product quanity when cancelled in database: " + ex.ToString());
                return false;
            }
        }
    }
}

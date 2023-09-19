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
    class Sale
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        MySqlDataAdapter da;
        DataTable dt;
        int scollVal = 0;
        int totalRows = 0;
        int maxRecords = 25;

        public void LoadSalesWithDateRange(DateTime from, DateTime to, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL loadSalesWithDateRange(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();

                        dt.Clear();
                        totalRows = da.Fill(dt);

                        dt.Clear();
                        da.Fill(scollVal, maxRecords, dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["transactionId"].Visible = false;
                        grid.Columns["transactionNo"].HeaderText = "TRANSACTION NO.";
                        grid.Columns["FORMAT(t.totalAmountToPay, 2)"].HeaderText = "AMOUNT TO PAY";
                        grid.Columns["FORMAT(d.discount, 2)"].HeaderText = "DISCOUNT";
                        grid.Columns["FORMAT(t.discounted, 2)"].HeaderText = "DISCOUNTED";
                        grid.Columns["FORMAT(t.amount, 2)"].HeaderText = "AMOUNT";
                        grid.Columns["FORMAT(t.change, 2)"].HeaderText = "CHANGE";
                        grid.Columns["CASE WHEN middleName IS NULL OR middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END"].HeaderText = "TRANSACTED BY";
                        grid.Columns["dateCreated"].HeaderText = "DATE TRANSACTED";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading sales with date range from database: " + ex.ToString());
            }
        }

        public void NextPage(DataGridView grid)
        {
            scollVal += maxRecords;

            if(scollVal >= totalRows)
            {
                scollVal = totalRows;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.ClearSelection();
        }

        public void PreviousPage(DataGridView grid)
        {
            scollVal -= maxRecords;

            if(scollVal <= 0)
            {
                scollVal = 0;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.ClearSelection();
        }

        public void SumTotalSalesWithDateRange(DateTime from, DateTime to, Label lbl)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL sumTotalSalesWithDateRange(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        lbl.Text = cmd.ExecuteScalar().ToString();

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error calculating sales with date range from database: " + ex.ToString());
            }
        }

        public void CountTransactionsWithDateRange(DateTime from, DateTime to, Label lbl)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL countTransactionsWithDateRange(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        lbl.Text = cmd.ExecuteScalar().ToString();

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting transactions with date range from database: " + ex.ToString());
            }
        }

        public void CountItemsReturnedWithDateRange(DateTime from, DateTime to, Label lbl)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL countItemsReturnedWithDateRange(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        lbl.Text = cmd.ExecuteScalar().ToString();

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting items returned with date range from database: " + ex.ToString());
            }
        }

        public void SumTotalAmountReturnedWithDateRange(DateTime from, DateTime to, Label lbl)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL sumTotalAmountReturnedWithDateRange(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        lbl.Text = cmd.ExecuteScalar().ToString();

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting items returned with date range from database: " + ex.ToString());
            }
        }

        public void LoadSalesCart(long transactionId, DataGridView grid)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL loadSalesCart(@transactionId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["cartId"].Visible = false;
                        grid.Columns["productId"].Visible = false;
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["CASE WHEN dis.discount = 0 THEN FORMAT(p.price, 2) ELSE FORMAT(p.discounted, 2) END"].HeaderText = "PRICE";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(c.subTotal, 2)"].HeaderText = "SUB TOTAL";
                        grid.Columns["CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END"].HeaderText = "CLERK";
                        grid.Columns["dateCreated"].HeaderText = "DATE CREATED";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading sales cart from database: " + ex.ToString());
            }
        }

        public bool GetTransaction(long transactionId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL getTransactionId(@transactionId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            val.TransactionId = dt.Rows[0].Field<long>("transactionId");

                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error getting transaction from database: " + ex.ToString());
                return false;
            }
        }
    }
}

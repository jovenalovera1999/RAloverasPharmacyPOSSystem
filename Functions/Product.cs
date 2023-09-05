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
    class Product
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        MySqlDataAdapter da;
        DataTable dt;
        int scollVal = 0;
        int totalRows = 0;
        int maxRecords = 25;

        public void LoadProducts(DataGridView grid) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL loadProducts();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();

                        dt.Clear();
                        totalRows = da.Fill(dt);

                        dt.Clear();
                        da.Fill(scollVal, maxRecords, dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["productId"].Visible = false;
                        grid.Columns["code"].HeaderText = "CODE";
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["packagingUnitName"].HeaderText = "PACKAGING UNIT";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(p.price, 2)"].HeaderText = "PRICE";
                        grid.Columns["discount"].HeaderText = "DISCOUNT";
                        grid.Columns["FORMAT(p.discounted, 2)"].HeaderText = "DISCOUNTED";
                        grid.Columns["genericName"].HeaderText = "GENERIC";
                        grid.Columns["supplier"].HeaderText = "SUPPLIER";
                        grid.Columns["FORMAT(p.priceFromSupplier, 2)"].HeaderText = "PRICE FROM SUPPLIER";
                        grid.Columns["CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END"].HeaderText = "ADDED BY";
                        grid.Columns["dateCreated"].HeaderText = "DATE CREATED";
                        grid.Columns["dateUpdated"].HeaderText = "DATE UPDATED";

                        connection.Close();
                    }
                }
            } 
            catch(Exception ex) 
            {
                Console.WriteLine("Error loading products from database: " + ex.ToString());
            }
        }

        public void LoadProductsInOrder(DataGridView grid) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL loadProducts();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();

                        dt.Clear();
                        totalRows = da.Fill(dt);

                        dt.Clear();
                        da.Fill(scollVal, maxRecords, dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["productId"].Visible = false;
                        grid.Columns["code"].HeaderText = "CODE";
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["packagingUnitName"].HeaderText = "PACKAGING UNIT";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(p.price, 2)"].HeaderText = "PRICE";
                        grid.Columns["discount"].HeaderText = "DISCOUNT";
                        grid.Columns["FORMAT(p.discounted, 2)"].HeaderText = "DISCOUNTED";
                        grid.Columns["genericName"].HeaderText = "GENERIC";
                        grid.Columns["supplier"].Visible = false;
                        grid.Columns["FORMAT(p.priceFromSupplier, 2)"].Visible = false;
                        grid.Columns["CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END"].Visible = false;
                        grid.Columns["dateCreated"].HeaderText = "DATE CREATED";
                        grid.Columns["dateUpdated"].HeaderText = "DATE UPDATED";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error loading products in order from database: " + ex.ToString());
            }
        }

        public void LoadReturnedProducts(DataGridView grid) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL loadReturnedProducts();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();

                        dt.Clear();
                        totalRows = da.Fill(dt);

                        dt.Clear();
                        da.Fill(scollVal, maxRecords, dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["returnProductId"].Visible = false;
                        grid.Columns["productId"].Visible = false;
                        grid.Columns["code"].HeaderText = "CODE";
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(rp.amountReturned, 2)"].HeaderText = "AMOUNT RETURNED";
                        grid.Columns["dateCreated"].HeaderText = "DATE CREATED";
                        grid.Columns["dateUpdated"].HeaderText = "DATE UPDATED";

                        connection.Close();
                    }
                }
            } 
            catch(Exception ex) 
            {
                Console.WriteLine("Error loading return products from database: " + ex.ToString());
            }
        }

        public void SearchProduct(string keyword, DataGridView grid)
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL searchProduct(@keyword);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@keyword", string.Format("%{0}%", keyword));

                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();

                        dt.Clear();
                        totalRows = da.Fill(dt);

                        dt.Clear();
                        da.Fill(scollVal, maxRecords, dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["productId"].Visible = false;
                        grid.Columns["code"].HeaderText = "CODE";
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["packagingUnitName"].HeaderText = "PACKAGING UNIT";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(p.price, 2)"].HeaderText = "PRICE";
                        grid.Columns["discount"].HeaderText = "DISCOUNT";
                        grid.Columns["FORMAT(p.discounted, 2)"].HeaderText = "DISCOUNTED";
                        grid.Columns["genericName"].HeaderText = "GENERIC";
                        grid.Columns["supplier"].HeaderText = "SUPPLIER";
                        grid.Columns["FORMAT(p.priceFromSupplier, 2)"].HeaderText = "PRICE FROM SUPPLIER";
                        grid.Columns["CASE WHEN u.middleName IS NULL OR u.middleName = '' THEN CONCAT(u.lastName, ', ', u.firstName) ELSE CONCAT(u.lastName, ', ', u.firstName, ' ', LEFT(u.middleName, 1), '.') END"].HeaderText = "ADDED BY";
                        grid.Columns["dateCreated"].HeaderText = "DATE CREATED";
                        grid.Columns["dateUpdated"].HeaderText = "DATE UPDATED";

                        connection.Close();
                    }
                }
            } 
            catch(Exception ex) 
            {
                Console.WriteLine("Error searching product from database: " + ex.ToString());
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

            if (scollVal <= 0) 
            {
                scollVal = 0;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.ClearSelection();
        }

        public void NextPageAtOrder(DataGridView grid) 
        {
            scollVal += maxRecords;

            if (scollVal >= totalRows) 
            {
                scollVal = totalRows;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.Focus();
        }

        public void PreviousPageAtOrder(DataGridView grid) 
        {
            scollVal -= maxRecords;

            if (scollVal <= 0) 
            {
                scollVal = 0;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.Focus();
        }

        public bool GetProduct(long productId) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL getProduct(@productId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) 
                        {
                            val.ProductId = dt.Rows[0].Field<long>("productId");
                            val.ProductCode = dt.Rows[0].Field<string>("code");
                            val.ProductDescription = dt.Rows[0].Field<string>("description");
                            val.ProductPackagingUnit = dt.Rows[0].Field<string>("packagingUnitName");
                            val.ProductQuantity = dt.Rows[0].Field<int>("quantity");
                            val.ProductPrice = dt.Rows[0].Field<double>("price");
                            val.ProductDiscount = dt.Rows[0].Field<double>("discount");
                            val.ProductDiscounted = dt.Rows[0].Field<double>("discounted");
                            val.ProductGeneric = dt.Rows[0].Field<string>("genericName");
                            val.ProductSupplier = dt.Rows[0].Field<string>("supplier");
                            val.ProductPriceFromSupplier = dt.Rows[0].Field<double>("priceFromSupplier");

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
                Console.WriteLine("Error getting product from database: " + ex.ToString());
                return false;
            }
        }

        public bool GetReturnedProduct(long returnProductId) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL getReturnedProduct(@returnProductId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@returnProductId", returnProductId);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) 
                        {
                            val.ReturnProductId = dt.Rows[0].Field<long>("returnProductId");
                            val.ProductId = dt.Rows[0].Field<long>("productId");
                            val.ReturnProductDescription = dt.Rows[0].Field<string>("description");
                            val.ReturnProductQuantity = dt.Rows[0].Field<int>("quantity");
                            val.ReturnProductAmountReturned = dt.Rows[0].Field<double>("amountReturned");

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
                Console.WriteLine("Error getting return product from database: " + ex.ToString());
                return false;
            }
        }

        public bool InsertProduct(string code, string description, string packagingUnit, int quantity, double price, double discount,
            double discounted, string generic, string supplier, double priceFromSupplier, long userId)
        {
            try 
            {
                bool isDescriptionExist = false;
                bool isPackagingUnitExist = false;
                bool isDiscountExist = false;
                bool isGenericExist = false;
                bool isSupplierExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL getDescriptionId(@description);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@description", description);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) 
                        {
                            isDescriptionExist = true;
                            val.DescriptionId = dt.Rows[0].Field<long>("descriptionId");
                        }
                    }

                    if(!isDescriptionExist) 
                    {
                        sql = @"CALL insertDescription(@description);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@description", description);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getDescriptionId(@description);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@description", description);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isDescriptionExist = true;
                                val.DescriptionId = dt.Rows[0].Field<long>("descriptionId");
                            }
                        }
                    }

                    sql = @"CALL getPackagingUnitId(@packagingUnit);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) 
                        {
                            isPackagingUnitExist = true;
                            val.PackagingUnitId = dt.Rows[0].Field<long>("packagingUnitId");
                        }
                    }

                    if(!isPackagingUnitExist) 
                    {
                        sql = @"CALL insertPackagingUnit(@packagingUnit);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getPackagingUnitId(@packagingUnit);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) {
                                isPackagingUnitExist = true;
                                val.PackagingUnitId = dt.Rows[0].Field<long>("packagingUnitId");
                            }
                        }
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

                    if(!isDiscountExist) 
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

                    sql = @"CALL getGenericId(@generic);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@generic", generic);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0) 
                        {
                            isGenericExist = true;
                            val.GenericId = dt.Rows[0].Field<long>("genericId");
                        }
                    }

                    if(!isGenericExist) 
                    {
                        sql = @"CALL insertGeneric(@generic);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@generic", generic);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getGenericId(@generic);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@generic", generic);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isGenericExist = true;
                                val.GenericId = dt.Rows[0].Field<long>("genericId");
                            }
                        }
                    }

                    sql = @"CALL getSupplierId(@supplier);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@supplier", supplier);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) 
                        {
                            isSupplierExist = true;
                            val.SupplierId = dt.Rows[0].Field<long>("supplierId");
                        }
                    }

                    if(!isSupplierExist) 
                    {
                        sql = @"CALL insertSupplier(@supplier);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@supplier", supplier);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getSupplierId(@supplier);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@supplier", supplier);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isSupplierExist = true;
                                val.SupplierId = dt.Rows[0].Field<long>("supplierId");
                            }
                        }
                    }
                    
                    sql = @"CALL insertProduct(@code, @descriptionId, @packagingUnitId, @quantity, @price, @discount, @discounted, @genericId,
                            @supplierId, @priceFromSupplier, @userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@descriptionId", val.DescriptionId);
                        cmd.Parameters.AddWithValue("@packagingUnitId", val.PackagingUnitId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@discount", val.DiscountId);
                        cmd.Parameters.AddWithValue("@discounted", discounted);
                        cmd.Parameters.AddWithValue("@genericId", val.GenericId);
                        cmd.Parameters.AddWithValue("@supplierId", val.SupplierId);
                        cmd.Parameters.AddWithValue("@priceFromSupplier", priceFromSupplier);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("Error inserting product to database: " + ex.ToString());
                return false;
            }
        }

        public bool InsertReturnedProduct(long productId, int quantity, double amountReturned) 
        { 
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL insertReturnedProduct(@productId, @quantity, @amountReturned);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@amountReturned", amountReturned);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch(Exception ex) 
            {
                Console.WriteLine("Error inserting returned product to database: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateProduct(long productId, string description, string packagingUnit, int quantity, double price, double discount,
            double discounted, string generic, string supplier, double priceFromSupplier) 
        {
            try 
            {
                bool isDescriptionExist = false;
                bool isPackagingUnitExist = false;
                bool isDiscountExist = false;
                bool isGenericExist = false;
                bool isSupplierExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL getDescriptionId(@description);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@description", description);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0) 
                        {
                            isDescriptionExist = true;
                            val.DescriptionId = dt.Rows[0].Field<long>("descriptionId");
                        }
                    }

                    if (!isDescriptionExist) 
                    {
                        sql = @"CALL insertDescription(@description);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@description", description);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getDescriptionId(@description);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@description", description);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isDescriptionExist = true;
                                val.DescriptionId = dt.Rows[0].Field<long>("descriptionId");
                            }
                        }
                    }

                    sql = @"CALL getPackagingUnitId(@packagingUnit);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0) 
                        {
                            isPackagingUnitExist = true;
                            val.PackagingUnitId = dt.Rows[0].Field<long>("packagingUnitId");
                        }
                    }

                    if (!isPackagingUnitExist) 
                    {
                        sql = @"CALL insertPackagingUnit(@packagingUnit);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getPackagingUnitId(@packagingUnit);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isPackagingUnitExist = true;
                                val.PackagingUnitId = dt.Rows[0].Field<long>("packagingUnitId");
                            }
                        }
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

                    if (!isDiscountExist) 
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

                    sql = @"CALL getGenericId(@generic);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@generic", generic);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0) 
                        {
                            isGenericExist = true;
                            val.GenericId = dt.Rows[0].Field<long>("genericId");
                        }
                    }

                    if (!isGenericExist) 
                    {
                        sql = @"CALL insertGeneric(@generic);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@generic", generic);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getGenericId(@generic);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@generic", generic);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isGenericExist = true;
                                val.GenericId = dt.Rows[0].Field<long>("genericId");
                            }
                        }
                    }

                    sql = @"CALL getSupplierId(@supplier);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@supplier", supplier);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0) 
                        {
                            isSupplierExist = true;
                            val.SupplierId = dt.Rows[0].Field<long>("supplierId");
                        }
                    }

                    if (!isSupplierExist) 
                    {
                        sql = @"CALL insertSupplier(@supplier);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@supplier", supplier);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getSupplierId(@supplier);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@supplier", supplier);

                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            dt.Clear();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0) 
                            {
                                isSupplierExist = true;
                                val.SupplierId = dt.Rows[0].Field<long>("supplierId");
                            }
                        }
                    }

                    sql = @"CALL updateProduct(@productId, @descriptionId, @packagingUnitId, @quantity, @price, @discount, @discounted, @genericId,
                                @supplierId, @priceFromSupplier);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@descriptionId", val.DescriptionId);
                        cmd.Parameters.AddWithValue("@packagingUnitId", val.PackagingUnitId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@discount", val.DiscountId);
                        cmd.Parameters.AddWithValue("@discounted", discounted);
                        cmd.Parameters.AddWithValue("@genericId", val.GenericId);
                        cmd.Parameters.AddWithValue("@supplierId", val.SupplierId);
                        cmd.Parameters.AddWithValue("@priceFromSupplier", priceFromSupplier);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("Error updating product in database: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateProductQuantityWhenReturnedProduct(long productId, int quantity) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL updateProductQuantityWhenReturnedProduct(@productId, @quantity);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Error updating product quantity in database when returning product: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateReturnedProduct(long pPProductId, int pPQuantity, long returnProductId, long productId, int quantity, double amountReturned) 
        { 
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    connection.Open();

                    string sql = @"CALL updateReturnedProduct(@ppProductId, @ppQuantity, @returnProductId, @productId, @quantity, @amountReturned);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ppProductId", pPProductId);
                        cmd.Parameters.AddWithValue("@ppQuantity", pPQuantity);
                        cmd.Parameters.AddWithValue("@returnProductId", returnProductId);
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@amountReturned", amountReturned);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating return product in database: " + ex.ToString());
                return false;
            }
        }

        public bool DeleteProduct(long productId)
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL deleteProduct(@productId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Error deleting product in database: " + ex.ToString());
                return false;
            }
        }

        public bool DeleteReturnedProduct(long returnProductId) 
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) 
                {
                    connection.Open();

                    string sql = @"CALL deleteReturnedProduct(@returnProductId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@returnProductId", returnProductId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch(Exception ex) 
            {
                Console.WriteLine("Error deleting returned product in database: " + ex.ToString());
                return false;
            }
        }

        public bool DeductProduct(long productId, int quantity)
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL deductProductQuantity(@productId, @quantity);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Error deducting product in database: " + ex.ToString());
                return false;
            }
        }
    }
}

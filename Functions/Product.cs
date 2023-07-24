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

        public void LoadProducts(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL loadProducts();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["productId"].Visible = false;
                        grid.Columns["code"].HeaderText = "CODE";
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["packagingUnitName"].HeaderText = "PACKAGING UNIT";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(p.price, 2)"].HeaderText = "PRICE";
                        grid.Columns["CONCAT(dis.discount, '%')"].HeaderText = "DISCOUNT (PERCENTAGE)";
                        grid.Columns["FORMAT(p.discounted, 2)"].HeaderText = "DISCOUNTED";
                        grid.Columns["genericName"].HeaderText = "GENERIC";
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

        public void SearchProduct(string keyword, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL searchProduct(@keyword);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@keyword", string.Format("%{0}%", keyword));

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["productId"].Visible = false;
                        grid.Columns["code"].HeaderText = "CODE";
                        grid.Columns["description"].HeaderText = "DESCRIPTION";
                        grid.Columns["packagingUnitName"].HeaderText = "PACKAGING UNIT";
                        grid.Columns["quantity"].HeaderText = "QUANTITY";
                        grid.Columns["FORMAT(p.price, 2)"].HeaderText = "PRICE";
                        grid.Columns["CONCAT(dis.discount, '%')"].HeaderText = "DISCOUNT (PERCENTAGE)";
                        grid.Columns["FORMAT(p.discounted, 2)"].HeaderText = "DISCOUNTED";
                        grid.Columns["genericName"].HeaderText = "GENERIC";
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

        public bool GetProduct(long productId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL getProduct(@productId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);

                        connection.Open();

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

        public bool InsertProduct(string code, string description, string packagingUnit, int quantity, double price, double discount, double discounted, string generic)
        {
            try
            {
                bool isDescriptionExist = false;
                bool isPackagingUnitExist = false;
                bool isDiscountExist = false;
                bool isGenericExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL getDescriptionId(@description);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();

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

                    if(isDescriptionExist == false)
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

                    if(isPackagingUnitExist == false)
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

                    if(isGenericExist == false)
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

                    sql = @"CALL insertProduct(@code, @descriptionId, @packagingUnitId, @quantity, @price, @discount, @discounted, @genericId);";

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

        public bool UpdateProduct(long productId, string description, string packagingUnit, int quantity, double price, double discount,
            double discounted, string generic)
        {
            try
            {
                bool isDescriptionExist = false;
                bool isPackagingUnitExist = false;
                bool isDiscountExist = false;
                bool isGenericExist = false;

                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL getDescriptionId(@description);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();

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

                    if (isDescriptionExist == false)
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

                    if (isPackagingUnitExist == false)
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

                    if (isDiscountExist == false)
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

                    if (isGenericExist == false)
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

                    sql = @"CALL updateProduct(@productId, @descriptionId, @packagingUnitId, @quantity, @price, @discount, @discounted, @genericId);";

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

        public bool DeleteProduct(long productId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL deleteProduct(@productId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);

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
                Console.WriteLine("Error deleting product in database: " + ex.ToString());
                return false;
            }
        }

        public bool DeductProduct(long productId, int quantity)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL deductProductQuantity(@productId, @quantity);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

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
                Console.WriteLine("Error deducting product in database: " + ex.ToString());
                return false;
            }
        }
    }
}

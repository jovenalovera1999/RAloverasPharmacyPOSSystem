using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RAloverasPharmacyPOSSystem.Functions
{
    class Product
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        public bool AddProduct(string code, string description, string packagingUnit, int quantity, double price, double discount, double discounted, string generic)
        {
            try
            {
                bool isDescriptionExist = false;
                bool isPackagingUnitExist = false;
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
                        else
                        {
                            connection.Close();
                            return false;
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
                            else
                            {
                                connection.Close();
                                return false;
                            }
                        }
                    }

                    sql = @"CALL getPackaingUnitId(@packagingUnit);";

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
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }

                    if(isPackagingUnitExist == false)
                    {
                        sql = @"CALL insertPackagingUnit(@packingUnit);";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@packagingUnit", packagingUnit);

                            MySqlDataReader dr = cmd.ExecuteReader();
                            dr.Close();
                        }

                        sql = @"CALL getPackaingUnitId(@packagingUnit);";

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
                            else
                            {
                                connection.Close();
                                return false;
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
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }

                    if(isGenericExist == false)
                    {
                        sql = @"CALL insertGeneric(@packingUnit);";

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
                            else
                            {
                                connection.Close();
                                return false;
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
                        cmd.Parameters.AddWithValue("@discount", discount);
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
    }
}

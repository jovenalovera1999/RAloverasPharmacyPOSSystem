using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RAloverasPharmacyPOSSystem.Functions
{
    class User
    {
        Components.Connection con = new Components.Connection();
        Components.Values val = new Components.Values();

        public bool LoginUser(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL loginUser(@username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0)
                        {
                            val.MyId = dt.Rows[0].Field<long>("userId");
                            val.MyFirstName = dt.Rows[0].Field<string>("firstName");
                            val.MyMiddleName = dt.Rows[0].Field<string>("middleName");
                            val.MyLastName = dt.Rows[0].Field<string>("lastName");
                            val.MyAddress = dt.Rows[0].Field<string>("address");
                            val.MyContactNumber = dt.Rows[0].Field<string>("contactNumber");
                            val.MyEmail = dt.Rows[0].Field<string>("email");
                            val.MyUsername = dt.Rows[0].Field<string>("username");
                            val.MyPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(`password`, \"J.v3n!j.$hu4c.@l0ver4!#@\") AS CHAR)");

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
                Console.WriteLine("Error logging in user: " + ex.ToString());
                return false;
            }
        }

        public bool InsertUser(byte[] profilePicture, string firstName, string middleName, string lastName, string address, string contactNumber, string email,
            string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL insertUser(@profilePicture, @firstName, @middleName, @lastName, @address, @contactNumber, @email, @username, @password);";

                    using(MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@profilePicture", profilePicture);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@middleName", middleName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

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
                Console.WriteLine("Error inserting user to database: " + ex.ToString());
                return false;
            }
        }
    }
}

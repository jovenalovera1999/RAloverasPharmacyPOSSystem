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
    class User
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

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
                            val.MyUserId = dt.Rows[0].Field<long>("userId");
                            val.MyProfilePicture = dt.Rows[0].Field<byte[]>("profilePicture");
                            val.MyFirstName = dt.Rows[0].Field<string>("firstName");
                            val.MyMiddleName = dt.Rows[0].Field<string>("middleName");
                            val.MyLastName = dt.Rows[0].Field<string>("lastName");
                            val.MyAddress = dt.Rows[0].Field<string>("address");
                            val.MyContactNumber = dt.Rows[0].Field<string>("contactNumber");
                            val.MyEmail = dt.Rows[0].Field<string>("email");
                            val.MyUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(username, \"J.v3n!j.$hu4c.@l0ver4!#@\") AS CHAR)");
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

        public bool ResetPasswordUser(long userId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL resetUserPassword(@userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

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
                Console.WriteLine("Error reseting the password of the user from database: " + ex.ToString());
                return false;
            }
        }

        public void LoadUsers(DataGridView grid)
        {
            using (MySqlConnection connection = new MySqlConnection(con.conString()))
            {
                string sql = @"CALL loadUsers();";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    dt.Clear();
                    da.Fill(dt);

                    grid.DataSource = dt;

                    grid.Columns["userId"].Visible = false;
                    grid.Columns["CONCAT(lastName, ', ', firstName, ' ', LEFT(middleName, 1))"].HeaderText = "FULL NAME";
                    grid.Columns["address"].HeaderText = "ADDRESS";
                    grid.Columns["contactNumber"].HeaderText = "CONTACT NUMBER";
                    grid.Columns["email"].HeaderText = "EMAIL";
                    grid.Columns["CAST(AES_DECRYPT(username, \"J.v3n!j.$hu4c.@l0ver4!#@\") AS CHAR)"].HeaderText = "USERNAME";
                    grid.Columns["dateCreated"].HeaderText = "DATE CREATED";
                    grid.Columns["dateUpdated"].HeaderText = "DATE UPDATED";

                    connection.Close();
                }
            }
        }

        public bool InsertUser(byte[] profilePicture, string firstName, string middleName, string lastName, string address, string contactNumber, string email,
            string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL insertUser(@profilePicture, @firstName, @middleName, @lastName, @address, @contactNumber, @email, @username);";

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

        public bool UpdateUser(long userId, byte[] profilePicture, string firstName, string middleName, string lastName, string address, string contactNumber, string email,
            string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL updateUser(@userId, @profilePicture, @firstName, @middleName, @lastName, @address, @contactNumber, @email,
                                    @username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
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
                Console.WriteLine("Error updating user in database: " + ex.ToString());
                return false;
            }
        }

        public bool DeleteUser(long userId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL deleteUser(@userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

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
                Console.WriteLine("Error deleting user in database: " + ex.ToString());
                return false;
            }
        }
    }
}

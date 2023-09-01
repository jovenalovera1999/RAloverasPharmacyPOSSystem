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

        MySqlDataAdapter da;
        DataTable dt;
        int scollVal = 0;
        int totalRows = 0;
        int maxRecords = 25;

        public bool LoginUser(string username, string password) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL loginUser(@username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) {
                            val.MyUserId = dt.Rows[0].Field<long>("userId");
                            val.MyProfilePicture = dt.Rows[0].Field<byte[]>("profilePicture");
                            val.MyFirstName = dt.Rows[0].Field<string>("firstName");
                            val.MyMiddleName = dt.Rows[0].Field<string>("middleName");
                            val.MyLastName = dt.Rows[0].Field<string>("lastName");
                            val.MyAddress = dt.Rows[0].Field<string>("address");
                            val.MyContactNumber = dt.Rows[0].Field<string>("contactNumber");
                            val.MyEmail = dt.Rows[0].Field<string>("email");
                            val.MyUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(u.username, \"J.v3n!j.$hu4c.@l0ver4!#@\") AS CHAR)");
                            val.MyPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(u.password, \"J.v3n!j.$hu4c.@l0ver4!#@\") AS CHAR)");
                            val.MyUserLevel = dt.Rows[0].Field<string>("userLevel");

                            connection.Close();
                            return true;
                        } else {
                            connection.Close();
                            return false;
                        }
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error logging in user: " + ex.ToString());
                return false;
            }
        }

        public bool ResetPasswordUser(long userId) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL resetUserPassword(@userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error reseting the password of the user from database: " + ex.ToString());
                return false;
            }
        }

        public void LoadUserLevels(ComboBox cmb) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL loadUserLevels();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        MySqlDataReader dr = cmd.ExecuteReader();

                        while(dr.Read()) {
                            string userLevels = dr.GetString("userLevel");
                            cmb.Items.Add(userLevels);
                        }

                        dr.Close();
                        connection.Close();
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error loading user levels from database: " + ex.ToString());
            }
        }

        public void LoadUsers(DataGridView grid) {
            using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                connection.Open();

                string sql = @"CALL loadUsers();";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();

                    dt.Clear();
                    totalRows = da.Fill(dt);

                    dt.Clear();
                    da.Fill(scollVal, maxRecords, dt);

                    grid.DataSource = dt;
                    grid.ClearSelection();

                    grid.Columns["userId"].Visible = false;
                    grid.Columns["CASE WHEN middleName IS NULL OR middleName = '' THEN CONCAT(lastName, ', ', firstName) ELSE CONCAT(lastName, ', ', firstName, ' ', LEFT(middleName, 1), '.') END"].HeaderText = "FULL NAME";
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

        public void NextPage(DataGridView grid) {
            scollVal += maxRecords;

            if(scollVal >= totalRows) {
                scollVal = totalRows;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.ClearSelection();
        }

        public void PreviousPage(DataGridView grid) {
            scollVal -= maxRecords;

            if(scollVal <= 0) {
                scollVal = 0;
            }

            dt.Clear();
            da.Fill(scollVal, maxRecords, dt);

            grid.ClearSelection();
        }

        public bool InsertUser(byte[] profilePicture, string firstName, string middleName, string lastName, string address, string contactNumber, string email,
            string username, string userLevel) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL getUserLevel(@userLevel);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@userLevel", userLevel);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count > 0) {
                            val.UserLevelId = dt.Rows[0].Field<long>("userLevelId");
                        }
                    }
                    
                    sql = @"CALL insertUser(@profilePicture, @firstName, @middleName, @lastName, @address, @contactNumber, @email, @username, @userLevelId);";

                    using(MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@profilePicture", profilePicture);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@middleName", middleName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@userLevelId", val.UserLevelId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error inserting user to database: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateUser(long userId, byte[] profilePicture, string firstName, string middleName, string lastName, string address, string contactNumber, string email,
            string username, string password) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL updateUser(@userId, @profilePicture, @firstName, @middleName, @lastName, @address, @contactNumber, @email,
                                    @username, @password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
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

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error updating user in database: " + ex.ToString());
                return false;
            }
        }

        public bool DeleteUser(long userId) {
            try {
                using (MySqlConnection connection = new MySqlConnection(con.conString())) {
                    connection.Open();

                    string sql = @"CALL deleteUser(@userId);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection)) {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        MySqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();

                        connection.Close();

                        return true;
                    }
                }
            } catch(Exception ex) {
                Console.WriteLine("Error deleting user in database: " + ex.ToString());
                return false;
            }
        }
    }
}

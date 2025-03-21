using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
using System.Data.SqlClient;
using System.Configuration;

namespace EcommerceApplication
{
    public class UserController
    {
        // Getting connection string from Web.config
        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManagementSystemDB"].ConnectionString;


        public User GetAuthenticateUser(string username, string password)
        {
            // Establishing SQL connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    //Open the connection
                    conn.Open();

                    //Query
                    string query = "SELECT Username, Password, Role FROM Users WHERE Username = @Username AND Password = @Password";

                    // Create a command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query 
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            // Check if a record was found
                            if (reader.Read())
                            {
                                // Create a new User object with the data
                                User user = new User
                                (
                                    reader["Username"].ToString(),
                                    reader["Password"].ToString(),
                                    reader["Role"].ToString()
                                );

                                // Return the authenticated user
                                return user;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                }
            }

            return null;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
using System.Data.SqlClient;
using System.Configuration;

namespace EcommerceApplication
{
    public class employeeController
    {
        // Getting connection string from Web.config
        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManagementSystemDB"].ConnectionString;


        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            // Establishing SQL connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    //Open the connection
                    conn.Open();

                    //Query
                    string query = @"
                    SELECT e.EmployeeID, u.Username, u.Role, e.Department, e.ContactNumber, e.Qualifications
                    FROM Employees e
                    JOIN Users u ON e.UserID = u.id";

                    // Create a command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the query 
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            // Iterate through the result set
                            while (reader.Read())
                            {
                                Employee employee = new Employee
                                (
                                    reader["Username"].ToString(),
                                    "", 
                                    reader["Role"].ToString(),
                                    reader["Department"].ToString(),
                                    reader["ContactNumber"].ToString(),
                                    reader["Qualifications"].ToString()
                                );

                                employees.Add(employee);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                }
            }

            return employees;
        }
    }

}
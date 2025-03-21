using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceApplication
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public void Login(HttpResponse response)
        {
            if (Role == "Admin")
            {
                response.Redirect("AdminPage.aspx");
            }
            else
            {
                response.Redirect("DepartmentDashboard.aspx");
            }
        }
    }
}
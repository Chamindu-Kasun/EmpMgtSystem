﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            UserController userController = new UserController();
            User authUser = userController.GetAuthenticateUser(username, password);

            if (authUser != null)
            {
                authUser.Login(Response);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Invalid username or password");
            }          
        }
    }
}
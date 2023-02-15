﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_animAX
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Blocs/Home.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Blocs/Login.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Blocs/Register.aspx");
        }

        protected void manageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Blocs/ManageUser.aspx");
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Blocs/Cart.aspx");
        }

        protected void transactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Blocs/Subscriptions.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
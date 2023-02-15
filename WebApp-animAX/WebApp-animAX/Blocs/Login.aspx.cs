using Newtonsoft.Json;
using WebApp_animAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Modules;

namespace WebApp_animAX.Blocs
{
    public partial class Login : System.Web.UI.Page
    {
        private UserSession us = UserSession.getInstance();
        private localhost.WebService ws = WebService.getInstance();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string text = ws.login(txtUsername.Text, txtPassword.Text);
            if (text.Equals("Login Error"))
            {
                lblError.Text = "Error Login";
            }
            else
            {
                User user = JsonConvert.DeserializeObject<User>(text);
                lblError.Text = "Succesfully Login";

                us.AddUser(Response, user);
                Response.Redirect("Home.aspx");
            }
        }
    }
}
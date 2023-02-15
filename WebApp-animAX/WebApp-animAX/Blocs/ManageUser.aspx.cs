using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Modules;

namespace WebApp_animAX.Blocs
{
    public partial class ManageUser : System.Web.UI.Page
    {
        private localhost.WebService ws;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CheckAdmin()
        {
            string role = UserSession.getInstance().GetRole(Request);
            if (role != "Admin")
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}
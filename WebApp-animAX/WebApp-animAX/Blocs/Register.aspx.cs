using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_animAX.Blocs
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            localhost.WebService ws = new localhost.WebService();
            string txt = ws.register(txtName.Text.Trim(), txtPassword.Text.Trim(), "");
            if (txt != "")
            {
                lblError.Text = txt;
                return;
            }
            Response.Redirect("~/Login.aspx");
        }
    }
}
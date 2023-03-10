using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Modules;

namespace WebApp_animAX.Blocs
{
    public partial class Register : System.Web.UI.Page
    {
        private localhost.WebService ws = WebService.getInstance();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Modules;
using WebApp_animAX.Models;
using Newtonsoft.Json;

namespace WebApp_animAX.Blocs
{
    public partial class ManageUser : System.Web.UI.Page
    {
        private localhost.WebService ws;

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAdmin();
            ws = new localhost.WebService();
            string res = ws.getUserList();
            List<User> userList = JsonConvert.DeserializeObject<List<User>>(res);
            userGv.DataSource = userList;
            userGv.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUpdateUname.Text.Trim();
            string password = tbUpdatePassword.Text.Trim();
            string id = tbUpdateUid.Text.Trim();
            string role = tbUpdateRole.Text.Trim();
            string res = ws.updateUser(id, username, role, password);

            if (res != null)
            {
                lbUpdateError.Text = res;
            }
            else
            {
                RefreshPage();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbDeleteUid.Text.Trim();
            ws.removeUser(id);
        }

        private void CheckAdmin()
        {
            string role = UserSession.getInstance().GetRole(Request);
            if (role != "Admin")
            {
                Response.Redirect("Login.aspx");
            }
        }

        private void RefreshPage()
        {
            Response.Redirect("ManageUser.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Modules;
using Newtonsoft.Json;

namespace WebApp_animAX.Blocs
{
    public partial class Cart : System.Web.UI.Page
    {
        private localhost.WebService ws = WebService.getInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buyBtn_Click(object sender, EventArgs e)
        {
            string userId = UserSession.getInstance().GetUserId(Request);
            //ws.createTransaction(userId);
        }

        private void LoadData()
        {
            string resCart = UserSession.getInstance().getCart(Request);
            Cart cart = JsonConvert.DeserializeObject<Cart>(resCart);

            if (cart == null)
            {
                lbError.Text = "Empty cart";
            }

            gvCart.DataSource = cart;
            gvCart.DataBind();
        }
    }
}
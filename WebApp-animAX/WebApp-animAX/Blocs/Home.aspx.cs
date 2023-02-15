using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Models;
using Newtonsoft.Json;
using WebApp_animAX.Modules;

namespace WebApp_animAX.Blocs
{
    public partial class Home : System.Web.UI.Page
    {
        private localhost.WebService ws = WebService.getInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAdminView();
            CheckUserView();
            loadAnimeData();
        }

        protected void addCart_Click(object sender, EventArgs e)
        {
            Models.Cart cart = new Models.Cart();

            string resAnime = ws.showAnime(tbCartAnimeId.Text.ToString());
            if(resAnime == null)
            {
                lbCartError.Text = "Invalid anime";
            }
            cart.anime = JsonConvert.DeserializeObject<Anime>(resAnime);

            string resUser = ws.showUser(UserSession.getInstance().GetUserId(Request));
            cart.user = JsonConvert.DeserializeObject<User>(resUser);

            cart.animeId = int.Parse(tbCartAnimeId.Text.ToString());
            cart.userId = int.Parse(UserSession.getInstance().GetUserId(Request));
        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
            string name = tbInsertAnimeName.Text.Trim();
            string price = tbInsertSubscriptionPrice.Text.Trim();

            string res = ws.createAnime(name, price);
            if (res != "")
            {
                lbInsertError.Text = res;
            }
            else
            {
                RefreshPage();
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string id = tbAnimeUpdateId.Text.Trim();
            string name = tbUpdateAnimeTitle.Text.Trim();
            string price = tbUpdateSubscriptionPrice.Text.Trim();

            string res = ws.updateAnime(int.Parse(id), name, price);
            if (res != "")
            {
                lbUpdateError.Text = res;
            }
            else
            {
                RefreshPage();
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = tbDeleteAnimeId.Text.Trim();
            bool res = ws.removeGame(int.Parse(id));
            if (res)
            {
                RefreshPage();
            }
            else
            {
                lbDeleteError.Text = "Error Deleting";
            }
        }

        private void loadAnimeData()
        {
            string res = ws.getAnime();
            if (res != null)
            {
                List<Anime> gameList = JsonConvert.DeserializeObject<List<Anime>>(res);
                animeGv.DataSource = gameList;
                animeGv.DataBind();
            }
        }

        private void CheckAdminView()
        {
            if (UserSession.getInstance().GetRole(Request).Equals("Admin"))
            {
                adminView.Visible = true;
            }
            else
            {
                adminView.Visible = false;
            }
        }

        private void CheckUserView()
        {
            if (UserSession.getInstance().GetRole(Request).Equals(""))
            {

                cartView.Visible = false;
            }
            else
            {
                cartView.Visible = true;
            }
        }
        private void RefreshPage()
        {
            Response.Redirect("Home.aspx");
        }
    }
}
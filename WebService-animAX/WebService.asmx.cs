using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_animAX.Controller;
using Newtonsoft.Json;

namespace WebService_animAX
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string login(string username, string password)
        {
            User user = UserController.login(username, password);

            if (user == null)
                return "Login error";


            return serealize<User>(user);
        }

        [WebMethod]
        public string register(string username, string password, string role)
        {
            return UserController.register(username, password, role);
        }

        [WebMethod]
        public string updateUser(string id, string username, string role, string email, string password)
        {
            return UserController.update(id, username, role, password);
        }

        [WebMethod]
        public bool removeUser(string id)
        {
            return UserController.remove(id);
        }

        [WebMethod]
        public string createAnime(string title, string price)
        {
            return AnimeController.create(title, price);
        }

        [WebMethod]
        public string updateAnime(int id, string title, string price)
        {
            return AnimeController.update(id, title, price);
        }

        [WebMethod]
        public bool removeGame(int id)
        {
            return AnimeController.remove(id);
        }

        [WebMethod]
        public string createTransaction(string uid, string aid, string quantity)
        {
            return TransactionController.create(uid, aid, quantity);
        }

        [WebMethod]
        public string getAnime()
        {
            List<Anime> gameList = AnimeController.get();

            return serealize<List<Anime>>(gameList);
        }

        public string serealize<T>(T p)
        {
            return JsonConvert.SerializeObject(p, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}

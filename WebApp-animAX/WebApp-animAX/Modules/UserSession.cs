using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_animAX.Models;

namespace WebApp_animAX.Modules
{
    public class UserSession
    {
        public string role = "";
        public string roleCookies = "user_cookie";
        public string uidCookies = "user_id_cookie";
        public string id = "";

        public static UserSession instance;
        private UserSession()
        {

        }

        public static UserSession getInstance()
        {
            if (instance == null) instance = new UserSession();
            return instance;
        }

        private void AddUserId(HttpResponse Response, User user)
        {
            HttpCookie cookie = new HttpCookie(uidCookies);
            cookie.Value = user.id.ToString();
            cookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(cookie);
            id = user.id.ToString();

        }

        private void AddUserRole(HttpResponse Response, User user)
        {
            HttpCookie cookie = new HttpCookie(roleCookies);
            cookie.Value = user.role;
            cookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(cookie);
            role = user.role;
        }

        public void AddUser(HttpResponse Response, User user)
        {
            AddUserId(Response, user);
            AddUserRole(Response, user);
        }
    }
}
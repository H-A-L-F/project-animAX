using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp_animAX.Models;
using Newtonsoft.Json;

namespace WebApp_animAX.Modules
{
    public class UserSession
    {
        public string role = "";
        public string roleCookies = "user_cookie";
        public string uidCookies = "user_id_cookie";
        public string id = "";
        public string cartCookies = "cart_cookie";
        public string cart = "";

        public static UserSession instance;
        private UserSession()
        {

        }

        public static UserSession getInstance()
        {
            if (instance == null) instance = new UserSession();
            return instance;
        }

        public void Remove(HttpResponse Response)
        {
            HttpCookie idCookie = new HttpCookie(uidCookies);
            idCookie.Value = null;
            Response.Cookies.Add(idCookie);

            HttpCookie roleCookie = new HttpCookie(roleCookies);
            roleCookie.Value = null;
            Response.Cookies.Add(roleCookie);
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

        public string GetRole(HttpRequest Request)
        {

            if (Request.Cookies[roleCookies] != null)
            {
                role = Request.Cookies[roleCookies].Value;
            }
            return role;
        }

        public string GetUserId(HttpRequest Request)
        {
            if (Request.Cookies[uidCookies] != null)
            {
                id = Request.Cookies[uidCookies].Value;
            }
            return id;
        }

        public void addCart(HttpResponse Response, Cart cart)
        {
            HttpCookie cookie = new HttpCookie(cartCookies);
            cookie.Value = serealize(cart);
            cookie.Expires = DateTime.Now.AddHours(5);
            Response.Cookies.Add(cookie);
            this.cart = serealize(cart);
        }

        public string getCart(HttpRequest request)
        {
            if(request.Cookies[cart] != null)
            {
                cart = request.Cookies[cartCookies].Value;
            }
            return cart;
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
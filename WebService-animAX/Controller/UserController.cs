using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Handler;

namespace WebService_animAX.Controller
{
    public class UserController
    {
        public static User login(string username, string password)
        {
            if (username.Equals("") || password.Equals(""))
            {
                return null;
            }
            return UserHandler.login(username, password);
        }

        public static string register(string username, string password, string role)
        {
            if (username.Equals("") || password.Equals(""))
            {
                return "Please input all input!";
            }
            UserHandler.register(username, password, role);
            return "";
        }
    }
}
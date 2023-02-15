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
    }
}
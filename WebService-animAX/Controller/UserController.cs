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
            return Status.SUCCESS.ToString();
        }

        public static string update(string id, string username, string role, string password)
        {
            if (id == "" || username == "" || role == "" || password == "")
            {
                return "Please fill all the fields!";
            }

            int intId;
            try
            {
                intId = int.Parse(id);
            }
            catch (Exception e)
            {
                return "Id must be integer!";
            }

            UserHandler.update(intId, username, role, password);
            return Status.SUCCESS.ToString();
        }

        public static bool remove(string id)
        {
            int temp = -1;
            try
            {
                temp = int.Parse(id);
            }
            catch (Exception e)
            {
                return false;
            }
            return UserHandler.remove(temp);
        }

        public static List<User> Get()
        {
            return UserHandler.Get();
        }
    }
}
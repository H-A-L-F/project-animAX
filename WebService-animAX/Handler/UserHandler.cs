using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_animAX.Handler
{
    public class UserHandler
    {
        public static User login(string username, string password)
        {
            return UserRepository.login(username, password);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Repository;

namespace WebService_animAX.Handler
{
    public class UserHandler
    {
        public static User login(string username, string password)
        {
            return UserRepository.login(username, password);
        }
        public static void register(string username, string password, string role)
        {
            UserRepository.register(username, password, role);
        }
    }
}
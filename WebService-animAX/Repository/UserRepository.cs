using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Factory;

namespace WebService_animAX.Repository
{
    public class UserRepository
    {
        public static User login(string username, string password)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            User u = (from data in db.Users
                      where data.Username.Equals(username) &&
                data.Password.Equals(password)
                      select data).FirstOrDefault();
            return u;
        }

        public static void register(string username, string password, string role)
        {
            UserFactory.Create(username, password, role);
        }
    }
}
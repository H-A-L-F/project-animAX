using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Module;

namespace WebService_animAX.Factory
{
    public class UserFactory
    {
        public static void Create(string username, string password, string role)
        {
            ServiceDatabaseEntities db = DatabaseModule.getDbInstance();
            User user = new User();

            string currRole = role == "" ? "Member" : role;
            user.Role = currRole;

            user.Username = username;
            user.Password = password;

            db.Users.Add(user);
            DatabaseModule.SaveDb();
        }
    }
}
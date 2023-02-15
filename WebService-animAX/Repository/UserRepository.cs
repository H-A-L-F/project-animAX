using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Factory;
using WebService_animAX.Module;

namespace WebService_animAX.Repository
{
    public class UserRepository
    {
        private static ServiceDatabaseEntities db = DatabaseModule.GetDbInstance();
        public static User login(string username, string password)
        {
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

        public static void update(int id, string username, string role, string password)
        {

            User user = db.Users.Find(id);
            if (user == null) return;

            user.Username = username;
            user.Role = role;
            user.Password = password;

            db.SaveChanges();
        }

        public static bool remove(int id)
        {
            User user = db.Users.Find(id);
            if (user == null) return false;
            db.Users.Remove(user);
            db.SaveChanges();
            return true;
        }

        public static List<User> Get()
        {
            List<User> userList = (from data in db.Users select data).ToList();
            return userList;

        }
        public static User Show(int userId)
        {
            User user = (from data in db.Users select data).Where(c => c.Id == userId).FirstOrDefault<User>();
            return user;
        }
    }
}
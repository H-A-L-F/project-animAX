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

        public static void update(int id, string username, string role, string password)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();

            User user = db.Users.Find(id);
            if (user == null) return;

            user.Username = username;
            user.Role = role;
            user.Password = password;

            db.SaveChanges();
        }

        public static bool remove(int id)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            User user = db.Users.Find(id);
            if (user == null) return false;
            db.Users.Remove(user);
            db.SaveChanges();
            return true;
        }

        public static List<User> Get()
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            List<User> userList = (from data in db.Users select data).ToList<User>();
            return userList;

        }
        public static User Show(int userId)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            User user = (from data in db.Users select data).Where(c => c.Id == userId).FirstOrDefault<User>();
            return user;
        }
    }
}
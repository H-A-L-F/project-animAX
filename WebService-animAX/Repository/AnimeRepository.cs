using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Factory;

namespace WebService_animAX.Repository
{
    public class AnimeRepository
    {
        public static void create(string name, string price)
        {
            AnimeFactory.Create(name, price);
        }

        public static void update(int id, string name, string price)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            Anime anime = db.Animes.Find(id);
            if (anime == null) return;
            anime.Title = name;
            anime.SubscriptionPrice = int.Parse(price);
            db.SaveChanges();
        }

        public static bool remove(int id)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            Anime anime = db.Animes.Find(id);
            if (anime == null) return false;
            db.Animes.Remove(anime);
            db.SaveChanges();
            return true;
        }

        public static Anime Show(int id)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            Anime anime = (from data in db.Animes select data).Where(c => c.Id == id).FirstOrDefault<Anime>();
            return anime;
        }

        public static List<Anime> get()
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();

            Anime anime = (from data in db.Animes select data).FirstOrDefault();
            //System.Diagnostics.Debug.WriteLine("First Anime : ", anime.Title);
            List<Anime> aniList = (from data in db.Animes select data).ToList<Anime>();

            //System.Diagnostics.Debug.WriteLine("Anime List From Repository : ", aniList[0]);
            return aniList;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_animAX.Factory
{
    public class AnimeFactory
    {
        public static void Create(string title, string price)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            Anime anime = new Anime();
            anime.Title = title;
            anime.SubscriptionPrice = int.Parse(price);
            db.Animes.Add(anime);
            db.SaveChanges();
        }
    }
}
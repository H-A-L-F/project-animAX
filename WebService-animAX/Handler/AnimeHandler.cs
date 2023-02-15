using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Repository;

namespace WebService_animAX.Handler
{
    public class AnimeHandler
    {
        public static Anime Show(int id)
        {
            return AnimeRepository.Show(id);
        }
        public static void create(string title, string price)
        {
            AnimeRepository.create(title, price);
        }

        public static void update(int id, string title, string price)
        {
            AnimeRepository.update(id, title, price);
        }

        public static bool remove(int id)
        {
            return AnimeRepository.remove(id);
        }

        public static List<Anime> get()
        {
            return AnimeRepository.get();
        }
    }
}
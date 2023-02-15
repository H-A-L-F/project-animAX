using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Module;

namespace WebService_animAX.Controller
{
    public class AnimeController
    {
        public static string validation(string title, string price)
        {
            if(title == "" || price == "")
            {
                return "Please fill all fields!";
            }
            return Status.SUCCESS.ToString();
        }

        public static string create(string title, string price)
        {
            string status = validation(title, price);
            if(status == Status.ERROR.ToString())
            {
                return status;
            }

            AnimeHandler.create(title, price);
            return Status.SUCCESS.ToString();
        }

        public static string update(int id, string title, string price)
        {
            string status = validation(title, price);
            if (status == Status.ERROR.ToString())
            {
                return status;
            }

            AnimeHandler.update(id, title, price);
            return Status.SUCCESS.ToString();
        }

        public static bool remove(int id)
        {
            return AnimeHandler.remove(id);
        }

        public static List<Anime> get()
        {
            return AnimeHandler.get();
        }

        public static Anime Show(string id)
        {
            int intAnimeId = -1;
            try
            {
                intAnimeId = int.Parse(id);
            }
            catch (Exception e)
            {
                return null;
            }
            return AnimeHandler.Show(intAnimeId);
        }
    }
}
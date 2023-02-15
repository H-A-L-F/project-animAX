using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_animAX.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int animeId { get; set; }

        public virtual Anime anime { get; set; }
        public virtual User user { get; set; }
    }
}
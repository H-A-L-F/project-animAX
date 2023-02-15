using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_animAX.Modules
{
    public class WebService
    {
        private static localhost.WebService instance;

        public static localhost.WebService getInstance()
        {
            if (instance == null) instance = new localhost.WebService();
            return instance;
        }
    }
}
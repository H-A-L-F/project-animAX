using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_animAX.Modules
{
    public class WebService
    {
        private static WebService instance;

        private WebService()
        {

        }

        public static WebService getInstance()
        {
            if (instance == null) instance = new WebService();
            return instance;
        }
    }
}
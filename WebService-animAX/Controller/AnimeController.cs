using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Module;

namespace WebService_animAX.Controller
{
    public class AnimeController
    {
        public string validation(string title, string price)
        {
            if(title == "" || price == "")
            {
                return "Please fill all fields!";
            }
            return Status.SUCCESS.ToString();
        }
    }
}
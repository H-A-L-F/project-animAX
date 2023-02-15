using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_animAX.Models
{
    public class TransactionDetail
    {
        public int transactionId { get; set; }
        public int gameId { get; set; }
        public int quantity { get; set; }

        public virtual Anime anime { get; set; }
        public virtual TransactionHeader transactionHeader { get; set; }
    }
}
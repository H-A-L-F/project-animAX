using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_animAX.Models
{
    public class TransactionHeader
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int userId { get; set; }

        public virtual ICollection<TransactionDetail> transactionDetails { get; set; }
        public virtual User user { get; set; }
    }
}
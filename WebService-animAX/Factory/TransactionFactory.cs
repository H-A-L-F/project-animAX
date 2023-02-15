using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_animAX.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateHeader(int uid)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            TransactionHeader transaction = new TransactionHeader();
            transaction.UserId = uid;
            transaction.Date = DateTime.Now;

            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();

            return transaction;
        }

        public static void CreateDetail(int tid, int aid)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            TransactionDetail detail = new TransactionDetail();
            detail.AnimeId = aid;
            detail.TransactionId = tid;
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Module;

namespace WebService_animAX.Factory
{
    public class TransactionFactory
    {
        private static ServiceDatabaseEntities db = DatabaseModule.GetDbInstance();
        public static TransactionHeader CreateHeader(int uid)
        {
            TransactionHeader transaction = new TransactionHeader();
            transaction.UserId = uid;
            transaction.Date = DateTime.Now;

            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();

            return transaction;
        }

        public static void CreateDetail(int tid, int aid, int quantity)
        {
            TransactionDetail detail = new TransactionDetail();
            detail.AnimeId = aid;
            detail.TransactionId = tid;
            detail.Quantity = quantity;
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }
}
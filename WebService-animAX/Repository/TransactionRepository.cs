using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Factory;

namespace WebService_animAX.Repository
{
    public class TransactionRepository
    {
        public static TransactionHeader InsertHeader(int uid)
        {
            return TransactionFactory.CreateHeader(uid);
        }
        public static List<TransactionHeader> GetHeader(int uid)
        {

            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            List<TransactionHeader> headerList = (from data in db.TransactionHeaders select data).Where(c => c.Id == uid).ToList<TransactionHeader>();
            return headerList;
        }

        public static List<TransactionDetail> GetDetail(int tid)
        {
            ServiceDatabaseEntities db = new ServiceDatabaseEntities();
            List<TransactionDetail> detailList = (from data in db.TransactionDetails select data).Where(c => c.TransactionId == tid).ToList<TransactionDetail>();
            return detailList;
        }

        public static void InsertDetail(int tid, int aid, int quantity)
        {
            TransactionFactory.CreateDetail(tid, aid, quantity);
        }
    }
}
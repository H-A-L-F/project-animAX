using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Factory;
using WebService_animAX.Module;

namespace WebService_animAX.Repository
{
    public class TransactionRepository
    {
        private static ServiceDatabaseEntities db = DatabaseModule.GetDbInstance();
        public static TransactionHeader InsertHeader(int uid)
        {
            return TransactionFactory.CreateHeader(uid);
        }
        public static List<TransactionHeader> GetHeader(int uid)
        {

            List<TransactionHeader> headerList = (from data in db.TransactionHeaders select data).Where(c => c.Id == uid).ToList<TransactionHeader>();
            return headerList;
        }

        public static List<TransactionDetail> GetDetail(int tid)
        {
            List<TransactionDetail> detailList = (from data in db.TransactionDetails select data).Where(c => c.TransactionId == tid).ToList<TransactionDetail>();
            return detailList;
        }

        public static void InsertDetail(int tid, int aid, int quantity)
        {
            TransactionFactory.CreateDetail(tid, aid, quantity);
        }
    }
}
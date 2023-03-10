using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Repository;

namespace WebService_animAX.Handler
{
    public class TransactionHandler
    {
        public static TransactionHeader InsertHeader(int uid)
        {
            return TransactionRepository.InsertHeader(uid);
        }

        public static List<TransactionHeader> GetHeader(int uid)
        {
            return TransactionRepository.GetHeader(uid);
        }

        public static List<TransactionDetail> GetDetail(int tid)
        {
            return TransactionRepository.GetDetail(tid);
        }

        public static void InsertDetail(int tid, int aid, int quantity)
        {
            TransactionRepository.InsertDetail(tid, aid, quantity);
        }
    }
}
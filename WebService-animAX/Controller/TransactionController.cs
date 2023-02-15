using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_animAX.Handler;

namespace WebService_animAX.Controller
{
    public class TransactionController
    {
        public static string validation(string uid, string aid, string quantity)
        {
            int intUid;
            try
            {
                intUid = int.Parse(uid);
            }
            catch (Exception e)
            {
                return "Id invalid";
            }

            return Status.SUCCESS.ToString();
        }

        public static string create(string uid, string aid, string quantity)
        {
            string status = validation(uid, aid, quantity);
            if (status != Status.SUCCESS.ToString())
            {
                return status;
            }
            
            string headerId = createHeader(int.Parse(uid));

            int tid;
            try
            {
                tid = int.Parse(headerId);
            } catch
            {
                return "Invalid headerId";
            }

            return createDetail(tid, aid, quantity);
        }

        public static string createHeader(int userId)
        {
            TransactionHandler.InsertHeader(userId);
            return Status.SUCCESS.ToString();
        }

        public static string createDetail(int tid, string aid, string quantity)
        {
            TransactionHandler.InsertDetail(tid, aid, quantity);
            return Status.SUCCESS.ToString();
        }

        public static List<TransactionHeader> GetHeader(string uid)
        {
            int intUserId = -1;
            try
            {
                intUserId = int.Parse(uid);
            }
            catch (Exception e)
            {
                return null;
            }
            return TransactionHandler.GetHeader(intUserId);
        }

        public static List<TransactionDetail> GetDetail(string tid)
        {
            int intHeaderId = -1;
            try
            {
                intHeaderId = int.Parse(tid);
            }
            catch (Exception e)
            {
                return null;
            }

            return TransactionHandler.GetDetail(intHeaderId);
        }
    }
}
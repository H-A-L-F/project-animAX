using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_animAX.Controller
{
    public class TransactionController
    {
        public static string validation(string uid)
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

        public static string create(string uid)
        {
            string status = validation(uid);
            if (status != Status.SUCCESS.ToString())
            {
                return status;
            }
            return createHeader(int.Parse(uid));
        }

        public static string createHeader(int userId)
        {
            TransactionHandler.InsertHeader(userId);
            return "";
        }

        public static string createDetail(string headerId, string gameId)
        {
            int headerIntId = -1;
            int gameIntId = -1;
            try
            {
                headerIntId = int.Parse(headerId);
                gameIntId = int.Parse(gameId);
            }
            catch (Exception e)
            {
                return "Please input a validation!";
            }

            TransactionHandler.InsertDetail(headerIntId, gameIntId);
            return "";
        }
    }
}
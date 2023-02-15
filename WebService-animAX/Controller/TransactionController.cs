using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_animAX.Controller
{
    public class TransactionController
    {
        public static string validation(int uid)
        {
            return Status.SUCCESS.ToString();
        }

        public static string create(int uid)
        {

        }

        public static string createHeader(string userId)
        {
            int userIntId = -1;
            try
            {
                userIntId = int.Parse(userId);
            }
            catch (Exception e)
            {
                return "Please input a validation!";
            }

            TransactionHandler.InsertHeader(userIntId);
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
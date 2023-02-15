using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_animAX.Modules;
using WebApp_animAX.Models;
using Newtonsoft.Json;

namespace WebApp_animAX.Blocs
{
    public partial class Transaction : System.Web.UI.Page
    {
        private localhost.WebService ws = WebService.getInstance();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void SetData()
        {
            Report.CrystalReport4 report = new Report.CrystalReport4();

            CrystalReportViewer1.ReportSource = report;
            Dataset.DataSet data = GetData();
            report.SetDataSource(data);
        }

        private Dataset.DataSet GetData()
        {
            string userId = UserSession.getInstance().GetUserId(Request);

            Dataset.DataSet data = new Dataset.DataSet();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            string res = ws.getHeader(userId);
            List<TransactionHeader> transactionHeaders = JsonConvert.DeserializeObject<List<TransactionHeader>>(res);

            foreach (TransactionHeader curr in transactionHeaders)
            {
                System.Diagnostics.Debug.WriteLine("Header! --");
                var hrow = headerTable.NewRow();
                hrow["id"] = curr.id;
                hrow["user_id"] = curr.userId;
                hrow["date"] = curr.date.ToString("MMM dd yyyy");

                headerTable.Rows.Add(hrow);

                string res_detail = ws.getDetail(curr.id.ToString());
                List<TransactionDetail> transactionDetails = JsonConvert.DeserializeObject<List<TransactionDetail>>(res_detail);

                Dictionary<int, int> dict = new Dictionary<int, int>();

                List<TransactionDetail> newDetailList = new List<TransactionDetail>();

                foreach (TransactionDetail curr_detail in transactionDetails)
                {
                    try
                    {
                        dict[curr_detail.anime.id] += 1;
                    }
                    catch (KeyNotFoundException e)
                    {
                        dict[curr_detail.anime.id] = 1;
                        newDetailList.Add(curr_detail);
                    }

                }

                foreach (TransactionDetail curr_detail in newDetailList)
                {
                    var drow = detailTable.NewRow();


                    drow["anime_id"] = curr_detail.anime.id;
                    drow["transaction_id"] = curr_detail.transactionId;
                    drow["quantity"] = curr_detail.quantity;

                    detailTable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}
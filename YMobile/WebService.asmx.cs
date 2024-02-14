using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace YMobile
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
       
        cls_db db = new cls_db();
        [WebMethod(MessageName ="GetAccount",Description ="هذه دالة تستقبل رقم الموبايل ثم تعيد اسم مالك هذا الموبايل والرصيد")]
        [System.Xml.Serialization.XmlInclude(typeof(cls_Account))]
        public cls_Account GetAccount(string MobileNo)
        { 
        cls_Account c =new cls_Account();
            DataTable tb = db.GetAccount(MobileNo);
            if (tb.Rows.Count > 0)
            {
                c.CustomerName = tb.Rows[0][1].ToString();
                c.LastBalance = tb.Rows[0][0].ToString();
            }
            return c;
        }
        [WebMethod(MessageName = "payment", Description = "دالة تقوم باستقبال رقم الموبايلوالمبلغ المدفوع وتعيد القيمة أكبر من صفر لتمام العملية")]
        /*[System.Xml.Serialization.XmlInclude(typeof(Cls_Account))]*/
        public byte payment(string MobileNo, string pay)
        {
            byte r = db.payment(MobileNo, pay);
            return r;

        }
    }
}

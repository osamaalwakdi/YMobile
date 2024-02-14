using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.YMobile;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        YMobile.WebServiceSoapClient ws = new WebServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
          byte i =  ws.payment(txtMobileNo.Text, txtBalance.Text);
            if (i > 0)
                MessageBox.Show("تم التسديد بنجاح");
            GetBalance();
        }
        void GetBalance()
        {
            cls_Account c = new YMobile.cls_Account();
            c = ws.GetAccount(txtMobileNo.Text);
            LbcustomerName.Text = c.CustomerName;
            lbLastBalancee.Text = c.LastBalance;
        }
    }
}

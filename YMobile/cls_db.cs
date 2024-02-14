using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


    /// <summary>
    /// Summary description for cls_DB
    /// </summary>
    public class cls_db
    {

        public cls_db()
        {

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conDB"].ConnectionString);
        SqlCommand cmd = new SqlCommand();

        public byte payment(string MobileNo, string payment)
        {
            byte r = 0;
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ws_payment";
            cmd.Parameters.Add("@MobileNo", MobileNo);
            cmd.Parameters.Add("@payment", payment);
            cmd.Parameters.Add("@DateofPayment", DateTime.Now);
            r = (byte)cmd.ExecuteNonQuery();
            con.Close();
            return r;

        }
        public DataTable GetAccount(string MobileNo)
        {
            DataTable tb = new DataTable();
            if (con.State == ConnectionState.Open) con.Close();
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ws_account";
            cmd.Parameters.Add("@MobileNo", MobileNo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            con.Close();
            return tb;

        }

    }

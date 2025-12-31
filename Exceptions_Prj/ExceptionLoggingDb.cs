using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace Exceptions_Prj
{
    public class ExceptionLoggingDb
    {
        static string exepurl;
        static SqlConnection con;

        static void getConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["dblogconn"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }

        public static void WriteErrorLogToDB(Exception exdb)
        {
            getConnection();
            exepurl = context.Current.Request.Url.ToString();

            SqlCommand cmd = new SqlCommand("ExceptionLoggingTodatabase", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@excmsg", exdb.Message.ToString());
            cmd.Parameters.AddWithValue("@exctype", exdb.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@excsrc", exdb.StackTrace.ToString());
            cmd.Parameters.AddWithValue("@excurl", exepurl);
            cmd.ExecuteNonQuery();
        }
    }
}
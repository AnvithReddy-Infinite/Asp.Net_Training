using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace ElectricityBillingAutomation
{
    public class DBHandler
    {
        public SqlConnection GetConnection()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["ElectricityDBConnection"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
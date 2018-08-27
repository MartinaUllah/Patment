using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace Patment.Repository
{
    public static  class SqlConnectionFactory
    {
        public static SqlConnection GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            var sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseConnection
{
    class ConnectionToSQLServer
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            string connectString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", datasource, database);

            SqlConnection conn = new SqlConnection(connectString);

            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseConnection
{
    class ConnectionToDataBase
    {
        public static SqlConnection GetDBConnection ()
        {
            string datasource = "laptop-n52b82v9";
            string database = "CSharpTest";

            return ConnectionToSQLServer.GetDBConnection(datasource, database);
        }
    }
}

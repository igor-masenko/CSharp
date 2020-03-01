using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection...");
            SqlConnection conn = ConnectionToDataBase.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection...");
                conn.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();

            try
            {
                Console.WriteLine("Closing connection...");
                conn.Close();
                Console.WriteLine("Connection is closed!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();

        }
    }
}

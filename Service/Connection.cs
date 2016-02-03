using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Service
{
    class Connection
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(@"Server=localhost\SQLExpress;Database=Servicios_2015;Trusted_Connection=True;");

            try
            {
                conn.Open();
                Console.WriteLine("Connected");
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Not connected : " + e.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("You're connected..");
            }
            return conn;
        }
    }
}

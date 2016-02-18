using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFloorDAL
{
    public class DBConnector
    {
        private SqlConnection connection;

        public static SqlConnection GetDBConnection()
        {
            try
            {
                string connectionString = @"user id=username;
                                            password=password;
                                            server=serverurl;
                                            Trusted_Connection=yes;
                                            database=database; 
                                            connection timeout=30";

                return new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;
        }

        public static void OpenConnection(SqlConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

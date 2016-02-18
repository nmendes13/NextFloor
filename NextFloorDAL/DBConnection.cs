using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFloorDAL
{
    public class DBConnection
    {
        private OdbcConnection connection;
        public DBConnection(string connectionString)
        {
            //Data Source=(localdb)\ProjectsV12;Initial Catalog=NextFloorDB;Integrated Security=True;Pooling=False;Connect Timeout=30
            connection = new OdbcConnection(connectionString);
        }
        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }catch(Exception ex)
            {

            }
        }
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

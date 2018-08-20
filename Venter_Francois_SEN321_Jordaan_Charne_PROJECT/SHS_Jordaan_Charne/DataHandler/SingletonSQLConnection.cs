using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    class SingletonSQLConnection
    {
        private static SingletonSQLConnection instance = new SingletonSQLConnection();

        private SqlConnection connection;

        private SingletonSQLConnection()
        {

        }

        public static SingletonSQLConnection GetInstance()
        {
            return instance;
        }

        public SqlConnection GetOrCreateConnection()
        {
            if (connection == null)
            {
                string str = "Data Source=USER-PC;Integrated Security=SSPI;Initial Catalog=SmartHomeSystems";
                connection = new SqlConnection(str);
            }
            return connection;
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Data.Services
{
    public class LoanContext
    {
        static OracleConnection conn;

        public static void OpenConnection()
        {
            if (conn == null)
            {
                conn = new OracleConnection();
                conn.ConnectionString = "Data Source = localhost:1521/XEPDB1; User Id = Loan; Password = 123";
                string query = "SELECT Customer.CustomerId, Address.CustomerId " +
                               "FROM table1 Customer " +
                               "INNER JOIN table2 Address ON Customer.join_column = Address.join_column";
                OracleCommand command = new OracleCommand(query, conn);
                conn.Open();
            }
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static OracleConnection GetConnection()
        {
            if (conn == null)
                OpenConnection();
            return conn;
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OracleDbContext
    {
        private readonly string _connectionString = "User Id=SYSTEM;Password=123456;Data Source=localhost:1521";

        public OracleConnection GetConnection()
        {
            var connection = new OracleConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}

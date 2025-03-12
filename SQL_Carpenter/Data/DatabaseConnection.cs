using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQL_Carpenter.Data
{
    public abstract class DatabaseConnection
    {
        private string _connectionstring;
        protected SqlConnection _connection;

        public DatabaseConnection(string server, string user, string password)
        {
            _connectionstring = $"Data Source={server}; " +
                $"User ID={user}; Password={password}; TrustServerCertificate=True;";
        }

        public void OpenConnection()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}

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
        protected SqlConnection _connection;

        protected string BuildConnectionString()
        {
            var settings = ConnectionSettings.Instance;
            return $"Data Source={settings.Server};" +
                   $"User ID={settings.User};" +
                   $"Password={settings.Password};" +
                   "TrustServerCertificate=True;";
        }

        public void OpenConnection()
        {
            string connectionString = BuildConnectionString();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}

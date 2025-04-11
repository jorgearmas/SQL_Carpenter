using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SQL_Carpenter.Services.DDL
{
    internal class CreateDB : DatabaseConnection
    {
        //public CreateDB(string server_name, string user_name, string password) : base(server_name, user_name, password) { }

        public int CreateDatabase(string database_name)
        {
            if (!IsValidDatabaseName(database_name))
            {
                throw new ArgumentException("Invalid database name.");
            }

            OpenConnection();
            string query = $"CREATE DATABASE {database_name}";
            SqlCommand command = new SqlCommand(query, _connection);
            int db_creation_status = command.ExecuteNonQuery();
            CloseConnection();
            return db_creation_status;
        }

        private bool IsValidDatabaseName(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName)) return false;

            string pattern = @"^[a-zA-Z0-9_\-]+$"; // Letras, números, guion bajo y guion normal
            return Regex.IsMatch(databaseName, pattern);
        }
    }

}

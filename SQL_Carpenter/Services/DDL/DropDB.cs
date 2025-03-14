using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;
using System.Text.RegularExpressions;

namespace SQL_Carpenter.Services.DDL
{
    internal class DropDB : DatabaseConnection
    {
        public DropDB(string server_name, string user_name, string password) : base(server_name, user_name, password) { }

        public int DropDatabase(string database_name)
        {
            if (!IsValidDatabaseName(database_name))
            {
                throw new ArgumentException("Invalid database name.");
            }

            OpenConnection();
            string query = $"DROP DATABASE {database_name}";
            SqlCommand command = new SqlCommand(query, _connection);
            int db_deletion_status = command.ExecuteNonQuery();
            CloseConnection();
            return db_deletion_status;
        }

        private bool IsValidDatabaseName(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName)) return false;

            string pattern = @"^[a-zA-Z0-9_\-]+$"; // Letras, números, guion bajo y guion normal
            return Regex.IsMatch(databaseName, pattern);
        }
    }
}

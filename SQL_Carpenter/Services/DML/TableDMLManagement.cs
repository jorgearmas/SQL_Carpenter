using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;

namespace SQL_Carpenter.Services.DML
{
    internal class TableDMLManagement : DatabaseConnection
    {
        public TableDMLManagement(string server_name, string user_name, string password) : base(server_name, user_name, password) { }

        public List<string> getColumns(string db_name, string table_name)
        {
            List<string> allColumns = new List<string>();
            string query = $"USE {db_name}; SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{table_name}';";
            OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string new_element;
                    new_element = reader.GetString(0);
                    allColumns.Add(new_element);
                }
            }
            CloseConnection();
            return allColumns;
        }
    }
}

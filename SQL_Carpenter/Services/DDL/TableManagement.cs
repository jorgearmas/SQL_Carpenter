using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Carpenter.Services.DDL
{
    internal class TableManagement : DatabaseConnection
    {
        public TableManagement(string server, string user, string password) : base(server, user, password){}

        public int CreateTable(string db_name, string tableName, string primary_key, Dictionary<string, string> field_type_pair)
        {
            string subQueryFieldsTypes = "";

            foreach(var item in field_type_pair)
            {
                subQueryFieldsTypes += $"{item.Key} {item.Value}, ";
            }

            string query = $"USE {db_name}; CREATE TABLE {tableName} (" +
                $"{primary_key} INT PRIMARY KEY, " +
                $"{subQueryFieldsTypes});";
            OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection);
            int table_creation_status = command.ExecuteNonQuery();
            CloseConnection();
            return table_creation_status;
        }
    }
}

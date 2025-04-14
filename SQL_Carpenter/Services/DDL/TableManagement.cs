using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;

namespace SQL_Carpenter.Services.DDL
{
    internal class TableManagement : DatabaseConnection
    {

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

        public List<JObject> GetAllTables(string db_name)
        {
            List<JObject> returnThese = new List<JObject>();
            string query = $"USE {db_name}; SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";
            OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject newTableElement = new JObject();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        newTableElement.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    returnThese.Add(newTableElement);
                }
            }
            CloseConnection() ;
            return returnThese;
        }

        public int DropTable(string db_name, string table_name)
        {
            string query = $"USE {db_name}; DROP TABLE {table_name};";
            OpenConnection();
            SqlCommand command = new SqlCommand (query, _connection);
            int table_deletion_status = command.ExecuteNonQuery();
            CloseConnection() ;
            return table_deletion_status;
        }
    }
}

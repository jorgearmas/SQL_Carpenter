using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;
using Newtonsoft.Json.Linq;

namespace SQL_Carpenter.Services.DDL
{
    internal class GetAllDB : DatabaseConnection
    {
        public List<JObject> getAllDataBases()
        {
            List<JObject> returnThese = new List<JObject>();
            OpenConnection();
            string query = "SELECT * FROM sys.databases";
            SqlCommand command = new SqlCommand(query, _connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject newDB_Element = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newDB_Element.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    returnThese.Add(newDB_Element);
                }
            }
            CloseConnection();
            return returnThese;
        }
    }
}

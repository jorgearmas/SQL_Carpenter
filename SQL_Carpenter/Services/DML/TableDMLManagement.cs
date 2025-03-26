using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Carpenter.Data;
using Newtonsoft.Json.Linq;
using Azure.Core;
using System.Windows.Input;
//using System.Data.SqlClient;

namespace SQL_Carpenter.Services.DML
{
    internal class TableDMLManagement : DatabaseConnection
    {
        public TableDMLManagement(string server_name, string user_name, string password) : base(server_name, user_name, password) { }

        public Dictionary<string, string> getColumns(string db_name, string table_name)
        {
            Dictionary<string, string> allColumns = new Dictionary<string, string>();
            string query = $"USE {db_name}; SELECT column_name, data_type FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{table_name}';";
            OpenConnection();
            SqlCommand command = new SqlCommand(query, _connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string column_name;
                    string data_type;
                    column_name = reader.GetString(0);
                    data_type = reader.GetString(1);
                    allColumns.Add(column_name, data_type);
                }
            }
            CloseConnection();
            return allColumns;
        }

        public int insertData(string targetedDB, string targetedTable, string columnsToInsert, List<object> valuesToInsert)
        {
            if (string.IsNullOrWhiteSpace(targetedDB) || string.IsNullOrWhiteSpace(targetedTable) ||
                string.IsNullOrWhiteSpace(columnsToInsert) || valuesToInsert == null || valuesToInsert.Count == 0)
            {
                throw new ArgumentException("Los parámetros de inserción no pueden estar vacíos.");
            }

            string[] columnNames = columnsToInsert.Split(',');

            if (columnNames.Length != valuesToInsert.Count)
            {
                throw new ArgumentException("El número de columnas y valores no coincide.");
            }

            string parameterizedValues = string.Join(", ", columnNames.Select((col, index) => $"@param{index}"));
            string query = $"INSERT INTO {targetedDB}.dbo.{targetedTable} ({columnsToInsert}) VALUES ({parameterizedValues})";

            // Ejecutar la consulta

            OpenConnection();
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                // Agregar los parámetros al comando
                for (int i = 0; i < valuesToInsert.Count; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", valuesToInsert[i] ?? DBNull.Value);
                }

                return command.ExecuteNonQuery(); // Retorna el número de filas afectadas

            }
        }

        public int updateData(string targetedDB, string targetedTable, List<string> columnsToUpdate, List<object> valuesToUpdate, int targetedID, string ID_field)
        {
            if (columnsToUpdate == null || valuesToUpdate == null || columnsToUpdate.Count != valuesToUpdate.Count)
            {
                throw new ArgumentException("La cantidad de columnas y valores no coincide.");
            }

            string subQuery = string.Join(", ", columnsToUpdate.Select((col, index) => $"{col} = @param{index}"));
            string query = $"UPDATE {targetedDB}.dbo.{targetedTable} SET {subQuery} WHERE {ID_field} = @id";

            OpenConnection();
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                // Añadir los parámetros dinámicos
                for (int i = 0; i < valuesToUpdate.Count; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", valuesToUpdate[i] ?? DBNull.Value);
                }

                // Añadir el parámetro para el ID del WHERE
                command.Parameters.AddWithValue("@id", targetedID);

                // Ejecutar y devolver el número de filas afectadas
                return command.ExecuteNonQuery();
            }
        }

        public List<object> GetValuesFromColumns(string targetedDB, string targetedTable, List<string> targetedColumns, int targetedID, string ID_field)
        {
            if (string.IsNullOrWhiteSpace(targetedDB) || string.IsNullOrWhiteSpace(targetedTable) || targetedColumns == null || targetedColumns.Count == 0)
            {
                throw new ArgumentException("Los parámetros no pueden estar vacíos.");
            }

            string columns = string.Join(", ", targetedColumns);
            string query = $"USE {targetedDB}; SELECT {columns} FROM {targetedTable} WHERE {ID_field} = {targetedID};";

            List<Object> results = new List<Object>();

            OpenConnection();
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Object value = new Object();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            value = reader.GetValue(i);
                            results.Add(value);
                        }
                    }
                }
            }

            return results;
        }

        public List<JObject> getAllRecords(string targetedDB, string targetedTable)
        {
            List<JObject> returnThese = new List<JObject>();
            OpenConnection();
            string query = $"USE {targetedDB}; SELECT * FROM dbo.{targetedTable}";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject newTable_Element = new JObject();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            newTable_Element.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        }
                        returnThese.Add(newTable_Element);
                    }
                }
            }
            return returnThese;
        }
    }
}

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
            // Validar que las entradas no estén vacías
            if (string.IsNullOrWhiteSpace(targetedDB) || string.IsNullOrWhiteSpace(targetedTable) ||
                string.IsNullOrWhiteSpace(columnsToInsert) || valuesToInsert == null || valuesToInsert.Count == 0)
            {
                throw new ArgumentException("Los parámetros de inserción no pueden estar vacíos.");
            }

            // Convertir columnas en una lista
            string[] columnNames = columnsToInsert.Split(',');

            // Validar que el número de columnas y valores coincidan
            if (columnNames.Length != valuesToInsert.Count)
            {
                throw new ArgumentException("El número de columnas y valores no coincide.");
            }

            // Construir la parte de los valores con parámetros (@param1, @param2, ...)
            string parameterizedValues = string.Join(", ", columnNames.Select((col, index) => $"@param{index}"));

            // Construir la consulta SQL
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

    }
}

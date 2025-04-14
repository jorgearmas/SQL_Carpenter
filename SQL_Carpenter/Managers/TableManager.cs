using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SQL_Carpenter.Services.DDL;
using SQL_Carpenter.Services.DML;

namespace SQL_Carpenter.Managers
{
    internal class TableManager
    {
        public static Dictionary<string, string> getColumns(string db_name, string table_name)
        {
            var service = new TableDMLManagement();
            return service.getColumns(db_name, table_name);
        }

        public static int insertData(string targetedDB, string targetedTable, string columnsToInsert, List<object> valuesToInsert)
        {
            var service = new TableDMLManagement();
            return service.insertData(targetedDB, targetedTable, columnsToInsert, valuesToInsert);
        }

        public static int  updateData(string targetedDB, string targetedTable, List<string> columnsToUpdate, List<object> valuesToUpdate, int targetedID, string ID_field)
        {
            var service = new TableDMLManagement();
            return service.updateData(targetedDB, targetedTable, columnsToUpdate, valuesToUpdate, targetedID, ID_field);
        }

        public static List<object> GetValuesFromColumns(string targetedDB, string targetedTable, List<string> targetedColumns, int targetedID, string ID_field)
        {
            var service = new TableDMLManagement();
            return service.GetValuesFromColumns(targetedDB, targetedTable, targetedColumns, targetedID, ID_field);
        }

        public static List<JObject> getAllRecords(string targetedDB, string targetedTable)
        {
            var service = new TableDMLManagement();
            return service.getAllRecords(targetedDB, targetedTable);
        }

        public static int deleteRow(string targetedDB, string targetedTable, string IdColumnName, int targetedID)
        {
            var service = new TableDMLManagement();
            return service.deleteRow(targetedDB, targetedTable, IdColumnName, targetedID);
        }
    }
}

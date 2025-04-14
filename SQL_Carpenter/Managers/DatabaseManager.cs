using Newtonsoft.Json.Linq;
using SQL_Carpenter.Services.DDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Carpenter.Managers
{
    internal class DatabaseManager
    {
        public static List<JObject> GetAllDatabases()
        {
            var service = new GetAllDB();
            return service.getAllDataBases();
        }

        public static int CreateDatabase(string databaseName)
        {
            var service = new CreateDB();
            return service.CreateDatabase(databaseName);
        }
        public static int DeleteDatabase(string database_name)
        {
            var service = new DropDB();
            return service.DropDatabase(database_name);
        }

        public static int CreateTable(string database_name, string table_name, string primary_key, Dictionary<string, string> field_type_pair)
        {
            var service = new TableManagement();
            return service.CreateTable(database_name, table_name, primary_key, field_type_pair);
        }

        public static List<JObject> GetAllTables(string database_name)
        {
            var service = new TableManagement();
            return service.GetAllTables(database_name);
        }

        public static int DropTable(string database_name, string table_name)
        {
            var service = new TableManagement();
            return service.DropTable(database_name, table_name);
        }
    }
}

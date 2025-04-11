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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Carpenter.Data
{
    public class ConnectionSettings
    {
        private static ConnectionSettings _instance;
        public static readonly object _lock = new object();

        public string Server {  get; private set; }
        public string User {  get; private set; }
        public string Password { get; private set; }

        private ConnectionSettings(string server, string user, string password)
        {
            Server = server;
            User = user;
            Password = password;
        }

        public static void Configure(string server, string user, string password)
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new ConnectionSettings(server, user, password);
            }
        }
        public static ConnectionSettings Instance
        {
            get
            {
                if (_instance == null)
                    throw new InvalidOperationException("ConnectionSettings is not configured.");
                
                return _instance;
            }
        }
    }

}

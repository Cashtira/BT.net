using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.DAL
{
    internal class Connection
    {
        static string serverName = "localhost";
        static string databaseName = "FARM";
        public static string getConnectionString()
        {
            return "Data Source="+serverName+";Initial Catalog="+databaseName+";Integrated Security=True;";
        }
    }
}

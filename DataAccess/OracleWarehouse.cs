using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    class OracleWarehouse : IWarehouse
    {
        private static string Name = "Oracle";
        string ConnectionString  {get; set; }
        public OracleWarehouse(string connectionstring)
        {
            ConnectionString = connectionstring;
        }

        void IWarehouse.CreateDatabase() => Console.WriteLine($"{Name} DB created");
        void IWarehouse.ConnectToDB() => Console.WriteLine($"{Name} DB server connected");
        void IWarehouse.ImplementSQLCommand() => Console.WriteLine($"SQL command implemented to {Name} server");
        void IWarehouse.CreateObject() => Console.WriteLine($"Object created on {Name} server");
        void IWarehouse.DeleteTable() => Console.WriteLine($"Rows deleted from {Name} server");
        void IWarehouse.UpdateTable() => Console.WriteLine($"Rows updated on {Name} server");
        void IWarehouse.DropObject() => Console.WriteLine($"Object dropped on {Name} server");
        void IWarehouse.CreateUser() => Console.WriteLine($"User created on {Name} server");
        void IWarehouse.SelectCommand() => Console.WriteLine($"Select command implemented on {Name} server");
        void IWarehouse.GetServerDate()=> Console.WriteLine($"Server date on {Name} server: .....");



    }
}

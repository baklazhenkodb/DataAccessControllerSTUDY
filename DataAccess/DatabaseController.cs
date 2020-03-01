using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DatabaseController
    {
        public IWarehouse CurrentWarehouse;
        public DatabaseController(IWarehouse currentwarehouse)
        {
            CurrentWarehouse = currentwarehouse;
            if (currentwarehouse == null) throw new Exception("Wrong database service name");
        }
    }
}

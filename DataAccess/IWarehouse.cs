using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
     public interface IWarehouse
    {
        void CreateDatabase();
        void ConnectToDB();
        void ImplementSQLCommand();
        void CreateObject();
        void  SelectCommand();
        void GetServerDate();
        void DeleteTable();
        void UpdateTable();
        void DropObject();
        void CreateUser();

    }
}

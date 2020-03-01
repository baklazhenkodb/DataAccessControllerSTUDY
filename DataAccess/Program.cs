using System;
using System.Collections.Generic;

namespace DataAccess
{
    class Program
    {
        /// <summary>
        /// Main - точка входа в программу, существует только для демонстрации работы 
        /// класса-контроллера
        /// </summary>
        /// <param name="MyWareHouse">Создает класс-контроллер для выполнения ращличных операций с бд</param>
        /// <param name="CommandList">Список команд для выполнения</param>
        static void Main(string[] args)
        {
            string DatabaseName = "mysql";
            DatabaseController MyWarehouse;
            List<String> CommandList = new List<String>();
            CommandList.Add("ImplementSQLCommand");
            CommandList.Add("CreateObject");
            CommandList.Add("CreateUser");
            CommandList.Add("DropObject");
            
            try
            {
                switch (DatabaseName.ToLower())
                {
                    case "oracle":
                        MyWarehouse = new DatabaseController(new OracleWarehouse("Some connection string"));
                        Console.WriteLine("Connected to Oracle Database");
                        break;
                    case "postgresql":
                        MyWarehouse = new DatabaseController(new PostgreSQLWarehouse("Some connection string"));
                        Console.WriteLine("Connected to PostgeSQL Database");
                        break;
                    case "mysql":
                        MyWarehouse = new DatabaseController(new MySQLWarehouse("Some connection string"));
                        Console.WriteLine("Connected to MySQL Database");
                        break;
                    default:
                        MyWarehouse = new DatabaseController(null);
                        break;
                }
                Console.WriteLine("-----------------------");
                foreach (string command in CommandList)
                {
                    try
                    {
                        switch (command)
                        {
                            case "ImplementSQLCommand":
                                MyWarehouse.CurrentWarehouse.ImplementSQLCommand();
                                break;
                            case "CreateObject":
                                MyWarehouse.CurrentWarehouse.CreateObject();
                                break;
                            case "CreateUser":
                                MyWarehouse.CurrentWarehouse.CreateUser();
                                break;
                            case "DropObject":
                                MyWarehouse.CurrentWarehouse.DropObject();
                                break;
                            case "ConnectToDB":
                                MyWarehouse.CurrentWarehouse.ConnectToDB();
                                break;
                            case "CreateDatabase":
                                MyWarehouse.CurrentWarehouse.CreateDatabase();
                                break;
                            case "SelectCommand":
                                MyWarehouse.CurrentWarehouse.SelectCommand();
                                break;
                            case "GetServerDate":
                                MyWarehouse.CurrentWarehouse.GetServerDate();
                                break;
                            case "DeleteTable":
                                MyWarehouse.CurrentWarehouse.DeleteTable();
                                break;
                            case "UpdateTable":
                                MyWarehouse.CurrentWarehouse.UpdateTable();
                                break;
                            default:
                                throw new Exception("Wrong command name");
                        }
                    } catch(Exception ex) { Console.WriteLine(ex.Message); }
                }                
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }


    }
}

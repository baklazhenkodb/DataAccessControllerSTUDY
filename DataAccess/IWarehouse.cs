using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    /// <summary>
    /// Интерфейс, описывающий общие взаимодействия с системой хранения данный,
    /// которые впоследствии реализуются непосредственно в классах - хранилищах
    /// </summary>
    /// 
     public interface IWarehouse
    {
        /// <summary>
        /// Метод создания базы данных в рамках конректного сервера
        /// </summary>
        void CreateDatabase();
        /// <summary>
        /// Метод подключения к серверу хранилища
        /// </summary>
        void ConnectToDB();
        /// <summary>
        /// Метод выполнения произвольной SQL команды
        /// </summary>
        void ImplementSQLCommand();
        /// <summary>
        /// Метод создания объекта
        /// </summary>
        void CreateObject();
        /// <summary>
        /// Метод выполнения команды SELECT
        /// </summary>
        void SelectCommand();
        /// <summary>
        /// Получение даты и времени сервера
        /// </summary>
        void GetServerDate();
        /// <summary>
        /// Метод удаления таблицы из хранилища
        /// </summary>
        void DeleteTable();
        /// <summary>
        /// Метод обновления таблицы хранилища
        /// </summary>
        void UpdateTable();
        /// <summary>
        /// Метод удаления объекта
        /// </summary>
        void DropObject();
        /// <summary>
        /// Метод создания пользователя хранилища
        /// </summary>
        void CreateUser();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    /// <summary>
    /// Класс DatabaseController реализует контроллер для взаимодействия с различными (возможно - разными)
    /// системами хранения данных
    /// </summary>
    /// <param name="CurrentWarehouse">Создает экземпляр общего интерфейса системы хранения данных</param>
    public class DatabaseController
    {
        public IWarehouse CurrentWarehouse;
        public DatabaseController(IWarehouse currentwarehouse)
        {
            if (currentwarehouse == null) throw new Exception("Wrong database service name");
            CurrentWarehouse = currentwarehouse;
        }
    }
}

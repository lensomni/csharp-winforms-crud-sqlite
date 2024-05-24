using System.Collections.Generic;

namespace oop_kr.Models
{
    /// <summary>
    /// Интерфейс репозитория для работы с заказанными блюдами.
    /// </summary>
    public interface IOrderedDishRepository
    {
        /// <summary>
        /// Получает все заказанные блюда из базы данных.
        /// </summary>
        /// <returns>Коллекция всех заказанных блюд.</returns>
        IEnumerable<OrderedDish> GetAll();
    }
}
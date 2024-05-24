using System.Collections.Generic;
using System.Data.SQLite;

namespace oop_kr.Models
{
    /// <summary>
    /// Репозиторий для работы с заказанными блюдами.
    /// </summary>
    public class OrderedDishRepository : BaseRepository, IOrderedDishRepository
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrderedDishRepository"/> с указанной строкой подключения.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных SQLite.</param>
        public OrderedDishRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Получает все заказанные блюда из базы данных.
        /// </summary>
        /// <returns>Коллекция всех заказанных блюд.</returns>
        public IEnumerable<OrderedDish> GetAll()
        {
            var orderedDishList = new List<OrderedDish>();
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand("SELECT * FROM OrderedDishes", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderedDish orderedDish = new OrderedDish
                        {
                            Id = reader.GetInt32(0),
                            OrderId = reader.GetInt32(1),
                            DishId = reader.GetInt32(2),
                            Quantity = reader.GetInt32(3)
                        };
                        orderedDishList.Add(orderedDish);
                    }
                }
            }
            return orderedDishList;
        }
    }
}

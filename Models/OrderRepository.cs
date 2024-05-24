using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace oop_kr.Models
{
    /// <summary>
    /// Репозиторий для работы с заказами.
    /// </summary>
    internal class OrderRepository : BaseRepository, IOrderRepository
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrderRepository"/> с указанной строкой подключения.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных SQLite.</param>
        public OrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Добавляет заказ в базу данных и возвращает его идентификатор.
        /// </summary>
        /// <param name="order">Добавляемый заказ.</param>
        /// <returns>Идентификатор добавленного заказа.</returns>
        public int AddAndGetOrderId(Order order)
        {
            int orderId;
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(connection))
            {
                connection.Open();

                command.CommandText = "INSERT INTO Orders (datetime, total_amount)" +
                                        " VALUES (@datetime, @total_amount); SELECT last_insert_rowid()";
                command.Parameters.AddWithValue("@datetime", order.DateTime);
                command.Parameters.AddWithValue("@total_amount", order.TotalAmount);

                orderId = Convert.ToInt32(command.ExecuteScalar());
            }
            return orderId;
        }

        /// <summary>
        /// Добавляет элементы заказа в базу данных.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа.</param>
        /// <param name="items">Список элементов заказа.</param>
        public void AddOrderItems(int orderId, List<OrderItem> items)
        {
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(connection))
            {
                connection.Open();

                foreach (var item in items)
                {
                    command.CommandText = "INSERT INTO OrderedDishes (order_id, dish_id, quantity)" +
                                          " VALUES (@order_id, @dish_id, @quantity)";
                    command.Parameters.AddWithValue("@order_id", orderId);
                    command.Parameters.AddWithValue("@dish_id", item.Dish.Id);
                    command.Parameters.AddWithValue("@quantity", item.Quantity);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                }
            }
        }

        /// <summary>
        /// Удаляет заказ из базы данных по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого заказа.</param>
        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand("DELETE FROM Orders WHERE id = @id", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Получает все заказы из базы данных.
        /// </summary>
        /// <returns>Коллекция всех заказов.</returns>
        public IEnumerable<Order> GetAll()
        {
            var orderList = new List<Order>();
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand("SELECT * FROM Orders", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order order = new Order
                        {
                            Id = reader.GetInt32(0),
                            DateTime = reader.GetDateTime(1),
                            TotalAmount = reader.GetDecimal(2)
                        };
                        orderList.Add(order);
                    }
                }
            }
            return orderList;
        }

        /// <summary>
        /// Получает информацию о заказе по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <returns>Информация о заказе.</returns>
        public Order GetOrderInfo(int id)
        {
            string query = @"
                SELECT 
                    Orders.id AS OrderId, 
                    Orders.datetime AS OrderDateTime, 
                    GROUP_CONCAT(Dishes.name || ' (' || OrderedDishes.quantity || ')', ', ') AS DishesInfo,
                    Orders.total_amount AS TotalAmount
                FROM 
                    Orders
                JOIN 
                    OrderedDishes ON Orders.id = OrderedDishes.order_id
                JOIN 
                    Dishes ON OrderedDishes.dish_id = Dishes.id
                WHERE
                    Orders.id = @id
                GROUP BY 
                    Orders.id;";

            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return new Order
                        {
                            Id = reader.GetInt32(0),
                            DateTime = reader.GetDateTime(1),
                            DishesInfo = reader.GetString(2),
                            TotalAmount = reader.GetDecimal(3)
                        };
                    else
                        return null;
                }
            }
        }
    }
}
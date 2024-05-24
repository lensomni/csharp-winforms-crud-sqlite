using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace oop_kr.Models
{
    /// <summary>
    /// Представляет репозиторий для анализа данных о продажах продуктов.
    /// </summary>
    public class AnalyticsRepository : BaseRepository, IAnalyticsRepository
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса с указанной строкой подключения.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных SQLite.</param>
        public AnalyticsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Получает сводку продаж продуктов в указанном диапазоне дат.
        /// </summary>
        /// <param name="startDate">Начальная дата периода анализа.</param>
        /// <param name="endDate">Конечная дата периода анализа.</param>
        /// <returns>Словарь, содержащий ценовые диапазоны как ключи и общее количество проданных продуктов как значения.</returns>
        public Dictionary<string, int> GetProductAnalysis(DateTime startDate, DateTime endDate)
        {
            var rangeTotals = new Dictionary<string, int>();
            string query = @"
                SELECT D.price AS Price, SUM(OD.quantity) AS QuantitySold
                FROM OrderedDishes OD
                INNER JOIN Dishes D ON D.id = OD.dish_id
                INNER JOIN Orders O ON O.id = OD.order_id
                WHERE O.datetime BETWEEN @fromDate AND @toDate
                GROUP BY D.price;
            ";

            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.Add("@fromDate", DbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", DbType.DateTime).Value = endDate;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal price = reader.GetDecimal(0);
                        int quantitySold = reader.GetInt32(1);
                        
                        string priceRange = GetPriceRangeDescription(price);
                        if (rangeTotals.ContainsKey(priceRange))
                            rangeTotals[priceRange] += quantitySold;
                        else
                            rangeTotals[priceRange] = quantitySold;
                    }
                }
            }
            return rangeTotals;
        }

        /// <summary>
        /// Получает описание ценового диапазона на основе указанной цены.
        /// </summary>
        /// <param name="price">Цена продукта.</param>
        /// <returns>Описание ценового диапазона.</returns>
        private string GetPriceRangeDescription(decimal price)
        {
            switch (price)
            {
                case decimal p when p <= 500:
                    return "0-500";
                case decimal p when p <= 1000:
                    return "501-1000";
                case decimal p when p <= 2000:
                    return "1001-2000";
                case decimal p when p <= 5000:
                    return "2001-5000";
                default:
                    return "5000+";
            }
        }

        /// <summary>
        /// Получает подробные данные о продажах продуктов в указанном диапазоне дат.
        /// </summary>
        /// <param name="startDate">Начальная дата периода анализа.</param>
        /// <param name="endDate">Конечная дата периода анализа.</param>
        /// <returns>Список объектов OrderItem, содержащий подробности о каждом проданном блюде.</returns>
        public List<OrderItem> GetDetailedProductAnalysis(DateTime startDate, DateTime endDate)
        {
            var analysisData = new List<OrderItem>();
            string query = @"
                SELECT D.id, D.name, D.description, D.price, D.category, SUM(OD.quantity) AS QuantitySold
                FROM OrderedDishes OD
                INNER JOIN Dishes D ON D.id = OD.dish_id
                INNER JOIN Orders O ON O.id = OD.order_id
                WHERE O.datetime BETWEEN @fromDate AND @toDate
                GROUP BY D.id, D.name, D.description, D.price, D.category;
            ";

            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.Add("@fromDate", DbType.DateTime).Value = startDate;
                command.Parameters.Add("@toDate", DbType.DateTime).Value = endDate;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dish = new Dish
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Category = reader.GetString(4)
                        };

                        var orderItem = new OrderItem
                        {
                            Dish = dish,
                            Quantity = reader.GetInt32(5)
                        };

                        analysisData.Add(orderItem);
                    }
                }
            }
            return analysisData;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using oop_kr.Models;

namespace oop_kr
{
    /// <summary>
    /// Вспомогательный класс для работы с базой данных.
    /// </summary>
    public class DataBaseHelper
    {
        /// <summary>
        /// Строка подключения к базе данных SQLite.
        /// </summary>
        public const string connectionString = @"Data Source=C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\kr_restaurant.db;";
        private const string dbFilePath = @"C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\kr_restaurant.db";
        private const string dishesJsonFilePath = @"C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\dishes.json";
        private const string ordersJsonFilePath = @"C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\orders.json";
        private const string orderedDishesJsonFilePath = @"C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\ordered_dishes.json";

        /// <summary>
        /// Инициализация (файла) базы данных.
        /// </summary>
        public static void InitializeDatabase()
        {
            try
            {
                if (!File.Exists(dbFilePath))
                {
                    SQLiteConnection.CreateFile(dbFilePath);
                    CreateTables();
                    AddSampleData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании базы данных: {ex.Message}");
            }
        }

        /// <summary>
        /// Добавление таблиц в бд.
        /// </summary>
        private static void CreateTables()
        {
            string createDishesTable = @"
                CREATE TABLE IF NOT EXISTS Dishes(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT NOT NULL,
                description TEXT,
                price DECIMAL(10, 2) NOT NULL,
                category TEXT NOT NULL
            );";
            string createOrdersTable = @"
                CREATE TABLE IF NOT EXISTS Orders(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                datetime DATETIME,
                total_amount DECIMAL(10, 2) NOT NULL
            );";
            string createOrderedDishesTable = @"
                CREATE TABLE IF NOT EXISTS OrderedDishes(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                order_id INTEGER,
                dish_id INTEGER,
                quantity INTEGER NOT NULL,
                FOREIGN KEY (order_id) REFERENCES Orders(id),
                FOREIGN KEY (dish_id) REFERENCES Dishes(id)
            );";

            ExecuteNonQuery(createDishesTable);
            ExecuteNonQuery(createOrdersTable);
            ExecuteNonQuery(createOrderedDishesTable);
        }

        private static void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString, true))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Добавление первичныъх данных в бд.
        /// </summary>
        private static void AddSampleData()
        {
            string[] names = {
                "Тирамису", "Чизкейк", "Мороженое", // Десерты               
                "Паста", "Стейк", "Пицца", // Основные блюда                
                "Борщ", "Суп из тыквы", "Куриный бульон", // Супы                
                "Цезарь", "Греческий салат", "Оливье", // Салаты               
                "Кофе", "Чай", "Лимонад" // Напитки
            };

            string[] descriptions = {
                // Десерты
                "Классический итальянский десерт", "Нежный чизкейк с клубникой", "Пломбир с шоколадным соусом",
                // Основные блюда
                "Лучшая паста в городе", "Нежный стейк из мраморной говядины", "Ароматная пицца с томатным соусом",
                // Супы
                "Традиционный борщ с говядиной", "Крем-суп из тыквы с имбирем", "Легкий куриный бульон",
                // Салаты
                "Свежий салат Цезарь с курицей", "Греческий салат с фетой", "Классический салат Оливье",
                // Напитки
                "Кофе с молоком", "Зеленый чай", "Освежающий лимонад"
            };

            decimal[] prices = {
                300.99m, 400.50m, 150.75m,
                1200.99m, 2400.99m, 1499.99m,
                600.99m, 700.50m, 500.99m,
                800.49m, 700.49m, 600.49m,
                100.99m, 80.49m, 120.99m
            };

            string[] categories = {
                "Десерты", "Десерты", "Десерты",
                "Основные блюда", "Основные блюда", "Основные блюда",
                "Супы", "Супы", "Супы",
                "Салаты", "Салаты", "Салаты",
                "Напитки", "Напитки", "Напитки"
            };

            string insertDishQuery = @"
                INSERT INTO Dishes (name, description, price, category)
                VALUES (@name, @description, @price, @category);";

            string insertOrderQuery = @"
                INSERT INTO Orders (datetime, total_amount)
                VALUES (datetime('now'), @totalAmount);";

            string insertOrderedDishQuery = @"
                INSERT INTO OrderedDishes (order_id, dish_id, quantity)
                VALUES (@orderId, @dishId, @quantity);";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString, true))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    try
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            command.CommandText = insertDishQuery;
                            command.Parameters.AddWithValue("@name", names[i]);
                            command.Parameters.AddWithValue("@description", descriptions[i]);
                            command.Parameters.AddWithValue("@price", prices[i]);
                            command.Parameters.AddWithValue("@category", categories[i]);
                            command.ExecuteNonQuery();

                            decimal totalAmount = 0m;
                            int dishCount = new Random().Next(1, 5);
                            for (int j = 0; j < dishCount; j++)
                            {
                                int dishId = new Random().Next(1, names.Length) + 1;
                                int quantity = new Random().Next(1, 3);
                                totalAmount += prices[dishId - 1] * quantity;
                            }

                            command.CommandText = insertOrderQuery;
                            command.Parameters.AddWithValue("@totalAmount", totalAmount);
                            command.ExecuteNonQuery();

                            long orderId = connection.LastInsertRowId;

                            for (int j = 0; j < dishCount; j++)
                            {
                                int dishId = new Random().Next(1, names.Length) + 1;
                                int quantity = new Random().Next(1, 3);

                                command.CommandText = insertOrderedDishQuery;
                                command.Parameters.AddWithValue("@orderId", orderId);
                                command.Parameters.AddWithValue("@dishId", dishId);
                                command.Parameters.AddWithValue("@quantity", quantity);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Удаляет базу данных.
        /// </summary>
        public bool DeleteDataBase()
        {
            try
            {
                if (File.Exists(dbFilePath))
                {
                    File.Delete(dbFilePath);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении базы данных: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Создает базу данных.
        /// </summary>
        public bool CreateDataBase()
        {
            try
            {
                if (!File.Exists(dbFilePath))
                {
                    SQLiteConnection.CreateFile(dbFilePath);
                    CreateTables();

                    var result = MessageBox.Show("Внести начальные данные?", "Инициализация базы данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        AddSampleData();

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании базы данных: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Проверяет существование базы данных (файла).
        /// </summary>
        public static bool DataBaseExists() => File.Exists(dbFilePath);

        /// <summary>
        /// Сохраняет данные в формате JSON.
        /// </summary>
        public bool SaveJSON(IEnumerable<Dish> dishes, IEnumerable<Order> orders, IEnumerable<OrderedDish> orderedDishes)
        {
            try
            {
                if (!DataBaseExists())
                {
                    MessageBox.Show("База данных не существует. Пожалуйста, создайте базу данных перед выполнением этого действия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string dishesJson = JsonConvert.SerializeObject(dishes, Formatting.Indented);
                File.WriteAllText(dishesJsonFilePath, dishesJson);

                string ordersJson = JsonConvert.SerializeObject(orders, Formatting.Indented);
                File.WriteAllText(ordersJsonFilePath, ordersJson);

                string orderedDishesJson = JsonConvert.SerializeObject(orderedDishes, Formatting.Indented);
                File.WriteAllText(orderedDishesJsonFilePath, orderedDishesJson);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в JSON: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}


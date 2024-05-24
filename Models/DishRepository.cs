using System.Collections.Generic;
using System.Data.SQLite;

namespace oop_kr.Models
{
    /// <summary>
    /// Репозиторий для работы с блюдами.
    /// </summary>
    public class DishRepository : BaseRepository, IDishRepository
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса с указанной строкой подключения.
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных SQLite.</param>
        public DishRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Добавляет новое блюдо в базу данных.
        /// </summary>
        /// <param name="dish">Добавляемое блюдо.</param>
        public void Add(Dish dish)
        {
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = "INSERT INTO Dishes (name, description, price, category)" +
                                       " VALUES (@name, @description, @price, @category)";
                connection.Open();

                command.Parameters.AddWithValue("@name", dish.Name);
                command.Parameters.AddWithValue("@description", dish.Description);
                command.Parameters.AddWithValue("@price", dish.Price);
                command.Parameters.AddWithValue("@category", dish.Category);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Редактирует информацию о существующем блюде в базе данных.
        /// </summary>
        /// <param name="dish">Измененные данные блюда.</param>
        public void Edit(Dish dish)
        {
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = "UPDATE Dishes SET name = @name, description = @description, " +
                    "price = @price, category = @category WHERE id = @id";
                connection.Open();

                command.Parameters.AddWithValue("@name", dish.Name);
                command.Parameters.AddWithValue("@description", dish.Description);
                command.Parameters.AddWithValue("@price", dish.Price);
                command.Parameters.AddWithValue("@category", dish.Category);
                command.Parameters.AddWithValue("@id", dish.Id);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Удаляет блюдо из базы данных по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого блюда.</param>
        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand("DELETE FROM Dishes WHERE id = @id", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Получает все блюда из базы данных.
        /// </summary>
        /// <returns>Коллекция всех блюд.</returns>
        public IEnumerable<Dish> GetAll()
        {
            var dishList = new List<Dish>();
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand("SELECT * FROM Dishes", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dish dish = new Dish
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Category = reader.GetString(4)
                        };
                        dishList.Add(dish);
                    }
                }
            }
            return dishList;
        }

        /// <summary>
        /// Получает блюда из базы данных по заданному имени и максимальной цене.
        /// </summary>
        /// <param name="name">Искомое имя блюда (частичное совпадение).</param>
        /// <param name="maxPrice">Максимальная цена блюда.</param>
        /// <returns>Коллекция найденных блюд.</returns>
        public IEnumerable<Dish> GetByValue(string name, decimal maxPrice)
        {
            var dishList = new List<Dish>();
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = "SELECT * FROM Dishes WHERE name LIKE @searchName AND price <= @maxPrice";
                command.Parameters.AddWithValue("@searchName", "%" + name + "%");
                command.Parameters.AddWithValue("@maxPrice", maxPrice);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dish dish = new Dish
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Category = reader.GetString(4)
                        };
                        dishList.Add(dish);
                    }
                }
            }
            return dishList;
        }

        /// <summary>
        /// Получает блюда из базы данных по заданной категории.
        /// </summary>
        /// <param name="dishCategory">Искомая категория блюд.</param>
        /// <returns>Коллекция блюд из указанной категории.</returns>
        public IEnumerable<Dish> GetByCategory(string dishCategory)
        {
            var dishList = new List<Dish>();
            using (var connection = new SQLiteConnection(connectionString, true))
            using (var command = new SQLiteCommand(connection))
            {
                command.CommandText = "SELECT * FROM Dishes WHERE category LIKE @category";
                command.Parameters.AddWithValue("@category", dishCategory);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dish dish = new Dish
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Category = reader.GetString(4)
                        };
                        dishList.Add(dish);
                    }
                }
            }
            return dishList;
        }

    }
}

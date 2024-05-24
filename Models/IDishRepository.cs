using System.Collections.Generic;

namespace oop_kr.Models
{
    /// <summary>
    /// Интерфейс репозитория для работы с блюдами.
    /// </summary>
    public interface IDishRepository
    {
        /// <summary>
        /// Добавляет новое блюдо в базу данных.
        /// </summary>
        /// <param name="dish">Добавляемое блюдо.</param>
        void Add(Dish dish);

        /// <summary>
        /// Редактирует информацию о существующем блюде в базе данных.
        /// </summary>
        /// <param name="dish">Измененные данные блюда.</param>
        void Edit(Dish dish);

        /// <summary>
        /// Удаляет блюдо из базы данных по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого блюда.</param>
        void Delete(int id);

        /// <summary>
        /// Получает все блюда из базы данных.
        /// </summary>
        /// <returns>Коллекция всех блюд.</returns>
        IEnumerable<Dish> GetAll();

        /// <summary>
        /// Получает блюда из базы данных по заданному имени и максимальной цене.
        /// </summary>
        /// <param name="value">Искомое имя блюда (частичное совпадение).</param>
        /// <param name="price">Максимальная цена блюда.</param>
        /// <returns>Коллекция найденных блюд.</returns>
        IEnumerable<Dish> GetByValue(string value, decimal price);

        /// <summary>
        /// Получает блюда из базы данных по заданной категории.
        /// </summary>
        /// <param name="dishCategory">Искомая категория блюд.</param>
        /// <returns>Коллекция блюд из указанной категории.</returns>
        IEnumerable<Dish> GetByCategory(string dishCategory);
    }
}
using System.Collections.Generic;

namespace oop_kr.Models
{
    /// <summary>
    /// Интерфейс репозитория для работы с заказами.
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Удаляет заказ из базы данных по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого заказа.</param>
        void Delete(int id);

        /// <summary>
        /// Получает информацию о заказе по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <returns>Информация о заказе.</returns>
        Order GetOrderInfo(int id);

        /// <summary>
        /// Получает все заказы из базы данных.
        /// </summary>
        /// <returns>Коллекция всех заказов.</returns>
        IEnumerable<Order> GetAll();

        /// <summary>
        /// Добавляет элементы заказа в базу данных.
        /// </summary>
        /// <param name="orderId">Идентификатор заказа.</param>
        /// <param name="items">Список элементов заказа.</param>
        void AddOrderItems(int orderId, List<OrderItem> items);

        /// <summary>
        /// Добавляет заказ в базу данных и возвращает его идентификатор.
        /// </summary>
        /// <param name="order">Добавляемый заказ.</param>
        /// <returns>Идентификатор добавленного заказа.</returns>
        int AddAndGetOrderId(Order order);
    }
}
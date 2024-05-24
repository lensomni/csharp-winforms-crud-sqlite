namespace oop_kr.Models
{
    /// <summary>
    /// Модель заказанного блюда.
    /// </summary>
    public class OrderedDish
    {
        /// <summary>
        /// Уникальный идентификатор заказанного блюда.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор заказа, к которому относится блюдо.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Идентификатор блюда.
        /// </summary>
        public int DishId { get; set; }

        /// <summary>
        /// Количество заказанного блюда.
        /// </summary>
        public int Quantity { get; set; }
    }
}
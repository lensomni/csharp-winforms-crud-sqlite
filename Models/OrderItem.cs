using System.ComponentModel;

namespace oop_kr.Models
{
    /// <summary>
    /// Представляет элемент заказа.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Блюдо.
        /// </summary>
        [DisplayName("Блюдо")]
        public Dish Dish { get; set; }

        /// <summary>
        /// Количество.
        /// </summary>
        [DisplayName("Количество")]
        public int Quantity { get; set; }

        /// <summary>
        /// Общая сумма за элемент заказа.
        /// </summary>
        [DisplayName("Общая сумма")]
        public decimal TotalPrice => Dish.Price * Quantity;
    }
}
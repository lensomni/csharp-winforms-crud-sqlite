using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace oop_kr.Models
{
    /// <summary>
    /// Модель заказа.
    /// </summary>
    public class Order
    {
        private decimal _totalAmount;

        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата и время заказа.
        /// </summary>
        [DisplayName("Дата/время")]
        [Required(ErrorMessage = "Дата и время заказа обязательны.")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Общая сумма заказа.
        /// </summary>
        [DisplayName("Общая сумма")]
        [Required(ErrorMessage = "Необходимо указать общую сумму заказа")]
        [Range(1, 500_000, ErrorMessage = "Общая сумма заказа не должна превышать 500.000.")]
        public decimal TotalAmount
        {
            get => _totalAmount;
            set => _totalAmount = value;
        }

        /// <summary>
        /// Информация о блюдах в заказе (для отображения).
        /// </summary>
        public string DishesInfo { get; set; }

        /// <summary>
        /// Список элементов заказа.
        /// </summary>
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
}

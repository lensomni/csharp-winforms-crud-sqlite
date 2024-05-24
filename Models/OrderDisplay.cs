using System;
using System.ComponentModel;

namespace oop_kr.Models
{
    /// <summary>
    /// Модель отображения заказа.
    /// </summary>
    public class OrderDisplay
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата и время заказа.
        /// </summary>
        [DisplayName("Дата и время")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Общая сумма заказа.
        /// </summary>
        [DisplayName("Общая сумма")]
        public decimal TotalAmount { get; set; }
    }
}

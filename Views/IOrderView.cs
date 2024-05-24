using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace oop_kr.Views
{
    /// <summary>
    /// Интерфейс представления заказов.
    /// </summary>
    public interface IOrderView
    {
        /// <summary>
        /// Сообщение о результате операции.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Событие отображения деталей заказа.
        /// </summary>
        event EventHandler ShowOrderDetailsEvent;

        /// <summary>
        /// Событие добавления нового заказа.
        /// </summary>
        event EventHandler AddNewOrderEvent;

        /// <summary>
        /// Событие добавления нового блюда к заказу.
        /// </summary>
        event EventHandler AddNewDishToOrderEvent;

        /// <summary>
        /// Событие удаления заказа.
        /// </summary>
        event EventHandler DeleteOrderEvent;

        /// <summary>
        /// Событие удаления блюда из заказа.
        /// </summary>
        event EventHandler DeleteDishFromOrderEvent;

        /// <summary>
        /// Событие отмены операции.
        /// </summary>
        event EventHandler CancelEvent;

        /// <summary>
        /// Общая сумма заказа.
        /// </summary>
        decimal OrderTotalAmount { get; set; }

        /// <summary>
        /// Информация о заказе.
        /// </summary>
        string[] Info { get; set; }

        /// <summary>
        /// Получить ID выбранного заказа.
        /// </summary>
        int GetSelectedOrderId();

        /// <summary>
        /// Установить источник привязки для списка заказов.
        /// </summary>
        void SetOrderListBindingSource(BindingSource orderList);

        /// <summary>
        /// Отображение представления заказов.
        /// </summary>
        void Show();

        /// <summary>
        /// Обновление элементов заказа.
        /// </summary>
        /// <param name="transformedItems">Преобразованные элементы заказа.</param>
        void UpdateOrderItems(List<object> transformedItems);
    }
}

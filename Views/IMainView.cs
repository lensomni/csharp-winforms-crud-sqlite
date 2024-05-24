using System;

namespace oop_kr.Views
{
    /// <summary>
    /// Интерфейс главного представления.
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// Событие отображения меню.
        /// </summary>
        event EventHandler ShowMenu;

        /// <summary>
        /// Событие отображения заказов.
        /// </summary>
        event EventHandler ShowOrders;

        /// <summary>
        /// Событие отображения аналитики.
        /// </summary>
        event EventHandler ShowAnalytics;

        /// <summary>
        /// Событие отображения функций.
        /// </summary>
        event EventHandler ShowFeatures;
    }
}
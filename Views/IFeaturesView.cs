using System;

namespace oop_kr.Views
{
    /// <summary>
    /// Интерфейс представления функций.
    /// </summary>
    public interface IFeaturesView
    {
        /// <summary>
        /// Событие удаления базы данных.
        /// </summary>
        event EventHandler DeleteDataBaseEvent;

        /// <summary>
        /// Событие создания базы данных.
        /// </summary>
        event EventHandler CreateDataBaseEvent;

        /// <summary>
        /// Событие сохранения данных в формате JSON.
        /// </summary>
        event EventHandler SaveJSONEvent;

        /// <summary>
        /// Сообщение для отображения пользователю.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Показать представление.
        /// </summary>
        void Show();
    }
}

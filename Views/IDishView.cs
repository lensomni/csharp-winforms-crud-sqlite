using System;
using System.Windows.Forms;

namespace oop_kr.Views
{
    /// <summary>
    /// Интерфейс представления блюд.
    /// </summary>
    public interface IDishView
    {
        /// <summary>
        /// Название блюда.
        /// </summary>
        string DishName { get; set; }

        /// <summary>
        /// Описание блюда.
        /// </summary>
        string DishDescription { get; set; }

        /// <summary>
        /// Цена блюда.
        /// </summary>
        decimal DishPrice { get; set; }

        /// <summary>
        /// Категория блюда.
        /// </summary>
        string DishCategory { get; set; }

        /// <summary>
        /// Значение для поиска.
        /// </summary>
        string SearchValue { get; set; }

        string SearchResult { get; set; }    

        /// <summary>
        /// Флаг редактирования.
        /// </summary>
        bool IsEdit { get; set; }

        /// <summary>
        /// Успешность выполнения операции.
        /// </summary>
        bool IsSuccessful { get; set; }

        /// <summary>
        /// Сообщение для отображения пользователю.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Цена для поиска блюд.
        /// </summary>
        int DishSearchPrice { get; set; }

        /// <summary>
        /// Событие поиска блюда.
        /// </summary>
        event EventHandler SearchEvent;

        /// <summary>
        /// Событие добавления нового блюда.
        /// </summary>
        event EventHandler AddNewEvent;

        /// <summary>
        /// Событие редактирования блюда.
        /// </summary>
        event EventHandler EditEvent;

        /// <summary>
        /// Событие удаления блюда.
        /// </summary>
        event EventHandler DeleteEvent;

        /// <summary>
        /// Событие сохранения блюда.
        /// </summary>
        event EventHandler SaveEvent;

        /// <summary>
        /// Событие отмены действия.
        /// </summary>
        event EventHandler CancelEvent;

        /// <summary>
        /// Событие генерации меню.
        /// </summary>
        event EventHandler GenerateMenuEvent;

        /// <summary>
        /// Получить идентификатор выбранного блюда.
        /// </summary>
        /// <returns>Идентификатор выбранного блюда.</returns>
        int GetSelectedDishId();

        /// <summary>
        /// Установить источник данных для списка блюд.
        /// </summary>
        /// <param name="dishList">Источник данных для списка блюд.</param>
        void SetDishListBindingSource(BindingSource dishList);

        /// <summary>
        /// Показать представление.
        /// </summary>
        void Show();
    }
}

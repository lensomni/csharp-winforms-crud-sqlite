using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace oop_kr.Views
{
    /// <summary>
    /// Интерфейс представления аналитики.
    /// </summary>
    public interface IAnalyticsView
    {
        /// <summary>
        /// Показывает представление.
        /// </summary>
        void Show();

        /// <summary>
        /// Событие выбора диапазона дат.
        /// </summary>
        event EventHandler DateRangeSelectedEvent;

        /// <summary>
        /// Событие генерации отчета.
        /// </summary>
        event EventHandler GenerateReportEvent;

        /// <summary>
        /// Обновляет график анализа спроса.
        /// </summary>
        /// <param name="data">Данные для обновления графика.</param>
        Task UpdateDemandAnalysisChart(Dictionary<string, int> data);

        /// <summary>
        /// Начальная дата.
        /// </summary>
        DateTime StartDateTime { get; set; }

        /// <summary>
        /// Конечная дата.
        /// </summary>
        DateTime EndDateTime { get; set; }

        /// <summary>
        /// Сообщение для отображения пользователю.
        /// </summary>
        string Message { get; set; }
    }
}
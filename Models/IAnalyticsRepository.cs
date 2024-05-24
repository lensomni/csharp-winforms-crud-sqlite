using System;
using System.Collections.Generic;

namespace oop_kr.Models
{
    /// <summary>
    /// Интерфейс репозитория аналитики продуктов.
    /// </summary>
    public interface IAnalyticsRepository
    {
        /// <summary>
        /// Получает анализ продуктов за указанный период времени.
        /// </summary>
        /// <param name="startDate">Начальная дата периода.</param>
        /// <param name="endDate">Конечная дата периода.</param>
        /// <returns>Словарь, содержащий ценовые диапазоны и количество проданных продуктов.</returns>
        Dictionary<string, int> GetProductAnalysis(DateTime startDate, DateTime endDate);

        /// <summary>
        /// Получает подробный анализ продуктов за указанный период времени.
        /// </summary>
        /// <param name="startDate">Начальная дата периода.</param>
        /// <param name="endDate">Конечная дата периода.</param>
        /// <returns>Список объектов OrderItem, содержащий информацию о проданных продуктах.</returns>
        List<OrderItem> GetDetailedProductAnalysis(DateTime startDate, DateTime endDate);
    }
}

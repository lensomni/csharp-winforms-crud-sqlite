using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_kr.Models;
using oop_kr.Views;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using oop_kr.Utils;

namespace oop_kr.Presenters
{
    /// <summary>
    /// Презентер для аналитики.
    /// </summary>
    public class AnalyticsPresenter
    {
        private  IAnalyticsRepository _analyticsRepository;
        private  IAnalyticsView _view;

        Dictionary<string, int> _priceRangeData;
        List<OrderItem> _reportData;

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        /// <param name="view">Представление аналитики.</param>
        /// <param name="analyticsRepository">Репозиторий аналитики.</param>
        public AnalyticsPresenter(IAnalyticsView view, IAnalyticsRepository analyticsRepository)
        {                  
            _view = view;
            _analyticsRepository = analyticsRepository;

            _view.DateRangeSelectedEvent += DateRangeSelected;
            _view.GenerateReportEvent += GenerateReport;
            _view.Show();
            LoadData(_view.StartDateTime, _view.EndDateTime);

        }

        /// <summary>
        /// Генерирует отчет и сохраняет его в файл.
        /// </summary>
        private void GenerateReport(object sender, EventArgs e)
        {
            GetReportData(_view.StartDateTime, _view.EndDateTime);
        }

        /// <summary>
        /// Получает данные для отчета и сохраняет их в файл.
        /// </summary>
        /// <param name="startDate">Дата начала анализа.</param>
        /// <param name="endDate">Дата окончания анализа.</param>
        private void GetReportData(DateTime startDate, DateTime endDate)
        {
            _reportData = _analyticsRepository.GetDetailedProductAnalysis(startDate, endDate);
            FileHelper fileHelper = new FileHelper();
            if (fileHelper.SaveAnalyticsToFile(_reportData, startDate, endDate))
                _view.Message = "Отчет сохранен";
        }

        /// <summary>
        /// Загружает данные анализа за указанный период времени.
        /// </summary>
        /// <param name="startDate">Дата начала анализа.</param>
        /// <param name="endDate">Дата окончания анализа.</param>
        private async void LoadData(DateTime startDate, DateTime endDate)
        {
            _priceRangeData = await Task.Run(() => _analyticsRepository.GetProductAnalysis(startDate, endDate));
            await _view.UpdateDemandAnalysisChart(_priceRangeData);
        }

        /// <summary>
        /// Обрабатывает событие выбора диапазона дат.
        /// </summary>
        private void DateRangeSelected(object sender, EventArgs e)
        {
            LoadData(_view.StartDateTime, _view.EndDateTime);
        }


    }
}

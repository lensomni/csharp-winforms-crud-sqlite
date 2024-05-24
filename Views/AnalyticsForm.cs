using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using oop_kr.Views;

namespace oop_kr
{
    /// <summary>
    /// Форма аналитики.
    /// </summary>
    public partial class AnalyticsForm : Form, IAnalyticsView
    {
        /// <summary>
        /// Конструктор формы AnalyticsForm. Инициализирует компоненты и устанавливает начальные настройки формы.
        /// </summary>
        public AnalyticsForm()
        {
            InitializeComponent();

            dateTimePickerStartDate.CustomFormat = "  dd/MM/yyyy   HH:mm";
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Value = DateTime.Now.AddDays(-7);

            dateTimePickerEndDate.CustomFormat = "  dd/MM/yyyy   HH:mm";
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Value = DateTime.Now;

            chartDishDemand.Series[0].Palette = ChartColorPalette.SeaGreen;
            SetFormProperties();
        }

        /// <summary>
        /// Устанавливает начальные свойства формы.
        /// </summary>
        private void SetFormProperties()
        {
            try
            {
                foreach (Control control in Controls)
                    control.Anchor = AnchorStyles.Top;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки обновления графика.
        /// </summary>
        private void ButtonRefreshChart_Click(object sender, EventArgs e)
        {
            DateRangeSelectedEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки генерации отчета.
        /// </summary>
        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        }

        // Событие, возникающее при анализе спроса
        public event EventHandler DateRangeSelectedEvent;
        // Событие, возникающее при генерации отчета
        public event EventHandler GenerateReportEvent;

        public string Message { get; set; }

        // Свойство для получения или установки начальной даты и времени
        public DateTime StartDateTime
        {
            get => dateTimePickerStartDate.Value;
            set => dateTimePickerStartDate.Value = value;
        }

        // Свойство для получения или установки конечной даты и времени
        public DateTime EndDateTime
        {
            get => dateTimePickerEndDate.Value;
            set => dateTimePickerEndDate.Value = value;
        }

        // Единственный экземпляр формы AnalyticsForm
        private static AnalyticsForm Instance;
        /// <summary>
        /// Возвращает единственный экземпляр формы AnalyticsForm.
        /// </summary>
        /// <param name="parentContainer">Родительская форма</param>
        /// <returns>Единственный экземпляр формы AnalyticsForm</returns>
        public static AnalyticsForm GetInstance(Form parentContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new AnalyticsForm
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };
            }
            else
            {
                if (Instance.WindowState == FormWindowState.Minimized)
                    Instance.WindowState = FormWindowState.Normal;
                Instance.BringToFront();
            }
            return Instance;
        }

        /// <summary>
        /// Обновляет график анализа спроса.
        /// </summary>
        /// <param name="data">Данные для графика</param>
        public async Task UpdateDemandAnalysisChart(Dictionary<string, int> data)
        {
            await Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    chartDishDemand.Series[0].Points.Clear();
                    chartDishDemand.Series[0].Points.SuspendUpdates();
                    foreach (var item in data)
                    {
                        chartDishDemand.Series[0].Points.AddXY(item.Key, item.Value);
                    }
                    chartDishDemand.Series[0].Points.ResumeUpdates();
                }));
            });
        }




    }
}
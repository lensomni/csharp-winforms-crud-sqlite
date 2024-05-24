using System;
using System.Windows.Forms;
using oop_kr.Views;

namespace oop_kr
{
    /// <summary>
    /// Форма работы с бд.
    /// </summary>
    public partial class FeaturesForm : Form, IFeaturesView
    {
        /// <summary>
        /// Конструктор формы FeaturesForm. Инициализирует компоненты и устанавливает начальные настройки формы.
        /// </summary>
        public FeaturesForm()
        {
            InitializeComponent();
            // Устанавливаем начальные свойства формы
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

        // Свойство для хранения сообщения
        public string Message { get; set; }

        // Событие, возникающее при удалении базы данных
        public event EventHandler DeleteDataBaseEvent;
        // Событие, возникающее при создании базы данных
        public event EventHandler CreateDataBaseEvent;
        // Событие, возникающее при сохранении данных в формате JSON
        public event EventHandler SaveJSONEvent;

        // Единственный экземпляр формы FeaturesForm
        private static FeaturesForm Instance;
        /// <summary>
        /// Возвращает единственный экземпляр формы FeaturesForm.
        /// </summary>
        /// <param name="parentContainer">Родительская форма</param>
        /// <returns>Единственный экземпляр формы FeaturesForm</returns>
        public static FeaturesForm GetInstance(Form parentContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FeaturesForm
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
        /// Обработчик события нажатия кнопки удаления базы данных.
        /// </summary>
        private void ButtonDeleteDataBase_Click(object sender, EventArgs e)
        {
            DeleteDataBaseEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки создания базы данных.
        /// </summary>
        private void ButtonCreateDataBase_Click(object sender, EventArgs e)
        {
            CreateDataBaseEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки сохранения данных в формате JSON.
        /// </summary>
        private void ButtonSaveToJSON_Click(object sender, EventArgs e)
        {
            SaveJSONEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        }

    }
}

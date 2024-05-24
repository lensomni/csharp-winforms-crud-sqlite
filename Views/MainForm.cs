using System;
using System.Drawing;
using System.Windows.Forms;
using oop_kr.Views;

namespace oop_kr
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form, IMainView
    {
        private int _previousFormHeight;

        /// <summary>
        /// Конструктор главной формы MainForm. Инициализирует компоненты и устанавливает начальные настройки формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        // Событие, возникающее при отображении меню
        public event EventHandler ShowMenu;
        // Событие, возникающее при отображении заказов
        public event EventHandler ShowOrders;
        // Событие, возникающее при отображении аналитики
        public event EventHandler ShowAnalytics;
        // Событие, возникающее при отображении формы работы с бд
        public event EventHandler ShowFeatures;

        /// <summary>
        /// Обработчик события загрузки главной формы MainForm.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();   
            welcomeForm.ShowDialog();
            
            Text = "22ВП2 Паткина А";
            ShowFeatures?.Invoke(this, EventArgs.Empty);
            _previousFormHeight = Height;
            MinimumSize = new Size(1100, 640);
        }

        /// <summary>
        /// Обработчик события закрытия главной формы MainForm.
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки отображения формы аналитики.
        /// </summary>
        private void ButtonShowAnalyticsForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataBaseExists())
                    ShowAnalytics?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки отображения формы функциональных возможностей.
        /// </summary>
        private void ButtonShowFeaturesForm_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFeatures?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки отображения формы меню.
        /// </summary>
        private void ButtonShowMenuForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataBaseExists())
                    ShowMenu?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки отображения формы заказов.
        /// </summary>
        private void ButtonShowOrdersForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataBaseExists())
                    ShowOrders?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Проверяет существование базы данных.
        /// </summary>
        /// <returns>True, если база данных существует, иначе - false.</returns>
        private bool CheckDataBaseExists()
        {
            if (DataBaseHelper.DataBaseExists())
            {
                return true;
            }
            else
            {
                MessageBox.Show("База данных не существует. Пожалуйста, создайте базу данных перед выполнением этого действия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_kr
{
    /// <summary>
    /// Форма для добавления блюда в заказ.
    /// </summary>
    public partial class AddDishToOrderForm : Form
    {
        private int _previousFormHeight;

        /// <summary>
        /// Конструктор формы AddDishToOrderForm. Инициализирует компоненты и устанавливает начальные настройки формы.
        /// </summary>
        public AddDishToOrderForm()
        {
            InitializeComponent();
            DataGridViewSearchDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewSearchDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            StartPosition = FormStartPosition.CenterScreen;
            SetFormProperties();
            ComboBoxCategory.SelectedItem = "Все";
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

        // Событие, которое возникает при выборе блюда
        public event EventHandler DishSelected;

        // Событие, которое возникает при поиске блюда
        public event EventHandler SearchDishEvent;

        /// <summary>
        /// Устанавливает источник данных для списка блюд.
        /// </summary>
        /// <param name="dishList">Источник данных для списка блюд</param>
        public void SetDishListBindingSource(BindingSource dishList)
        {
            DataGridViewSearchDishes.DataSource = dishList;
        }

        /// <summary>
        /// Обрабатывает событие двойного щелчка по ячейке DataGridView, вызывая событие DishSelected.
        /// </summary>
        private void DataGridViewSearchDishes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dishId = (int)DataGridViewSearchDishes.Rows[e.RowIndex].Cells["Id"].Value;
                DishSelected?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Получает или устанавливает категорию блюда.
        /// </summary>
        public string DishCategory
        {
            get => ComboBoxCategory.SelectedItem?.ToString();
            set => ComboBoxCategory.SelectedItem = value;
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле поиска блюда, вызывая событие SearchDishEvent.
        /// </summary>
        private void TextBoxSearchDishByName_TextChanged(object sender, EventArgs e)
        {
            SearchDishEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в ComboBox, вызывая событие SearchDishEvent.
        /// </summary>
        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchDishEvent?.Invoke(this, EventArgs.Empty);
        }

        private static AddDishToOrderForm _instance;
        /// <summary>
        /// Возвращает единственный экземпляр формы AddDishToOrderForm.
        /// </summary>
        public static AddDishToOrderForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AddDishToOrderForm();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Обрабатывает событие загрузки формы, устанавливая текст заголовка и минимальный размер формы.
        /// </summary>
        private void AddDishToOrderForm_Load(object sender, EventArgs e)
        {
            Text = ":)";
            _previousFormHeight = Height;
            MinimumSize = new Size(670, 414);
        }

        /// <summary>
        /// Обрабатывает событие изменения размера формы, корректируя позицию элементов управления на форме.
        /// </summary>
        private void AddDishToOrderForm_Resize(object sender, EventArgs e)
        {
            try
            {
                int heightDifference = Height - _previousFormHeight;
                double offsetCoefficient = 0.5;
                foreach (Control control in Controls)
                    control.Top += (int)(heightDifference * offsetCoefficient);

                _previousFormHeight = Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

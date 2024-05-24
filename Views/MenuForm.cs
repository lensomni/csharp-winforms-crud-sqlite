using System;
using System.Windows.Forms;
using oop_kr.Views;

namespace oop_kr
{
    /// <summary>
    /// Форма меню.
    /// </summary>
    public partial class MenuForm : Form, IDishView
    {
        /// <summary>
        /// Конструктор формы MenuForm. Инициализирует компоненты и устанавливает начальные настройки формы.
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
            dataGridViewAllDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAllDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Изменить");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");

            contextMenuStrip1.Items.AddRange(new[] { editMenuItem, deleteMenuItem });

            dataGridViewAllDishes.ContextMenuStrip = contextMenuStrip1;

            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;
            tabPage1.Text = "Блюда";
            tabControl1.TabPages.Remove(tabPage2);

            TrackBarDishPrice.Minimum = 0;
            TrackBarDishPrice.Maximum = 10000;
            TrackBarDishPrice.TickFrequency = 500;
            TrackBarDishPrice.Value = 10000;
            label1.Text = TrackBarDishPrice.Value.ToString();
            comboBoxDishCategory.SelectedIndex = 0;
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
        /// Обработчик события изменения положения ползунка для выбора цены блюда.
        /// </summary>
        private void TrackBarDishPrice_Scroll(object sender, EventArgs e)
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
            label1.Text = TrackBarDishPrice.Value.ToString();

        }

        /// <summary>
        /// Обработчик события изменения текста в поле поиска блюда.
        /// </summary>
        private void textBoxSearchDish_TextChanged(object sender, EventArgs e)
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик события нажатия пункта "Изменить" в контекстном меню DataGridView.
        /// </summary>
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            EditEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabPage2.Text = "Изменить блюдо";
        }

        // <summary>
        /// Обработчик события нажатия пункта "Удалить" в контекстном меню DataGridView.
        /// </summary>
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить это блюдо?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить блюдо".
        /// </summary>
        private void ButtonAddDish_Click(object sender, EventArgs e)
        {
            AddNewEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabPage2.Text = "Новое блюдо";
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Сохранить" на форме добавления/изменения блюда.
        /// </summary>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);
            if (IsSuccessful)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            }
            MessageBox.Show(Message);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Отмена" на форме добавления/изменения блюда.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
        }

        // Свойство для получения значения цены блюда из ползунка
        public int DishSearchPrice
        {
            get => TrackBarDishPrice.Value;
            set => TrackBarDishPrice.Value = value;
        }

        // Свойство для получения значения поискового запроса
        public string SearchValue
        {
            get => textBoxSearchDish.Text.Trim();
            set => textBoxSearchDish.Text = value;
        }

        public string SearchResult
        {
            get => labelSearchResult.Text.Trim();
            set => labelSearchResult.Text = value;
        }

        // Свойство для получения/установки имени блюда
        public string DishName
        {
            get => textBoxDishName.Text;
            set => textBoxDishName.Text = value;
        }

        // Свойство для получения/установки категории блюда
        public string DishCategory
        {
            get => comboBoxDishCategory.SelectedItem?.ToString();
            set => comboBoxDishCategory.SelectedItem = value;
        }

        // Свойство для получения/установки цены блюда
        public decimal DishPrice
        {
            get => decimal.TryParse(textBoxDishPrice.Text, out decimal price) ? price
                : throw new Exception("Неверный формат цены блюда.");
            set => textBoxDishPrice.Text = value.ToString();
        }

        // Свойство для получения/установки описания блюда
        public string DishDescription
        {
            get => textBoxDishDescription.Text;
            set => textBoxDishDescription.Text = value;
        }

        // Метод для получения идентификатора выбранного блюда из DataGridView
        public int GetSelectedDishId()
        {
            int selectedId = (int)dataGridViewAllDishes.SelectedRows[0].Cells[0].Value;
            return (selectedId != -1) ? selectedId : -1;
        }

        // Свойство для определения, происходит ли редактирование блюда
        public bool IsEdit { get; set; }

        // Свойство для определения успешности операции сохранения
        public bool IsSuccessful { get; set; }

        // Свойство для получения/установки сообщения
        public string Message { get; set; }

        // Событие, возникающее при поиске блюд
        public event EventHandler SearchEvent;
        // Событие, возникающее при добавлении нового блюда
        public event EventHandler AddNewEvent;
        // Событие, возникающее при редактировании блюда
        public event EventHandler EditEvent;
        // Событие, возникающее при удалении блюда
        public event EventHandler DeleteEvent;
        // Событие, возникающее при сохранении блюда
        public event EventHandler SaveEvent;
        // Событие, возникающее при отмене операции добавления/изменения блюда
        public event EventHandler CancelEvent;
        // Событие, возникающее при генерации меню
        public event EventHandler GenerateMenuEvent;

        // Метод для установки источника данных для DataGridView
        public void SetDishListBindingSource(BindingSource dishList)
        {
            dataGridViewAllDishes.DataSource = dishList;
        }

        // Метод для получения экземпляра формы
        private static MenuForm Instance;
        public static MenuForm GetInstance(Form parentContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new MenuForm
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

        // Обработчик события нажатия кнопки "Сгенерировать меню"
        private void ButtonGenerateMenu_Click(object sender, EventArgs e)
        {
            GenerateMenuEvent?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(Message);
        }
    }
}

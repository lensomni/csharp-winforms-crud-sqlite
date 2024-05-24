using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_kr
{
    /// <summary>
    /// Приветственная форма
    /// </summary>
    public partial class WelcomeForm : Form
    {
        private int _previousFormHeight;
        public WelcomeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
        /// Закрывает форму при нажатии на любую клавишу.
        /// </summary>
        private void WelcomeForm_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Text = "Добро пожаловать!";
            _previousFormHeight = Height;
            MinimumSize = new Size(1100, 593);
        }
        /// <summary>
        /// Метод, обрабатывающий событие изменения размера формы, корректируя позицию элементов управления на форме.
        /// </summary>
        private void WelcomeForm_Resize(object sender, EventArgs e)
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

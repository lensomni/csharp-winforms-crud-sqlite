using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using oop_kr.Views;

namespace oop_kr
{
    /// <summary>
    /// Форма для отображения и управления заказами.
    /// </summary>
    public partial class OrdersForm : Form, IOrderView
    {
        public OrdersForm()
        {
            InitializeComponent();
            dataGridViewAllOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAllOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ToolStripMenuItem showOrderDetails = new ToolStripMenuItem("Детали");
            ToolStripMenuItem deleteOrder = new ToolStripMenuItem("Удалить");

            contextMenuStrip1.Items.AddRange(new[] { showOrderDetails, deleteOrder });

            dataGridViewAllOrders.ContextMenuStrip = contextMenuStrip1;

            showOrderDetails.Click += ShowOrderDetails_Click;
            deleteOrder.Click += DeleteOrder_Click;

            tabPage1.Text = "Заказы";
            tabControl1.TabPages.Remove(tabPage2);
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
        /// Обработчик события нажатия на пункт контекстного меню "Детали".
        /// </summary>
        private void ShowOrderDetails_Click(object sender, EventArgs e)
        {
            ShowOrderDetails();
        }

        /// <summary>
        /// Обработчик события нажатия на пункт контекстного меню "Удалить".
        /// </summary>
        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить этот заказ?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteOrderEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            }
        }

        /// <summary>
        /// Обновляет список элементов заказа в DataGridView.
        /// </summary>
        /// <param name="orderItems">Список объектов, представляющих элементы заказа.</param>
        public void UpdateOrderItems(List<object> orderItems)
        {
            dataGridViewOrderItems.DataSource = orderItems.ToList();
        }

        /// <summary>
        /// Устанавливает источник привязки данных для DataGridView с заказами.
        /// </summary>
        public void SetOrderListBindingSource(BindingSource orderList)
        {
            dataGridViewAllOrders.DataSource = orderList;
        }

        // Событие, возникающее при отображении подробной информации о заказе.
        public event EventHandler ShowOrderDetailsEvent;
        // Событие, возникающее при добавлении нового заказа.
        public event EventHandler AddNewOrderEvent;
        // Событие, возникающее при добавлении нового блюда в заказ.
        public event EventHandler AddNewDishToOrderEvent;
        // Событие, возникающее при удалении заказа.
        public event EventHandler DeleteOrderEvent;
        // Событие, возникающее при удалении блюда из заказа.
        public event EventHandler DeleteDishFromOrderEvent;
        // Событие, возникающее при отмене операции.
        public event EventHandler CancelEvent;


        /// <summary>
        /// Свойство для получения или установки сообщения.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Свойство для получения или установки информации о заказе.
        /// </summary>
        public string[] Info { get; set; }

        /// <summary>
        /// Свойство для получения или установки общей суммы заказа.
        /// </summary>
        public decimal OrderTotalAmount
        {
            get => decimal.TryParse(labelOrderPrice.Text, out decimal price) ? price
                : throw new Exception("Неверный формат цены заказа.");
            set => labelOrderPrice.Text = value.ToString();
        }

        /// <summary>
        /// Возвращает идентификатор выбранного заказа.
        /// </summary>
        public int GetSelectedOrderId()
        {
            int selectedId = (int)dataGridViewAllOrders.SelectedRows[0].Cells[0].Value;
            return (selectedId != -1) ? selectedId : -1;
        }


        private static OrdersForm Instance;
        /// <summary>
        /// Получает экземпляр формы заказов.
        /// </summary>
        /// <param name="parentContainer">Родительское окно, к которому привязывается форма заказов.</param>
        /// <returns>Экземпляр формы заказов.</returns>
        public static OrdersForm GetInstance(Form parentContainer)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new OrdersForm
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

        private void dataGridViewAllOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowOrderDetails();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Детали" в контекстном меню.
        /// </summary>
        private void ShowOrderDetails()
        {
            ShowOrderDetailsEvent?.Invoke(this, EventArgs.Empty);

            MessageBox.Show(Info != null ? string.Join("\n", Info) : "Нет информации для отображения.");
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Новый заказ".
        /// </summary>
        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabPage2.Text = "Новый заказ";
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Отмена".
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить блюдо".
        /// </summary>
        private void ButtonAddDishToOrder_Click(object sender, EventArgs e)
        {
            AddNewDishToOrderEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Удалить блюдо из заказа".
        /// </summary>
        private void ButtonRemoveDishFromOrder_Click(object sender, EventArgs e)
        {
            DeleteDishFromOrderEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Оформить заказ".
        /// </summary>
        private void ButtonPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewOrderEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
                MessageBox.Show(Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
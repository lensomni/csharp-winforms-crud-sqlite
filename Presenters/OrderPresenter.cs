using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using oop_kr.Models;
using oop_kr.Utils;
using oop_kr.Views;

namespace oop_kr.Presenters
{
    /// <summary>
    /// Презентер для управления заказами.
    /// </summary>
    public class OrderPresenter
    {
        private IOrderView _view;
        private IOrderRepository _orderRepository;
        private IDishRepository _dishRepository;
        private BindingSource _orderBindingSource;
        private BindingSource _dishBindingSource;
        private IEnumerable<Order> _orderList;
        private IEnumerable<Dish> _dishList;
        private Order _order;
        private AddDishToOrderForm _dishForm;

        public OrderPresenter(IOrderView view, IOrderRepository orderRepository, IDishRepository dishRepository)
        {
            _orderBindingSource = new BindingSource();
            _dishBindingSource = new BindingSource();
            _order = new Order();
            _view = view;
            _orderRepository = orderRepository;
            _dishRepository = dishRepository;
            _view.AddNewOrderEvent += AddOrder;
            _view.AddNewDishToOrderEvent += AddDishToOrder;
            _view.DeleteOrderEvent += DeleteOrder;
            _view.DeleteDishFromOrderEvent += DeleteDishFromOrder;
            _view.ShowOrderDetailsEvent += ShowOrderDetails;
            _view.CancelEvent += CancelAction;

            _view.SetOrderListBindingSource(_orderBindingSource);
            LoadAllDishList();
            LoadAllOrderList();
            _view.Show();
        }

        /// <summary>
        /// Очищает после после нажатия "Отмена".
        /// </summary>
        private void CancelAction(object sender, EventArgs e)
        {
            CleanOrderItems();
        }

        /// <summary>
        /// Очищает список блюд в заказе.
        /// </summary>
        private void CleanOrderItems()
        {
            _order.Items.Clear();
            UpdateOrderItemsAndDisplay(_order.Items);
            _view.OrderTotalAmount = 0;
        }

        private void DeleteDishFromOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Добавляет блюдо к заказу.
        /// </summary>
        private void AddDishToOrder(object sender, EventArgs e)
        {
            _dishForm = AddDishToOrderForm.Instance;
            _dishForm.SetDishListBindingSource(_dishBindingSource);
            _dishForm.DishSelected += AddDishToOrderForm_DishSelected;
            _dishForm.SearchDishEvent += AddDishToOrderForm_SearchDish;
            _dishForm.Show();
        }

        /// <summary>
        /// Обновляет список блюд в форме с добавлением в соответсвии с выбранной категорией.ы
        /// </summary>

        private void AddDishToOrderForm_SearchDish(object sender, EventArgs e)
        {
            _dishList = (_dishForm.DishCategory == "Все")
                ? _dishRepository.GetAll()
                : _dishRepository.GetByCategory(_dishForm.DishCategory);

            _dishBindingSource.DataSource = _dishList;
        }

        /// <summary>
        /// Обновляет список блюд и отображает его.
        /// </summary>
        private void UpdateOrderItemsAndDisplay(IEnumerable<OrderItem> orderItems)
        {
            var transformedItems = orderItems.Select(item =>
                new
                {
                    Название = item.Dish.Name,
                    Цена = item.Dish.Price,
                    Количество = item.Quantity,
                    ИтоговаяЦена = item.TotalPrice
                }
            ).ToList<object>();

            _view.UpdateOrderItems(transformedItems);
        }

        /// <summary>
        /// Обрабатывает выбор блюда в форме добавления блюда к заказу.
        /// </summary>
        private void AddDishToOrderForm_DishSelected(object sender, EventArgs e)
        {
            if (_dishBindingSource.Current is Dish selectedDish)
            {
                var orderItem = new OrderItem
                {
                    Dish = selectedDish,
                    Quantity = 1
                };
                _order.Items.Add(orderItem);
                UpdateOrderItemsAndDisplay(_order.Items);
                _view.OrderTotalAmount = _order.Items.Sum(item => item.Dish.Price * item.Quantity);
                //dishForm.Close();
            }
        }

        /// <summary>
        /// Отображает детали заказа.
        /// </summary>
        private void ShowOrderDetails(object sender, EventArgs e)
        {
            var orderId = _view.GetSelectedOrderId();
            var orderInfo = _orderRepository.GetOrderInfo(orderId);
            if (orderInfo != null)
            {
                _view.Info = new string[] {
                    $"ID: {orderInfo.Id}",
                    $"Дата: {orderInfo.DateTime}",
                    $"Блюда: {orderInfo.DishesInfo}",
                    $"Сумма: {orderInfo.TotalAmount}"
                };
            }
            else
            {
                MessageBox.Show("Не найдено информации по заказу.");
            }
        }

        /// <summary>
        /// Удаляет заказ.
        /// </summary>
        private void DeleteOrder(object sender, EventArgs e)
        {
            try
            {
                var orderId = _view.GetSelectedOrderId();
                _orderRepository.Delete(orderId);
                _view.Message = "Заказ удален";
                LoadAllOrderList();
            }
            catch (Exception)
            {
                _view.Message = "Ошибка при попытке удалить заказ";
            }
        }

        /// <summary>
        /// Добавляет новый заказ.
        /// </summary>
        private void AddOrder(object sender, EventArgs e)
        {
            try
            {
                if (_order.Items == null || !_order.Items.Any())
                    throw new Exception("Добавьте хотя бы одно блюдо к заказу.");

                var model = new Order
                {
                    DateTime = DateTime.Now,
                    TotalAmount = _view.OrderTotalAmount,
                    Items = _order.Items
                };
                new ModelDataValidator().Validate(model);

                int orderId = _orderRepository.AddAndGetOrderId(model);
                _orderRepository.AddOrderItems(orderId, model.Items);

                _view.Message = "Заказ добавлен.";

                LoadAllOrderList();
                CleanOrderItems();
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
                throw;
            }
        }

        /// <summary>
        /// Загружает список всех блюд.
        /// </summary>
        private void LoadAllDishList()
        {
            _dishList = _dishRepository.GetAll();
            _dishBindingSource.DataSource = _dishList;
        }

        /// <summary>
        /// Загружает список всех заказов.
        /// </summary>
        private void LoadAllOrderList()
        {
            _orderList = _orderRepository.GetAll();
            var simplifiedOrderList = _orderList.Select(order => new OrderDisplay
            {
                Id = order.Id,
                DateTime = order.DateTime,
                TotalAmount = order.TotalAmount
            }).ToList();
            _orderBindingSource.DataSource = simplifiedOrderList;
        }
    }
}
using System;
using oop_kr.Models;
using oop_kr.Views;

namespace oop_kr.Presenters
{
    /// <summary>
    /// Презентер для главного окна приложения.
    /// </summary>
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        private readonly string _sqlConnectionString;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainPresenter"/>.
        /// </summary>
        /// <param name="mainView">Главное представление приложения.</param>
        /// <param name="sqlConnectionString">Строка подключения к базе данных.</param>
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;
            _mainView.ShowMenu += ShowMenu;
            _mainView.ShowOrders += ShowOrders;
            _mainView.ShowAnalytics += ShowAnalytics;
            _mainView.ShowFeatures += ShowFeatures;
        }

        /// <summary>
        /// Отображает функции базы данных.
        /// </summary>
        private void ShowFeatures(object sender, EventArgs e)
        {
            IFeaturesView view = FeaturesForm.GetInstance((MainForm)_mainView);
            IOrderRepository orderRep = new OrderRepository(_sqlConnectionString);
            IDishRepository dishRep = new DishRepository(_sqlConnectionString);
            IOrderedDishRepository orderDishRep = new OrderedDishRepository(_sqlConnectionString);

            new FeaturesPresenter(view, orderRep, dishRep, orderDishRep);
        }

        /// <summary>
        /// Отображает аналитику.
        /// </summary>
        private void ShowAnalytics(object sender, EventArgs e)
        {
            IAnalyticsView view = AnalyticsForm.GetInstance((MainForm)_mainView);
            IAnalyticsRepository repository = new AnalyticsRepository(_sqlConnectionString);
            new AnalyticsPresenter(view, repository);
        }

        /// <summary>
        /// Отображает заказы.
        /// </summary>
        private void ShowOrders(object sender, EventArgs e)
        {
            IOrderView view = OrdersForm.GetInstance((MainForm)_mainView);
            IOrderRepository orderRep = new OrderRepository(_sqlConnectionString);
            IDishRepository dishRep = new DishRepository(_sqlConnectionString);
            new OrderPresenter(view, orderRep, dishRep);
        }

        /// <summary>
        /// Отображает меню блюд.
        /// </summary>
        private void ShowMenu(object sender, EventArgs e)
        {
            IDishView view = MenuForm.GetInstance((MainForm)_mainView);
            IDishRepository repository = new DishRepository(_sqlConnectionString);
            new DishPresenter(view, repository);
        }
    }
}
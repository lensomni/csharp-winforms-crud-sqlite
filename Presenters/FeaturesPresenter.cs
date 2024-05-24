using System;
using System.Collections.Generic;
using oop_kr.Models;
using oop_kr.Views;

namespace oop_kr.Presenters
{
    /// <summary>
    /// Презентер для управления функциями базы данных.
    /// </summary>
    public class FeaturesPresenter
    {
        private IFeaturesView _view;
        private DataBaseHelper _dataBaseHelper;

        private IOrderRepository _orderRepository;
        private IDishRepository _dishRepository;
        private IOrderedDishRepository _orderedDishRepository;

        private IEnumerable<Dish> _dishList;
        private IEnumerable<Order> _orderList;
        private IEnumerable<OrderedDish> _orderedDishList;


        public FeaturesPresenter(IFeaturesView view, IOrderRepository orderRepository,
            IDishRepository dishRepository, IOrderedDishRepository orderedDishRepository)
        {
            _view = view;
            _orderRepository = orderRepository;
            _dishRepository = dishRepository;
            _orderedDishRepository = orderedDishRepository;

            _dataBaseHelper = new DataBaseHelper();

            _view.CreateDataBaseEvent += CreateDataBase;
            _view.DeleteDataBaseEvent += DeleteDataBase;
            _view.SaveJSONEvent += SaveJSON;

            _view.Show();
        }

        /// <summary>
        /// Сохраняет данные в формате JSON.
        /// </summary>
        private void SaveJSON(object sender, EventArgs e)
        {
            _dishList = _dishRepository.GetAll();
            _orderList = _orderRepository.GetAll();
            _orderedDishList = _orderedDishRepository.GetAll();
            if (_dataBaseHelper.SaveJSON(_dishList, _orderList, _orderedDishList))
                _view.Message = "Данные сохранены.";
        }

        /// <summary>
        /// Удаляет базу данных.
        /// </summary>
        private void DeleteDataBase(object sender, EventArgs e)
        {
            if (_dataBaseHelper.DeleteDataBase())
                _view.Message = "База данных удалена.";
            else
                _view.Message = "База данных не существует.";
        }

        /// <summary>
        /// Создает базу данных.
        /// </summary>
        private void CreateDataBase(object sender, EventArgs e)
        {
            if (_dataBaseHelper.CreateDataBase())
                _view.Message = "База данных создана.";
            else
                _view.Message = "База данных уже создана.";
        }
    }
}

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
    /// Презентер для управления блюдами.
    /// </summary>
    public class DishPresenter
    {
        private readonly IDishView _view;
        private readonly IDishRepository _repository;
        private readonly BindingSource _dishBindingSource;
        private IEnumerable<Dish> _dishList;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DishPresenter"/>.
        /// </summary>
        /// <param name="view">Представление блюд.</param>
        /// <param name="repository">Репозиторий блюд.</param>
        public DishPresenter(IDishView view, IDishRepository repository)
        {
            _dishBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            _view.SearchEvent += SearchDish;
            _view.AddNewEvent += AddNewDish;
            _view.EditEvent += LoadSelectedDishToEdit;
            _view.DeleteEvent += DeleteSelectedDish;
            _view.SaveEvent += SaveDish;
            _view.CancelEvent += CancelAction;
            _view.GenerateMenuEvent += GenerateMenu;

            _view.SetDishListBindingSource(_dishBindingSource);
            LoadAllDishList();
            _view.Show();
        }

        /// <summary>
        /// Генерирует меню и сохраняет его в файл.
        /// </summary>
        private void GenerateMenu(object sender, EventArgs e)
        {
            _dishList = _repository.GetAll();
            FileHelper fileHelper = new FileHelper();
            fileHelper.SaveDishesToFile(_dishList);
            _view.Message = "Меню успешно сохранено";
        }

        /// <summary>
        /// Выполняет поиск блюд по заданным критериям.
        /// </summary>
        private void SearchDish(object sender, EventArgs e)
        {
            _dishList = (string.IsNullOrWhiteSpace(_view.SearchValue) && _view.DishSearchPrice < 0)
                        ? _repository.GetAll()
                        : _repository.GetByValue(_view.SearchValue, _view.DishSearchPrice);

            _dishBindingSource.DataSource = _dishList;
            _view.SearchResult = _dishList.Any() ? $"Найдено блюд: {_dishList.Count()}" : "Не найдено";
        }

        /// <summary>
        /// Загружает все блюда.
        /// </summary>
        private void LoadAllDishList()
        {
            _dishList = _repository.GetAll();
            _dishBindingSource.DataSource = _dishList;
        }

        /// <summary>
        /// Отменяет текущее действие.
        /// </summary>
        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        /// <summary>
        /// Сохраняет информацию о блюде.
        /// </summary>
        private void SaveDish(object sender, EventArgs e)
        {
            try
            {
                var model = new Dish
                {
                    Id = _view.GetSelectedDishId(),
                    Name = _view.DishName,
                    Description = _view.DishDescription,
                    Price = _view.DishPrice,
                    Category = _view.DishCategory
                };

                new ModelDataValidator().Validate(model);
                if (_view.IsEdit)
                {
                    _repository.Edit(model);
                    _view.Message = "Изменения сохранены.";
                }
                else
                {
                    _repository.Add(model);
                    _view.Message = "Блюдо добавлено в меню.";
                }
                _view.IsSuccessful = true;
                LoadAllDishList();
                CleanViewFields();
               
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        /// <summary>
        /// Очищает поля представления.
        /// </summary>
        private void CleanViewFields()
        {
            _view.DishName = "";
            _view.DishDescription = "";
            _view.DishPrice = 0;
        }

        /// <summary>
        /// Удаляет выбранное блюдо.
        /// </summary>
        private void DeleteSelectedDish(object sender, EventArgs e)
        {
            try
            {
                var dish = (Dish)_dishBindingSource.Current;
                _repository.Delete(dish.Id);
                _view.IsSuccessful = true;
                _view.Message = "Блюдо удалено";
                LoadAllDishList();
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "Ошибка при попытке удалить блюдо";
            }
        }

        /// <summary>
        /// Загружает выбранное блюдо для редактирования.
        /// </summary>
        private void LoadSelectedDishToEdit(object sender, EventArgs e)
        {
            if (_dishBindingSource.Current is Dish dish)
            {
                _view.DishName = dish.Name;
                _view.DishDescription = dish.Description;
                _view.DishPrice = dish.Price;
                _view.DishCategory = dish.Category;
                _view.IsEdit = true;
            }
        }

        /// <summary>
        /// Инициирует добавление нового блюда.
        /// </summary>
        private void AddNewDish(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }
    }
}
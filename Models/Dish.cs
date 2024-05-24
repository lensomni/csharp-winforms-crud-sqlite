using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace oop_kr.Models
{
    /// <summary>
    /// Модель блюда.
    /// </summary>
    public class Dish
    {
        private string _name;
        private string _description;
        private decimal _price;
        private string _category;

        /// <summary>
        /// Уникальный идентификатор блюда.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название блюда.
        /// </summary>
        [DisplayName("Название")]
        [Required(ErrorMessage = "Необходимо указать название блюда")]
        [RegularExpression(@"^(?!\s+$)[а-яА-Я\s]+$", ErrorMessage = "Название блюда может содержать только русские буквы и пробелы.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Название блюда: от 3 до 100 символов.")]
        public string Name
        {
            get => _name;
            set => _name = value.Trim();
        }

        /// <summary>
        /// Описание блюда.
        /// </summary>
        [DisplayName("Описание")]
        [Required(ErrorMessage = "Необходимо указать описание блюда")]
        [RegularExpression(@"^(?!\s+$)[а-яА-Я\s]+$", ErrorMessage = "Описание блюда может содержать только русские буквы и пробелы.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Описание блюда: от 3 до 200 символов.")]
        public string Description
        {
            get => _description;
            set => _description = value.Trim();
        }

        /// <summary>
        /// Цена блюда.
        /// </summary>
        [DisplayName("Цена")]
        [Required(ErrorMessage = "Необходимо указать цену блюда")]
        [Range(1, 20000, ErrorMessage = "Максимальная цена блюда: 20.000 руб.")]
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        /// <summary>
        /// Категория блюда.
        /// </summary>
        [DisplayName("Категория")]
        [Required(ErrorMessage = "Необходимо указать категорию блюда")]
        [RegularExpression(@"^(?!\s+$)[а-яА-Я\s]+$", ErrorMessage = "Категория может содержать только русские буквы и пробелы.")]
        public string Category
        {
            get => _category;
            set => _category = value.Trim();
        }
    }
}
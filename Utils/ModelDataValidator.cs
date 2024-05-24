using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oop_kr.Utils
{
    /// <summary>
    /// Класс для валидации данных модели.
    /// </summary>
    public class ModelDataValidator
    {
        /// <summary>
        /// Проверяет модели.
        /// </summary>
        /// <param name="model">Модель данных для валидации.</param>
        /// <exception cref="Exception">Выбрасывается, если модель данных не прошла валидацию.</exception>
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (!isValid)
            {
                results.ForEach(item => errorMessage += "- " + item.ErrorMessage + "\n");
                throw new Exception(errorMessage);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using oop_kr.Models;

namespace oop_kr.Utils
{
    /// <summary>
    /// Вспомогательный класс для работы с файлами.
    /// </summary>
    public class FileHelper
    {
        private const string menufilePath = @"C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\menu.txt";
        private const string reportFilePath = @"C:\Users\Алёна\Desktop\2 курс\4 семестр\ООП С#\oop_kr\Files\report.txt";

        /// <summary>
        /// Сохраняет список блюд в текстовый файл.
        /// </summary>
        public void SaveDishesToFile(IEnumerable<Dish> dishes)
        {
            string directory = Path.GetDirectoryName(menufilePath);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            var dishesByCategory = dishes.GroupBy(d => d.Category);

            using (var writer = new StreamWriter(menufilePath))
            {
                writer.WriteLine($"\t\t\t\tМЕНЮ ({DateTime.Now:dd.MM.yyyy})");
                foreach (var categoryGroup in dishesByCategory)
                {
                    writer.WriteLine($"{categoryGroup.Key} \n{new string('-', 80)}");

                    foreach (var dish in categoryGroup)
                        writer.WriteLine($"{dish.Name,-20} {dish.Description,-40} {dish.Price} руб");

                    writer.WriteLine();
                }
            }
        }

        /// <summary>
        /// Сохраняет отчет о продажах блюд в текстовый файл.
        /// </summary>
        public bool SaveAnalyticsToFile(IEnumerable<OrderItem> reportData, DateTime startDate, DateTime endDate)
        {
            try
            {
                string directory = Path.GetDirectoryName(reportFilePath);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (var writer = new StreamWriter(reportFilePath))
                {
                    writer.WriteLine($"Отчет по продажам за период c {startDate} по {endDate}");

                    writer.WriteLine(new string('-', 80));
                    writer.WriteLine($"{"Блюдо",-30} {"Цена",-15} {"Количество",-15} {"Общая сумма",-15}");
                    writer.WriteLine(new string('-', 80));

                    foreach (var item in reportData)
                    {
                        writer.WriteLine($"{item.Dish.Name,-30} {item.Dish.Price,-15} {item.Quantity,-15} {item.TotalPrice,-15}");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении отчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}

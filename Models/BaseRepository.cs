namespace oop_kr.Models
{
    /// <summary>
    /// Представляет абстрактный базовый класс репозитория.
    /// </summary>
    public abstract class BaseRepository
    {
        /// <summary>
        /// Строка подключения к базе данных.
        /// </summary>
        protected string connectionString;
    }
}

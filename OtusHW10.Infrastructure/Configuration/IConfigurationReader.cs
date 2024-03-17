namespace OtusHW10.Infrastructure.Configuration
{
    /// <summary>
    ///     Интерфейс получения настроек игры.
    /// </summary>
    public interface IConfigurationReader
    {
        /// <summary>
        ///     Получить игровые настройки.
        /// </summary>
        /// <returns>
        ///     Модель настроек.
        /// </returns>
        GameConfig GetGameConfig();
    }
}

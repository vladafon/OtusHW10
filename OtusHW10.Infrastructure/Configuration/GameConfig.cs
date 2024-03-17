namespace OtusHW10.Infrastructure.Configuration
{
    /// <summary>
    ///     Модель игровых настроек.
    /// </summary>
    public class GameConfig
    {
        /// <summary>
        ///     Верхняя включенная граница диапазона чисел для загадывания.
        /// </summary>
        public int NumberFrom { get; set; }

        /// <summary>
        ///     Нижняя не включенная граница диапазона чисел для загадывания.
        /// </summary>
        public int NumberTo { get; set; }

        /// <summary>
        ///     Количество попыток для отгадывания.
        /// </summary>
        public int AttemptsCount { get; set; }
    }
}

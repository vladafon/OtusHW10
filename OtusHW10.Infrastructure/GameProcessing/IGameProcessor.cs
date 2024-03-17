namespace OtusHW10.Infrastructure.GameProcessing
{
    /// <summary>
    ///     Интерфейс, определяющий процесс игры.
    /// </summary>
    internal interface IGameProcessor
    {
        /// <summary>
        ///     Запускает игру с заданными параметрами.
        /// </summary>
        /// <param name="numberFrom">
        ///     Верхняя включенная граница диапазона чисел для загадывания.
        /// </param>
        /// <param name="numberTo">
        ///     Нижняя не включенная граница диапазона чисел для загадывания.
        /// </param>
        /// <param name="attemptsCount">
        ///     Количество попыток для отгадывания.
        /// </param>
        /// <returns></returns>
        Task StartGameAsync(int numberFrom, int numberTo, int attemptsCount);
    }
}

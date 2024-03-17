namespace OtusHW10.Core.NumberGenerator
{
    /// <summary>
    ///     Интерфейс для модуля генерации и хранения числа.
    /// </summary>
    public interface INumberGenerator
    {
        /// <summary>
        ///     Загаданное число.
        /// </summary>
        int Number { get; }

        /// <summary>
        ///     Генерирует и сохраняет новое число.
        /// </summary>
        /// <param name="from">
        ///     Верхняя включенная граница диапазона.
        /// </param>
        /// <param name="to">
        ///     Нижняя не включенная граница диапазона.
        /// </param>
        Task GenerateNumberAsync(int from, int to);
    }
}

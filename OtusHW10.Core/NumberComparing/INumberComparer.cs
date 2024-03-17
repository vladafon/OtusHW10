namespace OtusHW10.Core.NumberComparing
{
    /// <summary>
    ///     Интерфейс для модуля, сравнивающего числа.
    /// </summary>
    public interface INumberComparer
    {
        /// <summary>
        ///     Сравнивает введенное число с отгадываемым.
        /// </summary>
        /// <returns>
        ///     Результат сравнения.
        /// </returns>
        CompareResult CompareNumbers(int guessableNumber, int userNumber);
    }
}

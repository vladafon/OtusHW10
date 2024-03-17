namespace OtusHW10.Core.NumberComparing
{
    /// <summary>
    ///     Результат сравнения чисел.
    /// </summary>
    public enum CompareResult
    {
        /// <summary>
        ///     Число меньше отгадываемого.
        /// </summary>
        Less = -1,

        /// <summary>
        ///     Число равно отгадываемому.
        /// </summary>
        Equal = 0,

        /// <summary>
        ///     Число больше отгадываемого.
        /// </summary>
        More = 1
    }
}

using OtusHW10.Core.NumberComparing;
using OtusHW10.Core.NumberGenerator;

namespace OtusHW10.Infrastructure.GameProcessing
{
    ///<inheritdoc/>
    public abstract class BaseGameProcessor : IGameProcessor
    {
        private readonly INumberGenerator _numberGenerator;
        private readonly INumberComparer _numberComparer;
        public BaseGameProcessor(INumberGenerator numberGenerator,
            INumberComparer numberComparer)
        {
            _numberComparer = numberComparer;
            _numberGenerator = numberGenerator;
        }

        ///<inheritdoc/>
        public async Task StartGameAsync(int numberFrom, int numberTo, int attemptsCount)
        {
            if (numberFrom > numberTo)
            {
                throw new ArgumentException("Неверно задан диапазон значений для загадываемого числа.", nameof(numberFrom));
            }

            if (attemptsCount < 1)
            {
                throw new ArgumentException("Неверно задано количество попыток для угадывания.", nameof(attemptsCount));
            }

            await ShowWelcomeMessageAsync(numberFrom, numberTo, attemptsCount);

            await _numberGenerator.GenerateNumberAsync(numberFrom, numberTo);

            var guessableNumber = _numberGenerator.Number;

            for (var i = 0; i < attemptsCount; i++)
            {
                var userInput = await GetUserInputAsync();

                var compareResult = _numberComparer.CompareNumbers(guessableNumber, userInput);

                await ShowCompareResultAsync(compareResult);

                if (compareResult == CompareResult.Equal)
                {
                    await ShowEndWinMessageAsync();
                    return;
                }
            }

            await ShowEndLoseMessageAsync(guessableNumber);
        }

        /// <summary>
        ///     Выводит пользователю приветственное сообщение 
        ///     с информацией о количестве попыток и диапазоне чисел для угадывания.
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
        protected abstract Task ShowWelcomeMessageAsync(int numberFrom, int numberTo, int attemptsCount);

        /// <summary>
        ///     Обрабатывает ввод числа пользователем.
        /// </summary>
        /// <returns>
        ///     Число, введенное пользователем.
        /// </returns>
        protected abstract Task<int> GetUserInputAsync();

        /// <summary>
        ///     Выводит пользователю результат сравнения его числа с загаданным.
        /// </summary>
        /// <param name="compareResult">
        ///     Результат сравнения.
        /// </param>
        protected abstract Task ShowCompareResultAsync(CompareResult compareResult);

        /// <summary>
        ///     Выводит пользователю сообщение в случае выигрыша.
        /// </summary>
        protected abstract Task ShowEndWinMessageAsync();

        /// <summary>
        ///     Выводит пользователю сообщение в слуае проигрыша.
        /// </summary>
        /// <param name="guessableNumber">
        ///     Число, которое загадывал компьютер.
        /// </param>
        protected abstract Task ShowEndLoseMessageAsync(int guessableNumber);
    }
}

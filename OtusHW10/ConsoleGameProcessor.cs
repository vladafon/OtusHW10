using OtusHW10.Core.NumberComparing;
using OtusHW10.Core.NumberGenerator;
using OtusHW10.Infrastructure.GameProcessing;

namespace OtusHW10
{
    /// <summary>
    ///     Класс для игры через консоль.
    /// </summary>
    internal class ConsoleGameProcessor : BaseGameProcessor
    {
        public ConsoleGameProcessor(INumberGenerator numberGenerator, INumberComparer numberComparer) : base(numberGenerator, numberComparer)
        {
        }

        ///<inheritdoc/>
        protected override Task<int> GetUserInputAsync()
        {
            Console.WriteLine("Введите число:");

            while (true)
            {
                var numberString = Console.ReadLine();

                if (int.TryParse(numberString, out var number))
                {
                    return Task.FromResult(number);
                }

                Console.WriteLine("Неверный ввод!");
            }
        }

        ///<inheritdoc/>
        protected override Task ShowCompareResultAsync(CompareResult compareResult) 
        {
            switch (compareResult)
            {
                case CompareResult.Equal:
                    Console.WriteLine("Числа равны");
                    break;
                case CompareResult.Less:
                    Console.WriteLine("Ваше число меньше отгадываемого.");
                    break;
                case CompareResult.More:
                    Console.WriteLine("Ваше число больше отгадываемого.");
                    break;
                default: 
                    throw new NotImplementedException("Некорректный результат сравнения.");
            }

            return Task.CompletedTask;
        }

        ///<inheritdoc/>
        protected override Task ShowEndLoseMessageAsync(int guessableNumber)
        {
            Console.WriteLine($"К сожалению, вы проиграли. Было загадано число {guessableNumber}.");
            Console.WriteLine($"Нажмите любую кнопку для выхода из игры...");
            Console.ReadKey();

            return Task.CompletedTask;
        }

        ///<inheritdoc/>
        protected override Task ShowEndWinMessageAsync()
        {
            Console.WriteLine($"Поздравляем, вы выиграли!");
            Console.WriteLine($"Нажмите любую кнопку для выхода из игры...");
            Console.ReadKey();

            return Task.CompletedTask;
        }

        ///<inheritdoc/>
        protected override Task ShowWelcomeMessageAsync(int numberFrom, int numberTo, int attemptsCount)
        {
            Console.WriteLine($"Игра \"Угадай число\".");
            Console.WriteLine($"Количество попыток: {attemptsCount}.");
            Console.WriteLine($"Диапазон: от {numberFrom} включая до {numberTo} не включая.");

            return Task.CompletedTask;
        }
    }
}

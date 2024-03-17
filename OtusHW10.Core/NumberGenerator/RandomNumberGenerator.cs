using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OtusHW10.Core.NumberGenerator
{
    ///<inheritdoc/>
    public class RandomNumberGenerator : INumberGenerator
    {
        ///<inheritdoc/>
        public int Number
        {
            get
            {
                if (!_isInitialized)
                {
                    throw new InvalidOperationException("Число еще не сгенерировано.");
                }

                return _number;
            }
        }

        private int _number;

        private bool _isInitialized = false;

        ///<inheritdoc/>
        public Task GenerateNumberAsync(int from, int to)
        {
            if (from > to)
            {
                throw new ArgumentException("Неверно задан диапазон значений для загадываемого числа.", nameof(from));
            }

            var random = new Random();

            _number = random.Next(from, to);

            _isInitialized = true;

            return Task.CompletedTask;
        }
    }
}

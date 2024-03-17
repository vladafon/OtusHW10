namespace OtusHW10.Core.NumberComparing
{
    ///<inheritdoc/>
    public class NumberComparer : INumberComparer
    {
        ///<inheritdoc/>
        public CompareResult CompareNumbers(int guessableNumber, int userNumber)
        {
            if (userNumber < guessableNumber)
            {
                return CompareResult.Less;
            }
            else if (userNumber > guessableNumber)
            {
                return CompareResult.More;
            }
            else
            {
                return CompareResult.Equal;
            }
        }
    }
}

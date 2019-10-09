namespace RepeatedStringSolution.Strategy
{
    public class SlowStrategy : ICountLetterAStrategy
    {
        public int CountOccurrences(string inputString, int numberOfCharacterToConsider)
        {
            if (string.IsNullOrEmpty(inputString) || numberOfCharacterToConsider <= 0)
            {
                return 0;
            }
            int numberOfA = 0;
            var numberOfTimesToMultiply = numberOfCharacterToConsider % inputString.Length == 0
                ? numberOfCharacterToConsider / inputString.Length
                : numberOfCharacterToConsider / inputString.Length + 1;

            string resultString = null;
            for (int i = 0; i < numberOfTimesToMultiply; i++)
            {
                resultString += inputString;
            }

            resultString = resultString.Substring(0, numberOfCharacterToConsider);
            
            
            for (int i = 0; i < resultString.Length; i++)
            {
                if (resultString[i] == 'a')
                    numberOfA++;
            }

            return numberOfA;
        }
    }
}

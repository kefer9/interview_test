namespace RepeatedStringSolution.Strategy
{
    public class FastStrategy : ICountLetterAStrategy
    {
        public int CountOccurrences(string inputString, int numberOfCharacterToConsider)
        {
            if (string.IsNullOrEmpty(inputString) || numberOfCharacterToConsider <= 0)
            {
                return 0;
            }

            int numberOfA = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'a')
                    numberOfA++;
            }
            numberOfA = (numberOfCharacterToConsider / inputString.Length) * numberOfA;

            for (int i = 0; i < numberOfCharacterToConsider % inputString.Length; i++)
            {
                if (inputString[i] == 'a')
                    numberOfA++;
            }

            return numberOfA;
        }
    }
}

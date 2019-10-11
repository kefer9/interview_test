using System;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to repeat:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Input the number of character to consider:");
            int numberOfCharacterToConsider = Convert.ToInt32(Console.ReadLine());

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

            string result = string.Empty;
            
            if (numberOfA % 3 == 0)
            {
                result+="Fizz";
            }
            if (numberOfA % 5 == 0)
            {
                result += "Buzz";
            }

            if (string.IsNullOrEmpty(result))
            {
                result += numberOfA;
            }

            Console.WriteLine(result);
        }
    }
}

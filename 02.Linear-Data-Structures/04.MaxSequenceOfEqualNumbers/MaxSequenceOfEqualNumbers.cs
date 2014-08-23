namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaxSequenceOfEqualNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number or empty line for end: ");
            string line = Console.ReadLine();
            int number = 0;
            List<int> numbers = new List<int>();

            while (line != string.Empty)
            {
                try
                {
                    number = int.Parse(line);
                    numbers.Add(number);
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Please, enter a valid string for number.");
                }

                line = Console.ReadLine();
            }

            FindMaximalSequence(numbers);
        }

        private static void FindMaximalSequence(List<int> numbers)
        {
            int start = 0;
            int count = 1;
            int bestStart = 0;
            int bestCount = 0;

            for (int index = 1; index <= numbers.Count() - 1 ; index++)
            {
                if (numbers[index] == numbers[index - 1])
                {
                    count++;
                }
                else
                {
                    start = index;
                    count = 1;
                }

                if (count > bestCount)
                {
                    bestStart = start;
                    bestCount = count;
                }
            }

            for (int index = bestStart; index < bestCount + bestStart ; index++)
            {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}

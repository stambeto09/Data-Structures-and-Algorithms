namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAndAverage
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

            int sum = CalculateSum(numbers);
            int averageValue = CalculateAverage(numbers);

            Console.WriteLine("The sum of the elements in the current list is {0} and the average value is {1}", sum, averageValue);
        }

        private static int CalculateAverage(List<int> numbers)
        {
            int averageValue = 0;

            foreach (var number in numbers)
            {
                averageValue += number;
            }

            return averageValue / numbers.Count();
        }

        private static int CalculateSum(List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}

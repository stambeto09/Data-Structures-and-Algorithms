namespace LInearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NegativeNumberRemover
    {
        static void Main()
        {
            Console.WriteLine("Enter a number or empty line for end: ");
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

            for (int index = 0; index <= numbers.Count() - 1; index++)
            {
                if (numbers[index] < 0)
                {
                    numbers.Remove(numbers[index]);
                    index--;
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

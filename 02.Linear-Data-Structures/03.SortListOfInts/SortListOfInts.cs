namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortListOfInts
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

            Sort(numbers);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        private static void Sort(List<int> numbers)
        {
            int currentElement = 0;
            int previousIndex = 0;

            for (int index = 1; index <= numbers.Count() - 1; index++)
            {
                currentElement = numbers[index];
                previousIndex = index - 1;

                while ((previousIndex >= 0) && (numbers[previousIndex] > currentElement))
                {
                    numbers[previousIndex + 1] = numbers[previousIndex];
                    previousIndex--;
                }
                numbers[previousIndex + 1] = currentElement;
            }
        }
    }
}

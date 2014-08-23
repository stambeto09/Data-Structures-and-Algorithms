namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseUsingStack
    {
        static void Main()
        {
            Console.Write("Enter a number or empty line for end: ");
            string line = Console.ReadLine();
            int number = 0;
            Stack<int> numbers = new Stack<int>();

            while (line != string.Empty)
            {
                try
                {
                    number = int.Parse(line);
                    numbers.Push(number);
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Please, enter a valid string for number.");
                }

                line = Console.ReadLine();
            }

            for (int index = 0; index <= numbers.Count() - 1; index++)
            {
                Console.WriteLine(numbers.ElementAt(index));
            }
        }
    }
}

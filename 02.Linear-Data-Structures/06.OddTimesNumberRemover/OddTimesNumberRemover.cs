namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// I'm using the counting sort principle - creating a new array, on each index position we are saving
    /// how much time the element with value index is repeated in the list. That trick works only for
    /// non-negative values.
    /// </summary>
    class OddTimesNumberRemover
    {
        static void Main()
        {
            List<int> list = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            int maxElement = list.Max();

            int[] array = new int[maxElement + 1];
            foreach (var number in list)
            {
                array[number]++;
            }

            for (int index = 1; index <= array.Length - 1; index++)
            {
                if (array[index] % 2 != 0)
                {
                    for (int j = 0; j < array[index]; j++)
                    {
                        list.Remove(index);
                    }
                }
            }

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }

            Console.WriteLine();
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}

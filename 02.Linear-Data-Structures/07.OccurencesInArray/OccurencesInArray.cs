namespace LinearDataStructures
{
    using System;

    class OccurencesInArray
    {
        static void Main()
        {
            int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            int maxValue = FindMaxValue(array);

            int[] occurences = FindOccurences(array, maxValue);

            for (int index = 0; index <= occurences.Length - 1; index++)
            {
                if (occurences[index] != 0)
                {
                    Console.WriteLine("{0} -> {1} times", index, occurences[index]);
                }
            }
        }

        private static int[] FindOccurences(int[] array, int maxValue)
        {
            int[] occurences = new int[maxValue + 1];
            foreach (var number in array)
            {
                occurences[number]++;
            }

            return occurences;
        }

        private static int FindMaxValue(int[] array)
        {
            int maxValue = 0;

            for (int index = 0; index <= array.Length - 1; index++)
            {
                if (array[index] > maxValue)
                {
                    maxValue = array[index];
                }
            }

            return maxValue;
        }
    }
}

namespace LinearDataStructures
{
    using System;

    class MajorantOfAnArray
    {
        static void Main()
        {
            int[] array = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            int maxValue = FindMaxValue(array);

            int[] occurences = FindOccurences(array, maxValue);

            int majorant = FindMajorant(occurences);

            PrintMajorant(majorant);
        }

        private static void PrintMajorant(int majorant)
        {
            if (majorant == int.MinValue)
            {
                Console.WriteLine("Majorant not found.");
            }
            else
            {
                Console.WriteLine("Majorant found: {0}", majorant);
            }
        }

        private static int FindMajorant(int[] occurences)
        {
            int majorant = int.MinValue;
            for (int index = 0; index <= occurences.Length - 1; index++)
            {
                if (occurences[index] >= occurences.Length / 2 + 1)
                {
                    majorant = index;
                }
            }

            return majorant;
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

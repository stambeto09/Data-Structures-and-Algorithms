namespace DictionariesHashTablesAndSets
{
    using System;
    using System.Collections.Generic;

    class OccurencesOfDoubles
    {
        static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            IDictionary<double, int> occurences = new Dictionary<double, int>();

            foreach (var number in array)
            {
                int count = 1;
                if (occurences.ContainsKey(number))
                {
                    count = occurences[number] + 1;
                }
                occurences[number] = count;
            }

            foreach (var number in occurences)
            {
                Console.WriteLine("Number {0} -> {1} times", number.Key, number.Value);
            }
        }
    }
}

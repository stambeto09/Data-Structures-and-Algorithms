namespace DictionariesHashTablesAndSets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OddOccurencesFinder
    {
        static void Main()
        {
            IDictionary<string, int> occurences = new Dictionary<string, int>();
            string[] words = {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            foreach (var word in words)
            {
                int count = 1;

                if (occurences.ContainsKey(word))
                {
                    count = occurences[word] + 1;
                }

                occurences[word] = count;
            }

            var oddOccurences = from element in occurences
                                where element.Value % 2 != 0
                                select element;

            foreach (var item in oddOccurences)
            {
                Console.WriteLine(item.Key + " ->" + item.Value);
            }
        }
    }
}

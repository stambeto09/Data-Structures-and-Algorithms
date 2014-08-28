namespace DictionariesHashTablesAndSets
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class WordsOccurencesInText
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../text.txt");
            string textFromFile = reader.ReadToEnd();

            string[] words = SplitWords(textFromFile);

            for (int index = 0; index <= words.Length - 1; index++)
            {
                words[index] = words[index].ToLower();
            }

            IDictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                int count = 1;
                if (dict.ContainsKey(word))
                {
                    count = dict[word] + 1;
                }

                dict[word] = count;
            }

            Console.WriteLine(textFromFile);

            foreach (var word in dict)
            {
                Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
            }
            
        }

        private static string[] SplitWords(string textFromFile)
        {
            char[] separators = new char[] { '.', ',', ' ', '?', '!', ';', '-' };
            string[] words = textFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }
    }
}

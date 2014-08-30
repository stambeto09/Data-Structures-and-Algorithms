namespace DictionariesHashTablesAndSets
{
    using System;
    using System.IO;
    using Wintellect.PowerCollections;

    class Program
    {
        static void Main()
        {
            MultiDictionary<string, Tuple<string, string>> phonebook = new MultiDictionary<string, Tuple<string, string>>(true);

            InitializePhonebook(phonebook);

            foreach (var item in phonebook)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();

            StreamReader commandReader = new StreamReader("../../commands.txt");
            
            using (commandReader)
            {
                string line = commandReader.ReadLine();

                while (line != null)
                {
                    int indexOfOpenBracket = line.IndexOf('(');
                    string function = line.Substring(0, indexOfOpenBracket);
                    int indexOfLastBracket = line.IndexOf(')');
                    int lengthOfSubstring = indexOfLastBracket - indexOfOpenBracket - 1;
                    string paramInString = line.Substring(indexOfOpenBracket + 1, lengthOfSubstring);
                    string[] parameters = paramInString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (parameters.Length)
                    {
                        case 1: 
                            Find(parameters[0], phonebook);
                            break;
                        case 2:
                            Find(parameters[0], parameters[1], phonebook);
                            break;
                        default:
                            throw new ArgumentException("Function not found.");
                    }
                    line = commandReader.ReadLine();
                    //switch
                    
                }
            }

        }

        private static void Find(string name, string town, MultiDictionary<string, Tuple<string, string>> phonebook)
        {
            Console.WriteLine("Executed function find({0}, {1})", name, town);
            foreach (var item in phonebook)
            {
                if (item.Key == name)
                {
                    foreach (var tuple in item.Value)
                    {
                        if (tuple.Item1 == town.Trim())
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }

        private static void Find(string name, MultiDictionary<string, Tuple<string, string>> phonebook)
        {
            Console.WriteLine("Executed find({0})", name);
            foreach (var item in phonebook)
            {
                if (item.Key == name)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void InitializePhonebook(MultiDictionary<string, Tuple<string, string>> phonebook)
        {
            StreamReader reader = new StreamReader("../../newPhones.txt");

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string name = line.Split('|')[0].Trim(' ');
                    string town = line.Split('|')[1].Trim(' ');
                    string phone = line.Split('|')[2].Trim(' ');
                    Tuple<string, string> tuple = new Tuple<string, string>(town, phone);
                    phonebook.Add(name, tuple);
                    line = reader.ReadLine();
                }
            }
        }
    }
}

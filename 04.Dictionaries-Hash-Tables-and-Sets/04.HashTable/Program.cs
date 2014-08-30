namespace DictionariesHashTablesAndSets
{
    using System;

    class Program
    {
        static void Main()
        {
            var table = new HashDictionary<string, int>();

            table.Add("Pesho", 5);
            table.Add("Gosho", 4);
            table.Add("Mariika", 3);
            table.Add("Krasimira", 2);
            table.Add("Stamat", 1);

            var value = table.Find("Pesho");

            foreach (var person in table)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }

            Console.WriteLine(table.ContainsKey("Pesho"));
            Console.WriteLine(table.ContainsKey("Pesho2"));
            Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesHashTablesAndSets
{
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

            Console.WriteLine(table.ContainsKey("Pesho"));
            Console.WriteLine(table.ContainsKey("Pesho2"));
        }
    }
}

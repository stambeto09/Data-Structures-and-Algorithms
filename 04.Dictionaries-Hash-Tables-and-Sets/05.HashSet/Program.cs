﻿namespace DictionariesHashTablesAndSets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Pesho");
            hashSet.Add("Gosho");
            hashSet.Add("Mariika");
            hashSet.Add("Ivancho");
            hashSet.Add("Petrancho");

            HashSet<string> newHashSet = new HashSet<string>();
            newHashSet.Add("Pesho");
            newHashSet.Add("Gosho");
            newHashSet.Add("Mariika");
            newHashSet.Add("Stamat");

            hashSet.Intersect(newHashSet);

            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}

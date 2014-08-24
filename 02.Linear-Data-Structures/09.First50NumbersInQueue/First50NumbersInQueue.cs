namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    class First50NumbersInQueue
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            List<int> first50Numbers = new List<int>();
            first50Numbers.Add(n);
            queue.Enqueue(n);
            int index = 1;
            int previousS = n;

            while (first50Numbers.Count < 50)
            {
                queue.Enqueue(previousS + 1);
                queue.Enqueue(2 * previousS + 1);
                queue.Enqueue(previousS + 2);

                first50Numbers.Add(previousS + 1);
                first50Numbers.Add(2 * previousS + 1);
                first50Numbers.Add(previousS + 2);
                index++;
                previousS = first50Numbers[index - 1];
            }

            foreach (var number in queue)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}

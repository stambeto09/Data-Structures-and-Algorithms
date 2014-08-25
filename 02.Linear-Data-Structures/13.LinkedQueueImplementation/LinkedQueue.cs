namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

    public class LinkedQueue<T> where T : IComparable
    {
        private static LinkedList<T> linkedList = new LinkedList<T>();
        private static int top = linkedList.Count;

        public void Enqueue(T item)
        {
            top++;
            linkedList.AddLast(item);

            Console.WriteLine("Added");
            Console.WriteLine("Size of the list: {0}", linkedList.Count);
        }

        public void Dequeue()
        {
            top--;
            linkedList.RemoveFirst();
            Console.WriteLine("Dequeued");
            Console.WriteLine("Size of the Linked list: {0}", linkedList.Count);
        }

        public void PrintLinkedQueue()
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

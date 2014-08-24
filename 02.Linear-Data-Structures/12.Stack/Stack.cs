namespace LinearDataStructures
{
    using System;

    public class Stack<T> where T : IComparable
    {
        private static T[] array = new T[1];
        private static int top;
        private static int currentBusyIndex = -1;

        public void Add(T item)
        {
            currentBusyIndex++;
            top = array.Length - 1;
            if (currentBusyIndex == top)
            {
                T[] newArray = new T[array.Length * 2];

                for (int index = 0; index <= array.Length - 1; index++)
                {
                    newArray[index] = array[index];
                }
                
                array = newArray;
                Console.WriteLine("Resized");
                Console.WriteLine("Size of the array: {0}", array.Length);
            }

            array[currentBusyIndex] = item;
        }

        public void PrintStack()
        {
            for (int index = top - 1; index >= 0; index--)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}

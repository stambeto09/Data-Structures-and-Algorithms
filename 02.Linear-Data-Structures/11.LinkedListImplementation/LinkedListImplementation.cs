namespace LinearDataStructures
{
    class LinkedListImplementation
    {
        static void Main()
        {
            ListItem<int> firstElement = new ListItem<int>();
            firstElement.value = 15;
            ListItem<int> secondElement = new ListItem<int>();
            secondElement.value = 13;
            firstElement.NextItem = secondElement;
            ListItem<int> thirdElement = new ListItem<int>();
            thirdElement.value = 16;
            secondElement.NextItem = thirdElement;

            LinkedList<int> myList = new LinkedList<int>();
            myList.FirstElement = firstElement;

        }
    }
}

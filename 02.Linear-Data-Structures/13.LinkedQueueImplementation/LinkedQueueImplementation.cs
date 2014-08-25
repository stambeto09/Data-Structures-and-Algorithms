namespace LinearDataStructures
{
    class LinkedQueueImplementation
    {
        static void Main()
        {
            LinkedQueue<int> myLinkedQueue = new LinkedQueue<int>();
            myLinkedQueue.Enqueue(1);
            myLinkedQueue.Enqueue(2);
            myLinkedQueue.Enqueue(3);
            myLinkedQueue.Enqueue(4);
            myLinkedQueue.Enqueue(5);
            myLinkedQueue.Enqueue(6);

            myLinkedQueue.Dequeue();
            myLinkedQueue.PrintLinkedQueue();
        }
    }
}

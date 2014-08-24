namespace LinearDataStructures
{
    public class StackImplementation
    {
        static void Main()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Add(1);
            myStack.Add(2);
            myStack.Add(3);
            myStack.Add(4);

            myStack.PrintStack();
        }
    }
}

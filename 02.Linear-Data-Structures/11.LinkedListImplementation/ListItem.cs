namespace LinearDataStructures
{
    using System;

    public class ListItem<T> where T : IComparable
    {
        public T value;
        public ListItem<T> NextItem;

    }
}

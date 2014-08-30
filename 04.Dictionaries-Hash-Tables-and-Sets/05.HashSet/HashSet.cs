namespace DictionariesHashTablesAndSets
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashSet<T> : IEnumerable<T>
    {
        private List<T> values;

        public HashSet()
        {
            this.values = new List<T>();
        }

        public int Count 
        {
            get
            {
                return this.values.Count;
            }
        }

        public void Add(T value)
        {
            this.values.Add(value);
        }

        public void Remove(T value)
        {
            this.values.Remove(value);
        }

        public bool Find(T value)
        {
            var hash = values.GetHashCode();

            foreach (var item in this.values)
            {
                if (item.GetHashCode() == hash)
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.values.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var value in values)
            {
                yield return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                if (!this.values.Contains(item))
                {
                    this.values.Add(item);
                }
            }
        }

        public void Intersect(IEnumerable<T> other)
        {
            List<T> intersectedList = new List<T>();

            foreach (var value in this.values)
            {
                if (other.Contains(value))
                {
                    intersectedList.Add(value);
                }
            }

            this.values = intersectedList;
        }
    }
}

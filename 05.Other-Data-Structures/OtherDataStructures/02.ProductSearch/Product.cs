namespace _02.ProductSearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Product : IComparable<Product>
    {
        public int Value { get; set; }

        public string Name { get; set; }



        public int CompareTo(Product other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}

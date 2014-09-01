namespace _02.ProductSearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    class ProductSearch
    {
        private const int NumberOfProducts = 500000;
        static void Main()
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            Random randomNumber = new Random();

            for (int i = 1; i <= NumberOfProducts; i++)
            {
                Product product = new Product();
                product.Name = "Product number : " + i;
                product.Value = randomNumber.Next(i, NumberOfProducts);
                products.Add(product);
            }

            List<Product> productsRange = new List<Product>();

            for (int index = 1; index <= 10000; index++)
            {
                int min = randomNumber.Next(index, 10000) / 2;
                int max = randomNumber.Next(index, 10000) * 100;

                productsRange.AddRange(products.Range(new Product(){ Value = min}, true, new Product(){Value = max}, true).Take(20));
            }
        }
    }
}

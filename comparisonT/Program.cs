using System;
using System.Collections.Generic;

namespace comparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Ordenação com CompareTo (classe implementa IComparable<T>)
            list.Sort();

            // Ordenação com Comparison<T> (delegate)
            Comparison<Product> comparison1 = CompareProducts;
            list.Sort(comparison1);
            // Ou
            list.Sort(CompareProducts);

            // Ordenação usando Lambda
            Comparison<Product> comparison2 = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comparison2);
            // Ou
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
                Console.WriteLine(p);

            Console.ReadLine();
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}

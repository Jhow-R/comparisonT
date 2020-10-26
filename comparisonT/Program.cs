using System;
using System.Collections.Generic;

namespace comparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            // Ordenação com CompareTo (classe implementa IComparable<T>)
            products.Sort();

            // Ordenação com Comparison<T> (delegate)
            Comparison<Product> comparison1 = CompareProducts;
            products.Sort(comparison1);
            // Ou
            products.Sort(CompareProducts);

            // Ordenação usando Lambda
            Comparison<Product> comparison2 = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            products.Sort(comparison2);
            // Ou
            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in products)
                Console.WriteLine(p);

            Console.Write(Environment.NewLine);

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Macoratti", Salary = 10000 });
            employees.Add(new Employee() { Name = "Janice", Salary = 10000 });
            employees.Add(new Employee() { Name = "Yuri", Salary = 40000 });
            employees.Add(new Employee() { Name = "Bianca", Salary = 10000 });
            employees.Add(new Employee() { Name = "Amanda", Salary = 500000 });
            employees.Add(new Employee() { Name = "Jefferson", Salary = 17000 });
            employees.Add(new Employee() { Name = "Dinora", Salary = 8000 });

            // Ordem invertida no método CompareTo() da classe Employee
            employees.Sort();

            foreach (var funcionario in employees)
                Console.WriteLine(funcionario);

            Console.ReadLine();
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}

using System;
using System.Collections.Generic;
using linq_lambda.Entities;

namespace linq_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 3000.00));
            products.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            //Console.WriteLine(products[0].Equals(products[1]));
        }

        
    }
}

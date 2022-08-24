using System;
using System.Collections.Generic;
using linq_lambda.Entities;
using System.Linq;

namespace linq_lambda
{
    internal class Program
    {
        public static int globalValue = 3;

        static void Print<T>(string message, IEnumerable<T> collection)
        {

            Console.WriteLine(message);
            foreach(T item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 3);

            products.Add(new Product(1, "TV", 900.00, c2));
            products.Add(new Product(2, "Notebook", 3000.00, c3));
            products.Add(new Product(3, "Tablet", 450.00, c3));
            products.Add(new Product(4, "Hammer", 1700.0, c2));
            products.Add(new Product(5, "Saw", 80.0, c1));
            products.Add(new Product(6, "Camera", 700.0, c3));
            products.Add(new Product(7, "Printer", 350.0, c3));
            products.Add(new Product(9, "Macbook", 1800.0, c2));
            products.Add(new Product(10, "sound bar", 700.0, c3));
            products.Add(new Product(11, "Level", 70.0, c1));

            /*Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            //Console.WriteLine(products[0].Equals(products[1]));
            */

            IEnumerable<Product> prodTier1 = products.Where(p => p.Category.Tier == 1);

            Print("Tier 1:", prodTier1);

            IEnumerable<Product> prodTools = products.Where(p => p.Category.Name == "Tools");
            Print("Name of products Tools: ", prodTools);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names começando com C em objeto anonimo", r3);

            IEnumerable<Product> r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 ordenado por preço e nome: ", r4);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First: ", r6);

            Product r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First maior que 3000", r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("ID 3: " + r8);

            var r9 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r9);

            double r10 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category s1 prices: " + r10);

            double r11 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Media category s1 prices: " + r11);

        }

        
    }
}

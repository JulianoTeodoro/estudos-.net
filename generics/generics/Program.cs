using System;
using System.Collections.Generic;
using System.Globalization;
using generics.Entities;
using generics.Services;
using System.IO;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PrintService<int> printService = new PrintService<int>();

            Console.WriteLine("How many values");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.addValue(x);
            }


            Console.WriteLine("First: " + printService.First());
            Console.Write("How values: ");
            printService.Print();

            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double valor = double.Parse(vect[1], CultureInfo.InvariantCulture);
                //int x = int.Parse(Console.ReadLine());
                list.Add(new Product(name, valor));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);*/

            string path = @"D:\in.txt";
            StreamReader sr = null;
            try
            {
                using(sr = File.OpenText(path))
                {
                    List<Employee> employees = new List<Employee>();
                    while(!sr.EndOfStream)
                    {

                        employees.Add(new Employee(sr.ReadLine()));
                    }
                    employees.Sort();
                    foreach(Employee emp in employees)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}

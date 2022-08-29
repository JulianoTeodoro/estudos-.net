using System;
using System.Collections.Generic;
using System.IO;

namespace hashsorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> set = new List<Person>();

            set.Add(new Person() { Age = 23 });
            set.Add(new Person() { Age = 21 });
            set.Add(new Person() { Age = 15 });
            set.Add(new Person() { Age = 31 });

            set.Sort();

            Person z = new Person() { Age = 23 };

            Console.WriteLine(set.Contains(z));

            foreach (Person p in set)
            {
                Console.WriteLine("Primeiro: " + p.Age);
            }
            Console.WriteLine(set.Contains(new Person()));

            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            a.UnionWith(b);

            SortedSet<int> c = new SortedSet<int>(a);
            c.IntersectWith(b);

            SortedSet<int> d = new SortedSet<int>(a);
            d.ExceptWith(b);

            PrintCollection(a);
            Console.WriteLine();
            PrintCollection(c);
            Console.WriteLine();
            PrintCollection(d);

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary["user"] = "maria";
            dictionary["email"] = "maria@gmail.com";

            Console.WriteLine(dictionary["email"]);


            string path = Console.ReadLine();

            StreamReader sr = null;
            Dictionary<string, int> exercicio = new Dictionary<string, int>();
            try
            {

                using (sr = File.OpenText(path))
                {
                    string[] lines = File.ReadAllLines(path);

                    foreach (string line in lines)
                    {
                        string name = line.Split(',')[0];
                        int valor = int.Parse(line.Split(',')[1]);
                        if(exercicio.ContainsKey(name))
                        {
                            exercicio[name] += valor;
                        } else
                        {
                            exercicio[name] = valor;
                        }
                       
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("erro");
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            foreach (KeyValuePair<string, int> valueDictionary in exercicio)
            {
                Console.WriteLine(valueDictionary.Key + ": " + valueDictionary.Value);
            }


        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
        }

    }


}

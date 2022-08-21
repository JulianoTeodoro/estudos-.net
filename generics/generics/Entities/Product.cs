using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace generics.Entities
{
    class Product : IComparable
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Not a product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

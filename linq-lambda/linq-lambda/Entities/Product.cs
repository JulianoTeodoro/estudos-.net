using System;
using System.Collections.Generic;
using System.Text;

namespace linq_lambda.Entities
{
    class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product;
            return Price.Equals(other.Price);
        }

        public override int GetHashCode()
        {
            return Price.GetHashCode();
        }

        public override string ToString()
        {
            return Name + " , R$ " + Price;
        }
    }
}

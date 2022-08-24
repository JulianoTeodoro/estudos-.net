using System;
using System.Collections.Generic;
using System.Text;

namespace linq_lambda.Entities
{
    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
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
            return "ID: " + Id + ", Name: " + Name + " , R$ " + Price;
        }
    }
}

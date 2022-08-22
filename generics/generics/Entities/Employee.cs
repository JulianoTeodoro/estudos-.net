using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace generics.Entities
{
    class Employee : IComparable
    {

        public string name { get; set; }
        public double salary { get; set; }
        
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            name = vect[0];
            salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return name + ", R$" + salary;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Não é employee");
            }
            Employee other = obj as Employee;

            return salary.CompareTo(other.salary);
        }


    }
}

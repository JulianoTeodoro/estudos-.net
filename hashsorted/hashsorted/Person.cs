using System;
using System.Collections.Generic;
using System.Text;

namespace hashsorted
{
    class Person: IComparable<Person>
    {
        public int Age { get; set; }

        public int CompareTo(Person p1)
        {
            if(!(p1 is Person))
            {
                throw new ArgumentException("Erro");
            }

            var other = p1 as Person;
            return Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }

            var other = obj as Person;
            return Age.Equals(other.Age);
        }

        public override int GetHashCode()
        {
            return Age.GetHashCode();
        }
    }
}

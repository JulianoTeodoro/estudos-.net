using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void addValue(T value)
        {
            if (_count == 10)
            {
                throw new ArgumentException("Passou de 10");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Não tem primeiro");
            }
            return _values[0];
        }

        public void Print()
        {
            if (_count == 0)
            {
                throw new ArgumentException("Não tem numeros");
            }
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ",");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]");
        }
    }
}

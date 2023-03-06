using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsages.Library
{
    public class GenericSort<T>
    {
        public GenericSort() { }

        delegate int CompareFunc(T first, T second);

        void Sort(List<T> items, CompareFunc compare) 
        {
            /*
             Тара
             Бара
             Стабара
             */
            if (compare(items[0], items[1]) == 1)
            {
                Console.WriteLine("1");
            }

        }
    }
}

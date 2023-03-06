using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericUsages.Library
{
    public class GenericSort<T>
    {
        public GenericSort() { }

        public delegate int CompareFunc(T first, T second);

        public List<T> Sort(List<T> items, CompareFunc compare)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count; j++)
                {
                    if (compare(items[j], items[i]) == 1)
                    {
                        SwapItems(items, i, j);
                    }
                }
            }
            return items;
        }

        private static void SwapItems(List<T> items, int i, int j)
        {
            T tmp = items[j];
            items[j] = items[i];
            items[i] = tmp;
        }
    }
}

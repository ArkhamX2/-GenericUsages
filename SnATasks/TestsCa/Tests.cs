using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnALibrary;

namespace TestsCa
{
    public class Tests
    {
        public void TestArray()
        {
            ClassArray<int> array = new ClassArray<int>(10, new List<int> {1,2,3,4,5,6,7,8,9,10 });

            Console.WriteLine("Длина: {0}\n" +
                "0й элемент: {1}\n" +
                "Отсортирован: {2}\n" +
                "Линейный поиск: {3}\n" +
                "Бинарный поиск: {4}\n", 
                array.GetLength, 
                array.GetList[0], 
                array.IsSorted(),
                array.LinearSearch(5),
                array.BinarySearch(5));

        }
    }
}

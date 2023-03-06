using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnALibrary;

namespace TestConsoleApp
{
    public class Tasks
    {
        public void Task2()
        {
            SnALibrary.DoublyList<double> list = new SnALibrary.DoublyList<double>(new List<double> {1,-2,3,-4,5,-6,7,-8,9,-10 });

            Console.WriteLine("Содержимое списка:");
            foreach (double item in list) Console.Write(item + " ");

            int index = 0;
            foreach (double item in list)
            {
                if (item < 0)
                    list.Insert(1.5,index);
                index++;
            }


            Console.WriteLine("\nСодержимое списка:");
            foreach (double item in list) Console.Write(item + " ");
        }
    }
}

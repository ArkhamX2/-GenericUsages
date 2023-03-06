using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class Node<T>
    {/// <summary>
     /// Класс дерева
     /// </summary>
     /// <typeparam name="T"> используемый тип данных </typeparam>
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        
    }
}

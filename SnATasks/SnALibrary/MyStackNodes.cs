using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    
    /// <summary>
    /// Класс стека на основе дерева
    /// </summary>
    /// <typeparam name="T">используемый тип данных</typeparam>
    public class MyStackNodes<T>
    {
        Node<T> _head;  //Вершина
        int _size;  //размер

        /// <summary>
        /// Конструктор по списку элементов
        /// </summary>
        /// <param name="items"></param>
        public MyStackNodes(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Push(items[i]);
            }
        }

        /// <summary>
        /// Индикатор заполнения
        /// </summary>
        public bool IsEmpty
        {
            get { return _size == 0; }
        }

        /// <summary>
        /// Достпп к размеру стека
        /// </summary>
        public int Count
        {
            get { return _size; }
        }

        /// <summary>
        /// Добавить элемент в стек
        /// </summary>
        /// <param name="item">элемент</param>
        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = _head;
            _head = node;
            _size++;
        }

        /// <summary>
        /// Удалить элемент из стека
        /// </summary>
        /// <returns>Удалённый элемент</returns>
        public T Pop()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            Node<T> tmp = _head;
            _head = _head.Next;
            _size--;
            return tmp.Data;
        }

        /// <summary>
        /// Посмотреть вершину стека
        /// </summary>
        /// <returns> Вершину стека </returns>
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return _head.Data;
        }
    }
}

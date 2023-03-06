using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsages.Library.GenericContainer
{
    public class GenericStack<T> : Container<T>
    {

        /// <summary>
        /// Конструктор по списку элементов
        /// </summary>
        /// <param name="items"></param>
        public GenericStack(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Add(items[i]);
            }
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public GenericStack()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }

        /// <summary>
        /// Добавить элемент в стек
        /// </summary>
        /// <param name="item">элемент</param>
        public override void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = _head;
            _head = node;
            _count++;
        }

        /// <summary>
        /// Удалить элемент из стека
        /// </summary>
        /// <returns>Удалённый элемент</returns>
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            Node<T> tmp = _head;
            _head = _head.Next;
            _count--;
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

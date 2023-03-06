using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsages.Library.GenericContainer
{
    public class GenericQueue<T> : Container<T>
    {

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
         GenericQueue()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }

        /// <summary>
        /// Конструктор по заданному списку элементов
        /// </summary>
        /// <param name="items">список элементов</param>
        public GenericQueue(List<T> items)
        {
            foreach (T item in items) Enqueue(item);
        }
        /// <summary>
        /// Добавление в очередь
        /// </summary>
        /// <param name="data"> добавляемый элемент </param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = _tail;
            _tail = node;

            if (_count == 0) //Для пустой очереди head и tail указывают на один и тот же элемент
                _head = _tail;
            else
                tempNode.Next = _tail;   // Переустанавливаем ссылку на последний элемент
            _count++;
        }
        


       
    }
}

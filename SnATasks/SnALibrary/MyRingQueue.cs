using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    /// <summary>
    /// Класс структуры данных "кольцевая очередь"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyRingQueue<T> : IEnumerable<T>
    {
        Node<T> head; //Первый элемент
        Node<T> tail; //Последний элемент
        int count; //Длина очереди

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyRingQueue()
        {
            count = 0;
            head = null;
            tail = null;
        }

        /// <summary>
        /// Конструктор по заднному списку элементов
        /// </summary>
        /// <param name="items">список элементов</param>
        public MyRingQueue(List<T> items)
        {
            foreach (T item in items) Add(item);
        }

        /// <summary>
        /// Длина очереди
        /// </summary>
        public int Count { get { return count; } }
        /// <summary>
        /// Индикатор наполненности очереди
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }

        /// <summary>
        /// Добавить элемент в очередь
        /// </summary>
        /// <param name="data">добавляемый элемент</param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            //Если очередь не пуста, то "вставляем" элемент,
            //Новый элемент ссылается на head
            //А на новый элемент ссылается tail

            if (head == null)   //Очередь пуста
            {
                head = node;
                tail = node;
                tail.Next = head;
            }
            else
            {
                node.Next = head;
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        /// <summary>
        /// Получить первый элемент
        /// </summary>
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        /// <summary>
        /// Получить последний элемент
        /// </summary>
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            while (current != head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

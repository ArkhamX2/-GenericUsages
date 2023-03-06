using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    /// <summary>
    /// Класс структуры данных "очередь"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyQueue<T> : IEnumerable<T>
    {
        Node<T> head; // Первый элемент
        Node<T> tail; // Последний элемент
        int count;    // Длина очереди

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyQueue()
        {
            count = 0;
            head = null;
            tail = null;
        }

        /// <summary>
        /// Конструктор по заданному списку элементов
        /// </summary>
        /// <param name="items">список элементов</param>
        public MyQueue(List<T> items)
        {
            foreach (T item in items) Enqueue(item);
        }

        /// <summary>
        /// Количество элементов в очереди
        /// </summary>
        public int Count { get { return count; } }
        /// <summary>
        /// Индикатор наполнения очереди
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }

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

        /// <summary>
        /// Добавление в очередь
        /// </summary>
        /// <param name="data"> добавляемый элемент </param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;

            if (count == 0) //Для пустой очереди head и tail указывают на один и тот же элемент
                head = tail;
            else
                tempNode.Next = tail;   // Переустанавливаем ссылку на последний элемент
            count++;
        }

        /// <summary>
        /// Удалить первый элемент
        /// </summary>
        public void RemoveFirst()
        {
            //Обнуляем ссылку на первый элемент
            head = head.Next;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}

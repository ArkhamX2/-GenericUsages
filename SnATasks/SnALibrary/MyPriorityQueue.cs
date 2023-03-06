using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class PriorityNode<T>
    {
        public PriorityNode(T data, int priority)
        {
            Data = data;
            Priority = priority;
        }
        public T Data { get; set; }
        public PriorityNode<T> Next { get; set; }

        public int Priority { get; set; }
    }
    /// <summary>
    /// Класс структуры данных "Приоритетная очередь"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyPriorityQueue<T> : IEnumerable<T>
    {
        PriorityNode<T> head;   //Первый элемент
        PriorityNode<T> tail;   //Последний элемент
        int count;  //Размер очереди

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyPriorityQueue()
        {
            count = 0;
            head = null;
            tail = null;
        }

        /// <summary>
        /// Конструктор по заданному списку элементов
        /// </summary>
        /// <param name="items">список элементов</param>
        /// <param name="priotities">приоритеты элементов</param>
        public MyPriorityQueue(List<T> items, List<int> priotities)
        {
            int index = 0;
            foreach (T item in items) {Enqueue(item, priotities[index]); index++; }
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        /// <summary>
        /// Получить первый элемент по приоритету O(N)
        /// </summary>
        public T FirstPriority(int priority)
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            PriorityNode<T> current = head;
            while (current != null)
            {
                if (current.Priority == priority) return current.Data;
                current = current.Next;
            }
            return default(T);
        }

        /// <summary>
        /// Метод добавления элемента в приоритетную очередь
        /// </summary>
        /// <param name="data">элемент</param>
        /// <param name="priority">приоритет элемента</param>
        public void Enqueue(T data,int priority)
        {
            PriorityNode<T> node = new PriorityNode<T>(data,priority);
            PriorityNode<T> tempNode = tail;
            tail = node;

            if (count == 0) //Для пустой очереди head и tail указывают на один и тот же элемент
                head = tail;
            else
                tempNode.Next = tail;   // Переустанавливаем ссылку на последний элемент
            count++;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            PriorityNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

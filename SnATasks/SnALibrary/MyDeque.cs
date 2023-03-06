using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    /// <summary>
    /// Класс структуры данных "Дек"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyDeque<T> : IEnumerable<T>
    {
        DoublyNode<T> head; //Первый элемент
        DoublyNode<T> tail; //Последний элемент
        int count;  //Длина дека

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MyDeque()
        {
            count = 0;
            head = null;
            tail = null;
        }

        /// <summary>
        /// Конструктор по заданному списка элементов
        /// </summary>
        /// <param name="items">заданный списко элементов</param>
        public MyDeque(List<T> items)
        {
            foreach (T item in items) AddLast(item);
        }

        /// <summary>
        /// Длина дека
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Индикатор наполнения дека
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }

        /// <summary>
        /// Чтение первого элемента
        /// </summary>
        public T First
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return head.Data;
            }
        }
        /// <summary>
        /// Чтение последнего элемента
        /// </summary>
        public T Last
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return tail.Data;
            }
        }

        /// <summary>
        /// Добавление в конец дека
        /// </summary>
        /// <param name="data">добавляемый элемент</param>
        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null) head = node;
            else  //Если дек не пустой, то переустанавливаем последнюю ссылку
            {
                tail.Next = node;
                node.Previous = tail;
            }

            tail = node;
            count++;
        }

        /// <summary>
        /// Добавление в начало дека
        /// </summary>
        /// <param name="data">добавляемый элемент</param>
        public void AddFirst(T data)
        {
            //Переустанавливаем ссылку на головной элемент, добавляя новый
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;

            if (count == 0)
                tail = head;
            else //Если дек не пуст, то "обратная" ссылка бывшей головы - новый узел
                temp.Previous = node;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}

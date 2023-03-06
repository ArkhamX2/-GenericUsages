using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T> head; //Первый элемент
        Node<T> tail; //Последний элемент
        int count; //Количество элементов

        /// <summary>
        /// Доступ к длине списка
        /// </summary>
        public int Count { get { return count; } }
        /// <summary>
        /// Индикатор заполненности списка
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public LinkedList()
        {
            count = 0;
            head = null;
            tail = null;
        }

        /// <summary>
        /// Конструктор по заданному списку
        /// </summary>
        /// <param name="items"></param>
        public LinkedList(List<T> items)
        {
            foreach (T item in items)
                Add(item);
        }

        /// <summary>
        /// Добавление элемента в конец списка
        /// </summary>
        /// <param name="data">добавляемый элемент</param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null) head = node;  //Если список пуст, то устанавливаем head и tail на один и тот же узел

            else tail.Next = node;  //Если список не пуст, то tail.Next хранит ссылку на новый узел

            tail = node;    //переустанавливаем ссылку tail на новый узел

            count++;
        }

        /// <summary>
        /// Удаление объекта из списка
        /// </summary>
        /// <param name="data"> удаляемый объект</param>
        /// <returns> false, если объект не найден </returns>
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null) //Перебираем все элементы списка
            {
                if (current.Data.Equals(data))  //Устанавливаем Next для предыдущего узла на след.узел по отношению к удалённому
                {
                    //не в начале
                    if (previous != null)
                    {
                        previous.Next = current.Next; //Переустанавливаем ссылку

                        if (current.Next == null) //Если нашёлся в конце, то переустаналиваем хвост
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;   //Передвигаем голову на 1 вперёд
                        if (head == null) tail = null;  //список пуст

                    }
                    count--;
                    return true;
                }
                previous = current; //Двигаемся по списку на 1 вперёд
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Копия списка
        /// </summary>
        /// <param name="startIndex"> начальный индекс</param>
        /// <param name="Length"> длина копии </param>
        /// <returns>Скопированная часть списка </returns>
        public LinkedList<T> CopyList(int startIndex, int Length)
        {
            if (startIndex + Length > count) throw new Exception();

            LinkedList<T> copied = new LinkedList<T>();
            int index = 0;
            Node<T> current = head;

            while(index != startIndex)  //Перемещаемся до нужного индекса
            {
                current = current.Next;
                index++;
            }

            while(Length > 0)   //Добавляем в копию необходимое количество элементов
            {
                copied.Add(current.Data);
                current = current.Next;
                Length--;
            }
            return copied;
        }

        /// <summary>
        /// Слияние двух списков в один без создания нового списка
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns> список из l1 и l2 </returns>
        public LinkedList<T> MergeListsNewList(LinkedList<T> l1, LinkedList<T> l2)
        {
            LinkedList<T> merged = new LinkedList<T>();
            foreach (T item in l1) merged.Add(item); 
            foreach (T item in l2) merged.Add(item);
            return merged;
        }

        /// <summary>
        /// Слияние двух списков в один без создания нового списка
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns>список l1+l2</returns>
        public LinkedList<T> MergeListsOneList(LinkedList<T> l1, LinkedList<T> l2)
        {
            LinkedList<T> copied = l1.CopyList(0,l1.Count);
            Node<T> head2 = l2.head;
            Node<T> copyTail = copied.tail;

            copyTail.Next = head2;

            return copied;
        }

        /// <summary>
        /// Поиск повторений указанного элемента
        /// </summary>
        /// <param name="data">Значение элемента</param>
        /// <returns></returns>
        public bool ContainsRepeat(T data)
        {
            //Счётчик повторений
            int counter = 0;
            //Перебираем элементы списка
            Node<T> current = head;
            while(current != null)
            {
                //Для искомого элемента
                if(current.Data.Equals(data))
                {
                    //перебираем оставшийся список и ищем повторения
                    Node<T> tmp = current.Next;
                    while (tmp != null)
                    {
                        //Элемент повторился
                        if (tmp.Data.Equals(data))
                            counter++;
                        tmp = tmp.Next;
                    }

                    //Если найдены повторения возвращаем true
                    if (counter > 0)
                        return true;
                    //Если нет ни одного повторения - false
                    return false;
                }
                current = current.Next;
            }
            //Если указанного элемента вообще нет в списке
            return false;
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

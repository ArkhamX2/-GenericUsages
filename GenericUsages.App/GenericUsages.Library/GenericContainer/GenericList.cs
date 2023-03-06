using GenericUsages.Library.GenericContainer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsages.Library
{
    public class GenericList<T> : Container<T>
    {
        public GenericList()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }

        /// <summary>
        /// Конструктор по заданному списку
        /// </summary>
        /// <param name="items"></param>
        public GenericList(List<T> items)
        {
            foreach (T item in items)
                Add(item);
        }

        /// <summary>
        /// Добавление элемента в конец списка
        /// </summary>
        /// <param name="data">добавляемый элемент</param>
        public override void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head == null) _head = node;  //Если список пуст, то устанавливаем head и tail на один и тот же узел

            else _tail.Next = node;  //Если список не пуст, то tail.Next хранит ссылку на новый узел

            _tail = node;    //переустанавливаем ссылку tail на новый узел

            _count++;
        }

        /// <summary>
        /// Удаление объекта из списка
        /// </summary>
        /// <param name="data"> удаляемый объект</param>
        /// <returns> false, если объект не найден </returns>
        public override void Delete(T data)
        {
            Node<T> current = _head;
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
                            _tail = previous;
                    }
                    else
                    {
                        _head = _head.Next;   //Передвигаем голову на 1 вперёд
                        if (_head == null) _tail = null;  //список пуст

                    }
                    _count--;
                    return;
                }
                previous = current; //Двигаемся по списку на 1 вперёд
                current = current.Next;
            }
            return;
        }
    }
}

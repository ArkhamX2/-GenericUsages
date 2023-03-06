using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class MyStack<T>
    {
        private T[] _items; //стек
        private int _size;  //размер стека
        const int _defaultSize = 10; //Размер стека по умолчанию

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public MyStack()
        {
            _items = new T[_defaultSize];
        }

        /// <summary>
        /// Конструктор по длине стека
        /// </summary>
        /// <param name="length"> Длина стека </param>
        public MyStack(int length)
        {
            _items = new T[length];
        }

        /// <summary>
        /// Конструктор по заданному списку элементов
        /// </summary>
        /// <param name="values"></param>
        public MyStack(List<T> values)
        {
            _items = values.ToArray();
            _size = _items.Length;
        }

        /// <summary>
        /// Проверка пуст ли стек
        /// </summary>
        public bool IsEmpty
        {
            get { return _size == 0; }
        }

        /// <summary>
        /// Получить длину стека
        /// </summary>
        public int Count
        {
            get { return _size; }
        }

        /// <summary>
        /// Добавить элемент в стек
        /// </summary>
        /// <param name="item"> добавляемый элемент </param>
        public void Push(T item)
        {
            if (_size == _items.Length) //Если стек полон, то добавляем ещё 10 пустых ячеек
                Resize(_items.Count() + 10);
            _items[_size++] = item;
        }

        /// <summary>
        /// Изменить размер стека
        /// </summary>
        /// <param name="max"> новый максимальный размер</param>
        private void Resize(int max)
        {
            //Копируем стек в новый массив
            T[] tmpItems = new T[max];
            for (int i = 0; i < _size; i++)
            {
                tmpItems[i] = _items[i];
            }
            _items = tmpItems;
        }

        /// <summary>
        /// Удалить элемент из стека
        /// </summary>
        /// <returns>Удалённый элемент</returns>
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            T item = _items[--_size];
            _items[_size] = default(T);


            //Если действительный размер стека уменьшился и осталось 10 пустых ячеек, то они удаляются
            if (_size > 0 && _size < _items.Length - 10)    
                Resize(_items.Length - 10);

            return item;
        }

        /// <summary>
        /// Посмотреть вершину стека
        /// </summary>
        /// <returns> вершина стека </returns>
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return _items[_size - 1];
        }

    }
}

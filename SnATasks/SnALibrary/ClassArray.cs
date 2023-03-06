using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class ClassArray<T> : IEnumerable where T : IEquatable<T>, IComparable<T>
    {
        private List<T> _list = new List<T>();
        private int _length = 0;

        public ClassArray()
        {
        }

        public ClassArray(int n)
        {
            if (n < 0) throw new Exception("Длина массива не может быть меньеш нуля");
            _length = n;
            for (int i = 0; i < n; i++)
            {
                _list.Add(default(T));
            }
        }

        public ClassArray(List<T> array)
        {
            if (array.Count == 0) throw new Exception("Необходимо указать непустой массив");
            _length = array.Count;
            _list = array;
        }

        public List<T> GetList
        {
            get { return _list; }
        }

        public int GetLength
        {
            get { return _length; }
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Delete(T item)
        {
            _list.Remove(item);
        }


        public int LinearSearch(T item) //O(N)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_list[i].Equals(item)) return i;
            }
            return -1;
        }

        public int BinarySearch(T item) //O(logN)
        {
            int Sort = IsSorted();
            if (Sort==0) throw new Exception("Бинарный поиск требует отсортированный массив на вход");
            bool reversed = false;
            if (Sort < 0) {
                reversed = true;
                _list.Reverse();
            }

            int LeftBorder = 0, RightBorder = _length - 1;
            int Pivot;
            while (LeftBorder <= RightBorder)
            {
                Pivot = (LeftBorder + RightBorder) / 2;

                if (_list[Pivot].Equals(item))
                {
                    if(reversed) _list.Reverse();
                    return reversed ? _length - 1 - Pivot : Pivot;
                }

                if (_list[Pivot].CompareTo(item) > 0)
                {
                    RightBorder = Pivot - 1;  //item < Pivot
                }
                else LeftBorder = Pivot + 1;    //item > Pivot
            }
            return -1;
        }

        public int JumpSearch(T item)   //O(sqrt(N))
        {
            int Sort = IsSorted();
            if (Sort == 0) throw new Exception("Бинарный поиск требует отсортированный массив на вход");
            bool reversed = false;
            if (Sort < 0)
            {
                reversed = true;
                _list.Reverse();
            }

            int step = (int)Math.Sqrt(_length);

            int prev = 0;

            //Ищем часть массива, где находистя искомый элемент
            while(_list[Math.Min(step,_length)-1].CompareTo(item) < 0)
            {
                prev = step;
                step += (int)Math.Sqrt(_length);
                if (prev >= _length) return -1;
            }

            //Выполняем линейный поиск элемента в блоке
            while (_list[prev].CompareTo(item) < 0)
            {
                prev++;
                if (prev == Math.Min(step, _length)) return -1;
            }

            if (_list[prev].Equals(item))
            {
                if (reversed) _list.Reverse();
                return reversed ? _length - 1 - prev : prev;
            }
            else
                return prev;

            return -1;
        }

        public int ExponentialSearch(T item)
        {
            int Sort = IsSorted();
            if (Sort == 0) throw new Exception("Бинарный поиск требует отсортированный массив на вход");
            bool reversed = false;
            if (Sort < 0)
            {
                reversed = true;
                _list.Reverse();
            }

            if (_list[0].Equals(item)) return 0;

            int i = 1;
            while (i < _length && _list[i].CompareTo(item) <= 0) i = i * 2;


            int LeftBorder = i/2, RightBorder = Math.Min(i,_length-1);
            int Pivot;
            while (LeftBorder <= RightBorder)
            {
                Pivot = (LeftBorder + RightBorder) / 2;

                if (_list[Pivot].Equals(item))
                {
                    if(reversed) _list.Reverse();
                    return reversed ? _length - 1 - Pivot : Pivot;
                }
                    

                if (_list[Pivot].CompareTo(item) > 0) RightBorder = Pivot - 1;  //item < Pivot
                else LeftBorder = Pivot + 1;    //item > Pivot
            }

            return -1;
        }

        public int BinarySearchRecursive(T item)
        {
            int Sort = IsSorted();
            if (Sort == 0) throw new Exception("Бинарный поиск требует отсортированный массив на вход");
            bool reversed = false;
            if (Sort < 0)
            {
                reversed = true;
                _list.Reverse();
            }

            int answer = BinarySearchR(0, _length, item);
            if(reversed) _list.Reverse();

            return reversed ? _length - 1- answer : answer ;
        }

        private int BinarySearchR(int LeftBorder, int RightBorder, T item)
        {
            if (RightBorder >= 1)
            {
                int Pivot = LeftBorder + (RightBorder - LeftBorder) / 2;

                if (_list[Pivot].Equals(item)) return Pivot;

                if (_list[Pivot].CompareTo(item) > 0) return BinarySearchR(LeftBorder,Pivot-1,item);

                return BinarySearchR(Pivot+1,RightBorder,item);

            }
            return -1;
        }

        /// <summary>
        /// Функция определения отсортирован список или нет и порядка сортировки
        /// </summary>
        /// <param name="list">список</param>
        /// <returns>Значение меньше нуля, если отсортирован по убыванию,
        /// Значение больше нуля, если отсортирован по возрастанию,
        /// и ноль, если не отсортирован.</returns>
        public int IsSorted()
        {
            bool asc = true;
            bool desc = true;
            for (int i = 0; i < _length-1; i++)
            {
                if (_list[i].CompareTo(_list[i + 1]) < 0) desc = false;
                if (_list[i].CompareTo(_list[i + 1]) > 0) asc = false;
            }
            if (asc) return 1;
            if (desc) return -1;
            return 0;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}

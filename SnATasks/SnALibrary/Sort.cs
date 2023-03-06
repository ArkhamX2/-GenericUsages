using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class Sort
    {
        /// <summary>
        /// Метод копии массива
        /// </summary>
        /// <param name="input"> исходный массив</param>
        /// <returns>копия массива</returns>
        private int[] CopyArr(int[] input)
        {
            int[] copy = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                copy[i] = input[i];
            }
            return copy;
        }

        /// <summary>
        /// Сортировка выбором| O(N^2)
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] SelectionSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            //Двигаем левую границу неотсортированного массива на 1
            for (int i = 0; i < n - 1; i++)
            {
                // Ищем минимальный элемент в неотсортированной части массива
                int min_index = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[min_index])
                        min_index = j;

                // Перемещаем найденный минимум в начало
                int temp = array[min_index];
                array[min_index] = array[i];
                array[i] = temp;
            }

            return array;
        }

        /// <summary>
        /// Пузырьковая сортировка| O(N^2)
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] BubbleSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            //Проходим по массиву, каждый раз перемещая большие элементы в правую часть массива
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        //Меняем местами элементы
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

            return array;
        }

        /// <summary>
        /// Сортировка вставками | O(N^2)
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] InsertSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            //Двигаем левую границу неотсортированного массива на 1
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // "Вставляем" ключ в отсортированную часть массива
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = key;
            }

            return array;
        }

        /// <summary>
        /// Сортировка Шелла | O(N logN)
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] ShellSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            // Устанавливаем границу сортировки, уменьшаем её в 2 раза каждый раз
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Выполняем сортировку вставками на подмассиве, меняя элементы на расстоянии gap
                for (int i = gap; i < n; i += 1)
                {
                    int temp = array[i];

                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];

                    array[j] = temp;
                }
            }

            return array;
        }

        /// <summary>
        /// Сортировка подсчётом | O(N+K)
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] CountSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);


            int[] minmax = FindMinMax(array);
            int min = minmax[0];
            int max = minmax[1];

            //Так как в массиве допустимы отрицательные числа, то все индексы нового массива сдвинутся на |min|
            //Если в массиве отрицательных чисел нет, то разумно сократить длину нового массива на minim
            int negatives = min != 0 ? -min : 0;
            max += negatives;

            // Подсчёт количества чисел в сортируемом массиве
            int[] count = CountNums(array, max, negatives);

            int index = 0;  //индекс в новом массиве

            for (int i = 0; i < count.Length; i++)    //перезапись сортируемого массива
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[index] = i - negatives;
                    index++;
                }
            }

            return array;
        }

        /// <summary>
        /// Подсчёт количества чисел
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <param name="max">максимальное число</param>
        /// <param name="negatives">количество отрицательных чисел</param>
        /// <returns>массив, содержащий количество чисел по индексам</returns>
        private int[] CountNums(int[] array, int max, int negatives)
        {
            int[] count = new int[max + 1];
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] + negatives]++;
            }
            return count;
        }

        /// <summary>
        /// Поиск минимального и максимального значения
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns>массив{0 минимум,1 максимум}</returns>
        private int[] FindMinMax(int[] array)
        {

            int[] minmax = new int[2] {array[0],array[0]};
            
            for (int i = 1; i < array.Length; i++)   //поиск минимального и максимального значения в сортируемом массиве
            {
                if (array[i] > minmax[1])
                {
                    minmax[1] = array[i];
                }
                else if (array[i] < minmax[0])
                {
                    minmax[0] = array[i];
                }
            }

            return minmax;
        }

        /// <summary>
        /// Поразрядная сортировка по последнему символу | O(NlogB(N))
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] LSDRadixSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            // Находим максимум, чтобы знать максимальное количество цифр в числе
            int m = getMax(array, n);

            // Осуществляет сортировку подсчётом для каждого знака
            // exp = 10^i, где i-текущий знак числа (последний, предпоследний...)
            for (int exp = 1; m / exp > 0; exp *= 10)
                array = countSort(array, n, exp);

            return array;
        }

        /// <summary>
        /// Поиск максимального значения в массиве
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <param name="n">длина исходного массива</param>
        /// <returns>максимальный элемент в массиве</returns>
        private int getMax(int[] array, int n)
        {
            int max = array[0];
            for (int i = 1; i < n; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }

        /// <summary>
        /// Сортировка подсчётом для поразрядной сортировки
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <param name="n">длина исходного массива</param>
        /// <param name="exp">разряд цифры</param>
        /// <returns>Отсортированный по разряду массив</returns>
        private int[] countSort(int[] input, int n, int exp)
        {
            int[] array = CopyArr(input);

            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            // Подсчитываем количество чисел по последней цифре
            for (i = 0; i < n; i++)
                count[(array[i] / exp) % 10]++;

            
            //Теперь count[i] хранит текущую позицию числа в output[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Формируем массив output[]
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            // копируем output в array, который теперь хранит отсортированные по последнему знаку
            for (i = 0; i < n; i++)
                array[i] = output[i];

            return array;
        }

        /// <summary>
        /// </summary>
        /// <param name="input">Неотсортированный массив</param>
        /// <returns>Отсортированный массив</returns>
        public int[] QuickSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            quickSort(array, 0, n - 1);

            return array;
        }
        /// <summary>
        /// Быстрая сортировка  | O(NlogN)
        /// </summary>
        /// <param name="arr">Неотсортированный массив</param>
        /// <param name="low">левая граница массива</param>
        /// <param name="high">правая граница массива</param>
        private void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                // pi - опорный элемент
                int pi = Partition(arr, low, high);

                // Сортируем массив по частям рекурсивно
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        /// <summary>
        /// Поиск опорного элемента для быстрой сортировки
        /// </summary>
        /// <param name="arr">неотсортированный массив</param>
        /// <param name="low">левая граница массива</param>
        /// <param name="high">правая граница массива</param>
        /// <returns>опорный элемент</returns>
        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // Индекс меньшего элемента
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                // Если текущий элемент меньше меньшего
                if (arr[j] < pivot)
                {
                    // увеличиваем индекс меньшего
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        /// <summary>
        /// Метод обмена двух значений в массиве
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="i">индекс первого элемента</param>
        /// <param name="j">индекс второго элемента</param>
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// Сортировка слиянием | O(NlogN)
        /// </summary>
        /// <param name="input">Неотсортированный массива</param>
        /// <returns>Отсортированный массив</returns>
        public int[] MergeSort(int[] input)
        {
            int n = input.Length;
            int[] array = CopyArr(input);

            mSort(array, 0, n - 1);

            return array;
        }

        /// <summary>
        /// Сортировка слиянием
        /// </summary>
        /// <param name="array">неотсортированны массив</param>
        /// <param name="LeftBorder">левая граница массива</param>
        /// <param name="RightBorder">правая граница массива</param>
        private void mSort(int[] array, int LeftBorder, int RightBorder)
        {
            if (LeftBorder < RightBorder)
            {
                // Центральный элемент
                int Middle = LeftBorder + (RightBorder - LeftBorder) / 2;

                // Сортируем левую и правую половину
                mSort(array, LeftBorder, Middle);
                mSort(array, Middle + 1, RightBorder);

                // Объединяем отсортированные части
                Merge(array, LeftBorder, Middle, RightBorder);
            }
        }

        /// <summary>
        /// Метод слияния двух частей массива
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <param name="LeftBorder">левая граница</param>
        /// <param name="Middle">разделяющий элемент</param>
        /// <param name="RightBorder">правая граница</param>
        private void Merge(int[] array, int LeftBorder, int Middle, int RightBorder)
        {
            // Размеры массивов для слияния
            int sizeFirst = Middle - LeftBorder + 1;
            int sizeSecond = RightBorder - Middle;

            // Временные массивы
            int[] Left = new int[sizeFirst];
            int[] Right = new int[sizeSecond];
            int i, j;

            // Копируем элементы в временные массивы
            for (i = 0; i < sizeFirst; ++i)
                Left[i] = array[LeftBorder + i];
            for (j = 0; j < sizeSecond; ++j)
                Right[j] = array[Middle + 1 + j];

            // Слияние

            // Индексы для Left[] и Right[]
            i = 0;
            j = 0;

            // Индекс для единого массива
            int k = LeftBorder;
            while (i < sizeFirst && j < sizeSecond)
            {
                if (Left[i] <= Right[j])
                {
                    array[k] = Left[i];
                    i++;
                }
                else
                {
                    array[k] = Right[j];
                    j++;
                }
                k++;
            }

            // Копируем оставшиеся элементы Left[] и Right[]

            while (i < sizeFirst)
            {
                array[k] = Left[i];
                i++;
                k++;
            }

            while (j < sizeSecond)
            {
                array[k] = Right[j];
                j++;
                k++;
            }
        }
    }
}

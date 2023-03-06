using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnALibrary;

namespace TestConsoleApp
{
    public class Tests
    {
        #region Last
        public void TestArray()
        {
            ClassArray<int> array = new ClassArray<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Console.WriteLine("Длина: {0}\n" +
                "0й элемент: {1}\n" +
                "Отсортирован: {2}\n" +
                "Линейный поиск(9): {3}\n" +
                "Бинарный поиск(9): {4}\n" +
                "Рекурсивный бинарный поиск(9): {7}\n" +
                "Переходный поиск(9): {5}\n" +
                "Экспоненциальный поиск(9): {6}\n" +
                "Элементы массива:\n",
                array.GetLength,
                array.GetList[0],
                array.IsSorted(),
                array.LinearSearch(9),
                array.BinarySearch(9),
                array.JumpSearch(9),
                array.ExponentialSearch(9),
                array.BinarySearchRecursive(9));
            PrintArray(array.GetList);

            ClassArray<int> array2 = new ClassArray<int>(new List<int> { 1, 2, 8, 9, 10 });

            Console.WriteLine("Длина: {0}\n" +
                "0й элемент: {1}\n" +
                "Отсортирован: {2}\n" +
                "Линейный поиск(9): {3}\n" +
                "Бинарный поиск(9): {4}\n" +
                "Рекурсивный бинарный поиск(9): {7}\n" +
                "Переходный поиск(9): {5}\n" +
                "Экспоненциальный поиск(9): {6}\n" +
                "Элементы массива:\n",
                array2.GetLength,
                array2.GetList[0],
                array2.IsSorted(),
                array2.LinearSearch(9),
                array2.BinarySearch(9),
                array2.JumpSearch(9),
                array2.ExponentialSearch(9),
                array2.BinarySearchRecursive(9));
            PrintArray(array2.GetList);


            ClassArray<int> array3 = new ClassArray<int>(new List<int> { 10, 9, 8, 7, 6, 6, 6, 6, 6, 6, 6, 5, 4, 3, 2, 1 });

            Console.WriteLine("Длина: {0}\n" +
                "0й элемент: {1}\n" +
                "Отсортирован: {2}\n" +
                "Линейный поиск(9): {3}\n" +
                "Бинарный поиск(9): {4}\n" +
                "Рекурсивный бинарный поиск(9): {7}\n" +
                "Переходный поиск(9): {5}\n" +
                "Экспоненциальный поиск(9): {6}\n" +
                "Элементы массива:\n",
                array3.GetLength,
                array3.GetList[0],
                array3.IsSorted(),
                array3.LinearSearch(9),
                array3.BinarySearch(9),
                array3.JumpSearch(9),
                array3.ExponentialSearch(9),
                array3.BinarySearchRecursive(9));
            PrintArray(array3.GetList);

            ClassArray<string> array4 = new ClassArray<string>(5);
            for (int i = 0; i < array4.GetLength; i++)
            {
                array4.GetList[i] = i.ToString();
            }

            Console.WriteLine("Длина: {0}\n" +
                "0й элемент: {1}\n" +
                "Отсортирован: {2}\n" +
                "Линейный поиск(4): {3}\n" +
                "Бинарный поиск(4): {4}\n" +
                "Рекурсивный бинарный поиск(4): {7}\n" +
                "Переходный поиск(4): {5}\n" +
                "Экспоненциальный поиск(4): {6}\n" +
                "Элементы массива:\n",
                array4.GetLength,
                array4.GetList[0],
                array4.IsSorted(),
                array4.LinearSearch("4"),
                array4.BinarySearch("4"),
                array4.JumpSearch("4"),
                array4.ExponentialSearch("4"),
                array4.BinarySearchRecursive("4"));
            PrintArray(array4.GetList);

            ClassArray<int> array5 = new ClassArray<int>(5);
            for (int i = 0; i < array5.GetLength; i++)
            {
                array5.GetList[i] = i + 1;
            }

            Console.Write("Длина: {0}\n" +
                "0й элемент: {1}\n" +
                "Отсортирован: {2}\n" +
                "Линейный поиск(4): {3}\n" +
                "Бинарный поиск(4): {4}\n" +
                "Рекурсивный бинарный поиск(4): {7}\n" +
                "Переходный поиск(4): {5}\n" +
                "Экспоненциальный поиск(4): {6}\n" +
                "Элементы массива:\n",
                array5.GetLength,
                array5.GetList[0],
                array5.IsSorted(),
                array5.LinearSearch(4),
                array5.BinarySearch(4),
                array5.JumpSearch(4),
                array5.ExponentialSearch(4),
                array5.BinarySearchRecursive(4)); ;
            PrintArray(array5.GetList);
        }

        private void PrintArray<T>(List<T> array)
        {
            foreach (T element in array)
                Console.Write(element.ToString() + " ");
            Console.WriteLine("\n___________");

        }

        public void NaiveSearchTest(string source)
        {
            Console.WriteLine("NaiveSearchTest():\n" +
                "Искомая подстрока:");
            string find = Console.ReadLine();
            Console.WriteLine($"Список всех вхождений {find} в текст:\n");

            Search s = new Search();
            foreach (int found in s.NaiveSearch(source, find))
                Console.Write(found.ToString() + " ");
            Console.WriteLine("\n___________");
        }
        public void RKSearchTest(string source)
        {
            Console.WriteLine("RKSearchTest():\n" +
                "Искомая подстрока:");
            string find = Console.ReadLine();
            Console.WriteLine($"Список всех вхождений {find} в текст:\n");

            Search s = new Search();
            foreach (int found in s.RKSearch(find, source,101))
                Console.Write(found.ToString() + " ");
            Console.WriteLine("\n___________");
        }
        public void KMPSearchTest(string source)
        {
            Console.WriteLine("KMPSearchTest():\n" +
                "Искомая подстрока:");
            string find = Console.ReadLine();
            Console.WriteLine($"Список всех вхождений {find} в текст:\n");

            Search s = new Search();
            foreach (int found in s.KMPSearch(source, find))
                Console.Write(found.ToString() + " ");
            Console.WriteLine("\n___________");

        }

        public void StemmingTestOnce()
        {
            Stemming stem = new Stemming();
            Console.WriteLine("StemmingTest():\n" +
                "Слово для стемминга:");
            string word = Console.ReadLine();
            Console.WriteLine("Результат стемминга:"+stem.Stem(word));

        }

        public void StemmingTestArray(string[] words)
        {
            Stemming stem = new Stemming();
            Console.WriteLine("StemmingTest():\n" +
                "Слова для стемминга:");
            foreach (string w in words) Console.Write(w+" ");
            Console.WriteLine("\nРезультат стемминга:");
            foreach (string w in words) Console.Write(stem.Stem(w)+" ");

        }

        public void SelectionSort(int[] source)
        {
            Console.WriteLine($"SelectionSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.SelectionSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void BubbleSort(int[] source)
        {
            Console.WriteLine($"BubbleSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.BubbleSort(source);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            //PrintSortedArray(answer);
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void InsertSort(int[] source)
        {
            Console.WriteLine($"InsertionSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.InsertSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void ShellSort(int[] source)
        {
            Console.WriteLine($"ShellSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.ShellSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void CountSort(int[] source)
        {
            Console.WriteLine($"CountSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.CountSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void LSDRadixSort(int[] source)
        {
            Console.WriteLine($"LSDRadixSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.LSDRadixSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void QuickSort(int[] source)
        {
            Console.WriteLine($"QuickSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.QuickSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }
        public void MergeSort(int[] source)
        {
            Console.WriteLine($"MergeSort():\n");
            Sort s = new Sort();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] answer = s.MergeSort(source);
            //PrintSortedArray(answer);
            stopWatch.Stop();
            Console.WriteLine($"Количество элементов:{answer.Length}");
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("\n___________");
        }

        private void PrintSortedArray(int[] array)
        {
            foreach(int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void ArrayStackTest()
        {
            Console.WriteLine("ArrayStackTest");
            MyStack<int> stack = new MyStack<int> ( new List<int>() { 1, 2, 3, 4, 5, 6 } );

            Console.WriteLine("Push(7)");
            stack.Push(7);
            Console.WriteLine(stack.Peek());

            Console.WriteLine("Pop()");
            stack.Pop();
            Console.WriteLine(stack.Peek());


            Console.WriteLine("Pop()");
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }

        public void NodeStackTest()
        {
            Console.WriteLine("NodeStackTest");
            MyStackNodes<int> stack = new MyStackNodes<int>(new List<int>() { 1, 2, 3, 4, 5, 6 });


            Console.WriteLine("Push(7)");
            stack.Push(7);
            Console.WriteLine(stack.Peek());

            Console.WriteLine("Pop()");
            stack.Pop();
            Console.WriteLine(stack.Peek());


            Console.WriteLine("Pop()");
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
        public void MyDequeTest()
        {

            Console.WriteLine("MyDequeTest()");
            MyDeque<string> deque = new MyDeque<string>(new List<string> { "Галя", "Маша", "Ваня", "Петя", "Саша" });
            Console.WriteLine("Содержимое дека:");
            foreach (string item in deque) Console.Write(item + " ");

            Console.WriteLine("\n+Коля в начало +Гриша в конец");
            deque.AddFirst("Коля");
            deque.AddLast("Гриша");

            Console.WriteLine($"\nПервый элемент:{deque.First} Последний элемент:{deque.Last}");

            MyDeque<string> eDeque = new MyDeque<string>();
            string empty = eDeque.IsEmpty ? "Дек пуст" : "Дек не пуст";
            Console.WriteLine("\nПроверка на пустоту нового дека:" + empty);
            empty = deque.IsEmpty ? "Дек пуст" : "Дек не пуст";
            Console.WriteLine("\nПроверка на пустоту исходного дека:" + empty);

        }

        public void MyQueueTest()
        {
            Console.WriteLine("MyQueueTest()");
            MyQueue<string> queue = new MyQueue<string>(new List<string> { "Галя", "Маша", "Ваня", "Петя", "Саша" });
            Console.WriteLine("Содержимое очереди:");
            foreach (string item in queue) Console.Write(item + " ");

            Console.WriteLine("\n+Коля");
            queue.Enqueue("Коля");

            Console.WriteLine($"\nПервый элемент:{queue.First} Последний элемент:{queue.Last}");

            MyQueue<string> eQueue = new MyQueue<string>();
            string empty = eQueue.IsEmpty ? "Очередь пуста" : "Очередь не пуста";
            Console.WriteLine("\nПроверка на пустоту новой очереди:" + empty);
            empty = queue.IsEmpty ? "Очередь пуста" : "Очередь не пуста";
            Console.WriteLine("\nПроверка на пустоту исходной очереди:" + empty);
        }

        public void MyRingQueueTest()
        {
            Console.WriteLine("MyRingQueueTest()");
            MyRingQueue<string> ringQueue = new MyRingQueue<string>(new List<string> { "Галя", "Маша", "Ваня", "Петя", "Саша" });
            Console.WriteLine("Содержимое кольцевой очереди:");
            foreach (string item in ringQueue) Console.Write(item + " ");

            Console.WriteLine("\n+Коля");
            ringQueue.Add("Коля");

            Console.WriteLine($"\nПервый элемент:{ringQueue.First} Последний элемент:{ringQueue.Last}");

            MyRingQueue<string> eQueue = new MyRingQueue<string>();
            string empty = eQueue.IsEmpty ? "Очередь пуста" : "Очередь не пуста";
            Console.WriteLine("\nПроверка на пустоту новой очереди:" + empty);
            empty = ringQueue.IsEmpty ? "Очередь пуста" : "Очередь не пуста";
            Console.WriteLine("\nПроверка на пустоту исходной очереди:" + empty);
        }

        public void MyPriorityQueueTest()
        {
            Console.WriteLine("MyPriorityQueueTest()");
            MyPriorityQueue<string> queue = new MyPriorityQueue<string>(new List<string> { "Галя", "Маша", "Ваня", "Петя", "Саша" },new List<int> {0,1,2,1,0});
            Console.WriteLine("Содержимое очереди:");
            foreach (string item in queue) Console.Write(item + " ");

            Console.WriteLine("\n+Коля-3");
            queue.Enqueue("Коля",3);

            Console.WriteLine("\n+Гриша=0");
            queue.Enqueue("Гриша", 0);

            Console.WriteLine($"\nПервый элемент 0приоритета:{queue.FirstPriority(0)}");
            Console.WriteLine($"\nПервый элемент 1приоритета:{queue.FirstPriority(1)}");
            Console.WriteLine($"\nПервый элемент 2приоритета:{queue.FirstPriority(2)}");
            Console.WriteLine($"\nПервый элемент 3приоритета:{queue.FirstPriority(3)}");

            Console.WriteLine("Вся очередь:");
            foreach (string item in queue) Console.Write(item + " ");

            MyPriorityQueue<string> eQueue = new MyPriorityQueue<string>();
            string empty = eQueue.IsEmpty ? "Очередь пуста" : "Очередь не пуста";
            Console.WriteLine("\nПроверка на пустоту новой очереди:" + empty);
            empty = queue.IsEmpty ? "Очередь пуста" : "Очередь не пуста";
            Console.WriteLine("\nПроверка на пустоту исходной очереди:" + empty);
        }

        public void LinkedListTest()
        {
            Console.WriteLine("LinkedListTest():");
            SnALibrary.LinkedList<string> linkedList = new SnALibrary.LinkedList<string>(new List<string> {"Галя","Маша","Ваня","Петя","Саша"});

            Console.WriteLine("\nСодержимое списка:");
            foreach (string item in linkedList) Console.Write(item+" ");

            Console.WriteLine("\n\n+Коля +Толя");
            linkedList.Add("Коля");
            linkedList.Add("Толя");

            Console.WriteLine("\nСодержимое списка:");
            foreach (string item in linkedList) Console.Write(item + " ");

            Console.WriteLine("\n\n-Ваня -Коля");
            linkedList.Remove("Коля");
            linkedList.Remove("Ваня");

            Console.WriteLine("\nСодержимое списка:");
            foreach (string item in linkedList) Console.Write(item + " ");

            Console.WriteLine("\n\nКопия с 2 по 4");
            SnALibrary.LinkedList<string> copy = new SnALibrary.LinkedList<string>();
            copy = linkedList.CopyList(1,3);

            Console.WriteLine("\nСодержимое копии:");
            foreach (string item in copy) Console.Write(item + " ");

            Console.WriteLine("\n\nИсходный + копия (Новый список)");
            SnALibrary.LinkedList<string> merge = new SnALibrary.LinkedList<string>();
            merge = merge.MergeListsNewList(linkedList,copy);

            Console.WriteLine("\nСодержимое объединённого:");
            foreach (string item in merge) Console.Write(item + " ");

            Console.WriteLine("\n\nИсходный + копия");
            linkedList = linkedList.MergeListsOneList(linkedList, copy);

            Console.WriteLine("\nСодержимое объединённого:");
            foreach (string item in merge) Console.Write(item + " ");

            string empty = linkedList.IsEmpty ? "Исходный пуст" : "Исходный не пуст";
            Console.WriteLine("\n\nПроверка на пустоту исходного:" + empty);

            empty = new SnALibrary.LinkedList<string>().IsEmpty ? "Исходный пуст" : "Исходный не пуст";
            Console.WriteLine("\n\nПроверка на пустоту нового:" + empty);

        }

        public void ArithmeticParseTest()
        {
            Console.WriteLine("ArithmeticParseTest()\n Введите арифметическое выражение:");
            string input = Console.ReadLine();
            ArithmeticParser parser = new ArithmeticParser();
            List<string> parsed = parser.Parse(input);

            foreach (string item in parsed) Console.Write(item + " ");

        }

        public void ArithmeticEvaluationTest()
        {
            Console.WriteLine("ArithmeticEvaluationTest():\n Введите арифметическое выражение:");
            string input = Console.ReadLine();

            ArithmeticParser parser = new ArithmeticParser();
            ArithmeticEvaluator eval = new ArithmeticEvaluator();

            double result = eval.EvaluateEquation(parser.Parse(input));
            Console.WriteLine(result);

        }

        public void EvenCycleTest()
        {
            MyRingQueue<int> cycle = new MyRingQueue<int>() { 1, 2, 3, 4, 5, 6, 7 };
            
            int mul = 1;
            foreach (int num in cycle) mul *= num % 2 == 0 ? num : 1;

            Console.WriteLine("Содержимое очереди");
            foreach (int item in cycle) Console.Write(item + " ");
            Console.WriteLine();

            cycle.Add(mul);
            Console.WriteLine("Произведение:" + mul);

            Console.WriteLine("Содержимое очереди");
            foreach (int item in cycle) Console.Write(item + " ");
        }
#endregion
        public void BFSTest()
        {
            //int[,] AdjMatrix = GetRandomMatrix(5);
            int[,] AdjMatrix = new int[6, 6] {
                { 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 0 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0 } };
            MyGraph graph = new MyGraph(AdjMatrix);

            Console.WriteLine(graph.Count);
            Console.WriteLine("Матрица смежности");
            PrintMatrix(graph.GetAdjacencyMatrix);
            Console.WriteLine("Cписки смежности");
            PrintListList(graph.GetAdjacencyList);
            Console.WriteLine("Поиск в ширину");
            for (int i = 0; i < graph.Count; i++)
            {
                Console.WriteLine("Поиск для {0}-й вершины",i);
                graph.BreadthFirstSearch(i);
            }

        }
        public void BFSMatrixTest()
        {
            //int[,] AdjMatrix = GetRandomMatrix(5);
            int[,] AdjMatrix = new int[6, 6] {
                { 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 0 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0 } };
            MyGraph graph = new MyGraph(AdjMatrix);

            Console.WriteLine(graph.Count);
            Console.WriteLine("Матрица смежности");
            PrintMatrix(graph.GetAdjacencyMatrix);
            Console.WriteLine("Cписки смежности");
            PrintListList(graph.GetAdjacencyList);
            Console.WriteLine("Поиск в ширину");
            for (int i = 0; i < graph.Count; i++)
            {
                Console.WriteLine("Поиск для {0}-й вершины", i);
                graph.BreadthFirstSearchMatrix(i);
            }

        }

        public void DFSTest()
        {
            //int[,] AdjMatrix = GetRandomMatrix(5);
            int[,] AdjMatrix = new int[6, 6] {
                { 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 0 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0 } };
            MyGraph graph = new MyGraph(AdjMatrix);

            Console.WriteLine(graph.Count);
            Console.WriteLine("Матрица смежности");
            PrintMatrix(graph.GetAdjacencyMatrix);
            Console.WriteLine("Cписки смежности");
            PrintListList(graph.GetAdjacencyList);
            Console.WriteLine("Поиск в глубину");
            for (int i = 0; i < graph.Count; i++)
            {
                Console.WriteLine("Поиск для {0}-й вершины", i);
                graph.DepthFirstSearch(i);
            }
        }
        public void DFSMatrixTest()
        {
            //int[,] AdjMatrix = GetRandomMatrix(5);
            int[,] AdjMatrix = new int[6, 6] {
                { 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 0 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0 } };
            MyGraph graph = new MyGraph(AdjMatrix);

            Console.WriteLine(graph.Count);
            Console.WriteLine("Матрица смежности");
            PrintMatrix(graph.GetAdjacencyMatrix);
            Console.WriteLine("Cписки смежности");
            PrintListList(graph.GetAdjacencyList);
            Console.WriteLine("Поиск в глубину");
            for (int i = 0; i < graph.Count; i++)
            {
                Console.WriteLine("Поиск для {0}-й вершины", i);
                graph.DepthFirstSearchMatrix(i);
            }
        }

        public void GetPathsTest()
        {
            int[,] AdjMatrix = new int[6, 6] {
                { 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 1, 0 },
                { 1, 0, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0 },
                { 1, 0, 0, 0, 1, 0 } };
            MyGraph graph = new MyGraph(AdjMatrix);

            Console.WriteLine(graph.Count);
            Console.WriteLine("Матрица смежности");
            PrintMatrix(graph.GetAdjacencyMatrix);
            Console.WriteLine("Cписки смежности");
            PrintListList(graph.GetAdjacencyList);

            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph.Count; j++)
                {
                    Console.WriteLine("\nКоличество путей из вершины {0} в вершину {1}: " + graph.CountPaths(i,j), i, j);
                    Console.WriteLine("Пути из вершины {0} в вершину {1}: ", i, j);
                    graph.PrintAllPaths(i,j);
                }
            }
        }


        private void PrintListList(List<List<int>> list)
        {
            foreach (List<int> row in list)
            {
                foreach (int item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }

        private void PrintMatrix(int[,] matrix)
        {
            int length = matrix.GetUpperBound(0)+1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        private int[,] GetRandomMatrix(int rank)
        {
            Random random = new Random();
            int[,] matrix = new int[rank,rank];
            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    matrix[i, j] = random.Next(0,10);
                    if (i == j) matrix[i, j] = 0;
                }
            }
            return matrix;
        }
    }
}
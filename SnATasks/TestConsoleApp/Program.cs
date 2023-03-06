using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnALibrary;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests tests = new Tests();

            //tests.BFSTest();
            //tests.DFSTest();
            tests.GetPathsTest();

            Console.ReadKey();
        }

        private static int[] ReadFileArray()
        {
            string path = @"C:\Users\student\Desktop\СИА\SnATasks\TestConsoleApp\Resource\TextFile2.txt";
            string result = "";


            StreamReader source = new StreamReader(path);
            result = source.ReadToEnd();
            string[] splitRes = result.Split(',');
            int[] answer = new int[splitRes.Length];

            for (int i = 0; i < splitRes.Length; i++)
            {
                answer[i] = int.Parse(splitRes[i]);
            }

            return answer;
        }

        private static string ReadFile()
        {
            string path = @"D:/Учеба/Прога/СИА/SnATasks/TestConsoleApp/Resource/TextFile1.txt";
            string result = "";


            StreamReader source = new StreamReader(path);
            result = source.ReadToEnd();

            return result;
        }

        /// <summary>
        /// Печатае в консоль матрицу
        /// </summary>
        /// <param name="matrix">двумерный массив типа double</param>
        private static void PrintDoubleMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1)+1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Функция печати списка строк
        /// </summary>
        /// <param name="array">список строк</param>
        static void PrintStrArray(List<string> array)
        {
            Console.WriteLine("Перестановки длины " + Convert.ToString(array.Count));
            foreach (string element in array) Console.Write(element + " \n");
            Console.WriteLine();
        }
    }
}

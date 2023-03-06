using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SnALibrary
{
    public class Algorithms
    {
		/// <summary>
		/// Функция нахождения треугольника с наименьшим периметром
		/// </summary>
		/// <param name="dots">Двумерный массив чисел типа double - множество координат</param>
		/// <returns>двумерный массив - 3 точки, вершины искомого треугольника</returns>
        public static double[,] FindSmallestPerimeterTriangle(double[,] dots)
        {
			double[,] Triangle = new double[3,2];

			Vector vectorA = new Vector(dots[0, 0], dots[0, 1]);
			Vector vectorB = new Vector(dots[1, 0], dots[1, 1]);
			Vector vectorC = new Vector(dots[2, 0], dots[2, 1]);

			double MinPerimeter = Coordinates.Perimeter(vectorA,vectorB,vectorC);
			double CurPerimeter;

			//Перебираем всевозможные значения периметров у заданых точек
            for (int i = 0; i < dots.GetUpperBound(0)+1; i++)
            {
                for (int j = i+1; j < dots.GetUpperBound(0)+1; j++)
                {
                    for (int k = j+1; k < dots.GetUpperBound(0)+1; k++)
                    {
						vectorA = new Vector(dots[i, 0], dots[i, 1]);
						vectorB = new Vector(dots[j, 0], dots[j, 1]);
						vectorC = new Vector(dots[k, 0], dots[k, 1]);

						//При совпадении вершин, переходим к следующему периметру
						if (vectorA == vectorB || vectorB == vectorC || vectorA == vectorC) break;

						CurPerimeter = Coordinates.Perimeter(vectorA, vectorB, vectorC);

						//Находим минимальный периметр и записываем вершины этого треугольника в ответ
                        if (CurPerimeter <= MinPerimeter)
                        {
							MinPerimeter = CurPerimeter;
							Triangle[0, 0] = vectorA.X;
							Triangle[0, 1] = vectorA.Y;
							Triangle[1, 0] = vectorB.X;
							Triangle[1, 1] = vectorB.Y;
							Triangle[2, 0] = vectorC.X;
							Triangle[2, 1] = vectorC.Y;

						}
                    }
                }
            }


			return Triangle;
        }

        
    }

	public class Matrix
    {
		/// <summary>
		/// Функция получения симметричной матрицы с случайными числами
		/// </summary>
		/// <param name="order">Порядок матрицы</param>
		/// <param name="range">Диапазон значений [0Левая граница,1Правая граница]</param>
		/// <returns>Симметричную матрицу</returns>
		public static int[,] GetSimmMatrix(int order, int[] range)
		{
			Random random = new Random();
			int[,] Matrix = new int[order, order];

			for (int i = 0; i < order; i++)
				for (int j = 0; j < order; j++)
					if (i <= j)
						Matrix[i, j] = random.Next(range[0], range[1]);

			for (int i = 0; i < order; i++)
				for (int j = 0; j < order; j++)
					if (i > j)
						Matrix[i, j] = Matrix[j, i];

			return Matrix;
		}

		/// <summary>
		/// Функция получения разреженной матрицы с случайными числами
		/// </summary>
		/// <param name="order">Порядок матрицы</param>
		/// <param name="props">Параметры элементов матрицы 
		/// [0 фоновый элемент,1 Левая граница диапазона значений, 
		/// 2 Правая граница диапазона значений]</param>
		/// <returns></returns>
		public static int[,] GetSparseMatrix(int order, int[] props)
		{
			Random random = new Random();
			int[,] Matrix = new int[order, order];

			int k = 0;
			while (k < order * order / 4)
			{
				Matrix[random.Next(0, order), random.Next(0, order)] = random.Next(props[1], props[2]);
				k++;
			}


			return Matrix;
		}

		/// <summary>
		/// Функция упаковки симметричной матрицы
		/// </summary>
		/// <param name="symmetricalMatrix">симметричная матрица</param>
		/// <returns>вектор - упакованную симметричную матрицу</returns>
		public static int[] PackSymmetrical(int[,] symmetricalMatrix)
        {
			//Длина вектора - сумма арифметической прогрессии n*(n+1)/2
			int[] indexvector = new int[((symmetricalMatrix.GetUpperBound(0)+1)*(2+ symmetricalMatrix.GetUpperBound(0))/2)];
			int index = 0;
            for (int i = 0; i < symmetricalMatrix.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < symmetricalMatrix.GetUpperBound(0)+1; j++)
                {
                    if (i >= j)
                    {
						indexvector[index] = symmetricalMatrix[i, j];
						index++;
                    }
                }
            }
			return indexvector;

        }
		/// <summary>
		/// Функция распаковки упакованной симметричной матрицы
		/// </summary>
		/// <param name="PackedsymmetricalMatrix">упакованная симметричная матрица</param>
		/// <returns>Симметричную матрицу</returns>
		public static int[,] UnpackSymmetrical(int[] PackedsymmetricalMatrix)
        {
			//Порядок матрицы - положительный корень квадратного уравнения n^2 + n = -2*(длина вектора упакованной матрицы)
			int order = ((int)Math.Sqrt(1 + 4 * PackedsymmetricalMatrix.Length * 2) - 1) / 2;
			int[,] Unpacked = new int[order, order];

			int index = 0; int q = 0;
            for (int i = 0; i < PackedsymmetricalMatrix.Length; i++)
            {
				Unpacked[q, index] = PackedsymmetricalMatrix[i];
				q++;
                if (q > index)
                {
					q = 0;
					index++;
                }
            }

			for (int i = 0; i < order; i++)
				for (int j = 0; j < order; j++)
					if (i > j)
						Unpacked[i, j] = Unpacked[j, i];

			return Unpacked;
        }

		/// <summary>
		/// Функция упаковки разреженной матрицы
		/// </summary>
		/// <param name="sparseMatrix">Разреженная матрица</param>
		/// <returns>упакованную разреженную матрицу [[порядок],[строки],[столбцы],[элемент]]</returns>
        public static int[][] PackSparse(int[,] sparseMatrix)
        {
			int background = Matrix.GetBackgroundSparseMatrix(sparseMatrix);
			int NotZero = CountNotZeroElements(sparseMatrix,background);
			int order = sparseMatrix.GetUpperBound(0);

			int[] row = new int[NotZero];
			int[] column = new int[NotZero];
			int[] element = new int[NotZero];
			int index = 0;
            for (int i = 0; i < order+1; i++)
            {
                for (int j = 0; j < order + 1; j++)
                {
                    if (sparseMatrix[i, j] != background)
                    {
						row[index] = i;
						column[index] = j;
						element[index] = sparseMatrix[i, j];
						index++;
                    }
                }
            }

			return new int[][] { new int[]{order}, row, column, element};
        }

		/// <summary>
		/// функция подсчёта количества нефоновывх элементов разреженной матрицы
		/// </summary>
		/// <param name="sparseMatrix">разреженная матрица</param>
		/// <param name="background">фоновый элемент</param>
		/// <returns>количество нефоновых элементов разреженной матрицы</returns>
        private static int CountNotZeroElements(int[,] sparseMatrix,int background)
        {
			int counter = 0;
            for (int i = 0; i < sparseMatrix.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < sparseMatrix.GetUpperBound(0)+1; j++)
                {
					if (sparseMatrix[i, j] != background) counter++;
                }
            }
			return counter;
        }

		/// <summary>
		/// Функция распаковки упакованной разреженной матрицы
		/// </summary>
		/// <param name="PackedsparseMatrix">упакованная разреженная матрица</param>
		/// <returns>разреженная матрица</returns>
        public static int[,] UnpackSparse(int[][] PackedsparseMatrix)
        {
			int order = PackedsparseMatrix[0][0];
			int index = 0;
			int[,] unpacked = new int[order+1, order+1];

            for (int i = 0; i < order+1; i++)
            {
                for (int j = 0; j < order+1; j++)
                {
					if(index < PackedsparseMatrix[1].Length)
						if(i==PackedsparseMatrix[1][index] && j == PackedsparseMatrix[2][index])
						{
							unpacked[i,j] = PackedsparseMatrix[3][index];
							index++;
						}
                }
            }

			return unpacked;
		}

		/// <summary>
		/// Функция получения фонового элемента разреженной матрицы
		/// </summary>
		/// <param name="sparseMatrix">разреженная матрица</param>
		/// <returns>фоновый элемент</returns>
        public static int GetBackgroundSparseMatrix(int[,] sparseMatrix)
        {
			int[][] Series = ArrayHandler.GetSeries(sparseMatrix);
			return ArrayHandler.FindMax(Series[0],Series[1]);
		}

    }

	/// <summary>
	/// Класс работы с координатами и точками
	/// </summary>
    public class Coordinates
    {
		/// <summary>
		/// Функция формирования массива точек с дробными координатами
		/// </summary>
		/// <param name="CountDots">Количество точек</param>
		/// <param name="range">Диапазон чисел [0 левая граница, 1 правая граница]</param>
		/// <returns></returns>
		public static double[,] GetRandomDots(int CountDots, int[] range)
		{
			Random random = new Random();
			double[,] Dots = new double[CountDots, 2];

			for (int j = 0; j < CountDots; j++)
			{
				Dots[j, 0] = random.Next(range[0],range[1]) + Math.Truncate(random.NextDouble()*100)*0.01;
				Dots[j, 1] = random.Next(range[0], range[1]) + Math.Truncate(random.NextDouble() * 100) * 0.01;
			}
			return Dots;
		}

		/// <summary>
		/// Функция нахождения периметра треугольника по координатам трёх его вершин
		/// </summary>
		/// <param name="vectorA">Точка1</param>
		/// <param name="vectorB">Точка2</param>
		/// <param name="vectorC">Точка3</param>
		/// <returns>Периметр треугольника</returns>
		public static double Perimeter(Vector vectorA, Vector vectorB, Vector vectorC)
		{
			return Distance(vectorA, vectorB) +
				Distance(vectorB, vectorC) +
				Distance(vectorC, vectorA);
		}

		/// <summary>
		/// Функция расчёта расстояния между двумя точками
		/// </summary>
		/// <param name="vectorB">Точка1</param>
		/// <param name="vectorC">Точка2</param>
		/// <returns>Расстояние между двумя точками</returns>
		public static double Distance(Vector vectorB, Vector vectorC)
		{
			return Math.Sqrt(Math.Pow(vectorB.X - vectorC.X, 2) + Math.Pow(vectorB.Y - vectorC.Y, 2));
		}
	}
	/// <summary>
	/// Класс обработки массивов
	/// </summary>
	public class ArrayHandler 
	{
		/// <summary>
		/// Функция нахождения максимального значения элемента в двух связанных массивах
		/// </summary>
		/// <param name="Starts">"Названия"</param>
		/// <param name="Length">"Количества"</param>
		/// <returns>Название, значение количества которого максимально</returns>
		public static int FindMax(int[] Starts, int[] Length)
		{
			int[][] Summary = SummaryStartsLength(Starts,Length);

			int[] maxim = new int[] { Summary[0][0], Summary[1][0] };
			for (int i = 1; i < Starts.Length; i++)
			{
				if (Length[i] > maxim[1])
				{
					maxim[1] = Length[i];
					maxim[0] = Starts[i];
				}
			}
			return maxim[0];
		}

		/// <summary>
		/// Функция нахождения суммарной длины всех серий с одинаковым названием
		/// </summary>
		/// <param name="starts">названия</param>
		/// <param name="length">длины</param>
		/// <returns>массив [[Названия без повторений][Суммарные длины по этим названиям]]</returns>
        private static int[][] SummaryStartsLength(int[] starts, int[] length)
        {
			List<int> StartsNR = new List<int>();
			List<int> LengthNR = new List<int>();

			for (int i = 0; i < starts.Length; i++)
            {
				if (StartsNR.Contains(starts[i])) LengthNR[StartsNR.IndexOf(starts[i])] += length[i];
                else
                {
					StartsNR.Add(starts[i]);
					LengthNR.Add(length[i]);
				}
            }

			return new int[][] { StartsNR.ToArray(), LengthNR.ToArray() };

        }

        /// <summary>
        /// Функция получения информации о сериях элементов в матрице
        /// </summary>
        /// <param name="Matrix">матрица</param>
        /// <returns>массив информации о сериях [[Названия серий][количество элементов в них]]</returns>
        public static int[][] GetSeries(int[,] Matrix)
		{
			int SubSeqLen = CountSubSeqLen(Matrix);


			int[] Starts = new int[SubSeqLen];
			int[] Lengths = new int[SubSeqLen];

			int index = 0;
			int counter = 1;
			for (int i = 0; i < Matrix.GetUpperBound(0) + 1; i++)
			{
				for (int j = 1; j < Matrix.GetUpperBound(0) + 1; j++)
				{
					if (Matrix[i, j] != Matrix[i, j - 1])
					{
						Starts[index] = Matrix[i, j - 1];
						Lengths[index] = counter;
						counter = 0;
						index++;
					}
					counter++;
				}

			}

			return new int[][] { Starts, Lengths };
		}

		/// <summary>
		/// Функция подсчёта количества различных цепочек одинаковых чисел в матрице
		/// </summary>
		/// <param name="Matrix">матрица</param>
		/// <returns>количество различных цепочек одинаковых чисел</returns>
		public static int CountSubSeqLen(int[,] Matrix)
		{
			int SubSeqLen = 0;
			for (int i = 0; i < Matrix.GetUpperBound(0) + 1; i++)
			{
				for (int j = 0; j < Matrix.GetUpperBound(0) + 1; j++)
				{
					if (i == 0 && j == 0) continue;

					if (j == 0)
					{
						if (Matrix[i, j] != Matrix[i - 1, Matrix.GetUpperBound(0)]) SubSeqLen++;
					}
					else if (Matrix[i, j] != Matrix[i, j - 1]) SubSeqLen++;
				}

			}
			return SubSeqLen;
		}

		/// <summary>
		/// Функция слияния списка строк в одну строку
		/// </summary>
		/// <param name="list">Список строк</param>
		/// <returns>строка</returns>
		public static string Simplify(List<string> list)
        {
			string SimpleList = "";
            foreach(string element in list)
            {
				SimpleList+=element;
            }
			return SimpleList;
        }


        
		/// <summary>
		/// Обмен значениями двух элементов последовательности
		/// </summary>
		public static string Swap(string sequence, int index_0, int index_1)
		{
			char placeholder = '~';

			sequence = sequence.Replace(sequence[index_0], placeholder).
				Replace(sequence[index_1], sequence[index_0]).
				Replace(placeholder, sequence[index_1]);
			return sequence;
		}

		/// <summary>
		/// Функция копирования списка поэлементно
		/// </summary>
		/// <param name="sequence">Входящий список</param>
		/// <returns>Копия входящего списка</returns>
        internal static string CopyString(string sequence)
        {
			string newList = "";

			foreach (char element in sequence) newList+=element;

			return newList;
		}
		/// <summary>
		/// Функция удаления одинаковых строк из списка
		/// </summary>
		/// <param name="Permutations">список строк</param>
		/// <returns>список строк без повторений</returns>
		public static List<string> ClearSimilar(List<string> Permutations)
		{
			var tmp = Permutations.ToArray();
			tmp = tmp.Distinct().ToArray();
			Permutations = tmp.ToList();
			return Permutations;
		}

        
    }

	/// <summary>
	/// Класс реализующий различные перестановки и размещения
	/// </summary>
    public class Permutations
    {
		/// <summary>
		/// Функция получения размещений
		/// </summary>
		/// <param name="Symbols">Входящие символы</param>
		/// <param name="SeqLen">Длина размещения</param>
		/// <returns></returns>
		public static List<string> GetSeqPermutations(List<string> Symbols, int SeqLen)
		{
			List<string> SeqPermutations = GetPermutationsNlen(ArrayHandler.Simplify(Symbols)); //Получаем все перестановки
			SeqPermutations = GetShorterPermutation(SeqPermutations, SeqLen); //Получаем из них размещения
			SeqPermutations = ArrayHandler.ClearSimilar(SeqPermutations); //Очищаем размещения от повторений

			SeqPermutations.Sort();
			return SeqPermutations;
		}
		/// <summary>
		/// Получение размещений из списка перестановок
		/// </summary>
		/// <param name="Sequences">список всех перестановок</param>
		/// <param name="SeqLen">длина размещения</param>
		/// <returns>список размещений</returns>
		private static List<string> GetShorterPermutation(List<string> Sequences, int SeqLen)
		{
			//Чтобы получить размещение из перестановки достаточно "закрыть" немкольно символов в конце перестановки, не считая последнего
			//Так, например из перестановки 12345 можно получить размещение по 3 125

			List<string> NewSequencesShort = new List<string>();

			string tmpSequence = "";
			
			foreach (string Sequence in Sequences)
			{
				for (int i = 0; i < Sequence.Length; i++)
				{
					if (i < SeqLen - 1 || i > Sequence.Length - 2)	//"Закрываем" символы
						tmpSequence+=Sequence[i];
				}
				NewSequencesShort.Add(tmpSequence);
				tmpSequence = "";
			}

			return NewSequencesShort;

		}

		/// <summary>
		/// Функция получения всех перестановок в строке символов с помощью алгоритма Нарайаны
		/// </summary>
		/// <param name="Array">строка символов для перестановки</param>
		/// <returns>список всех перестановок</returns>
		public static List<string> GetPermutationsNlen(string Array)
		{
			List<string> PermutationsN = new List<string>();

			PermutationsN.Add(Array);

			int Pivot = FindPivotIndex(PermutationsN[PermutationsN.Count - 1]);
			while (Pivot != -1)
			{
				PermutationsN.Add(NextPermutation(PermutationsN[PermutationsN.Count - 1], Pivot));
				Pivot = FindPivotIndex(PermutationsN[PermutationsN.Count - 1]);

			}

			return PermutationsN;
		}

		/// <summary>
		/// функция поиска опорного элемента для алгоритмам Нарайаны
		/// </summary>
		/// <param name="Sequence">Последовательность символов</param>
		/// <returns>Индекс опорного элемента</returns>
        private static int FindPivotIndex(string Sequence)
		{
			int PivotIndex = Sequence.Length - 2;

			//Ищем с конца первый элемент больший предыдущего
			while (PivotIndex != -1 && Sequence[PivotIndex] >= Sequence[PivotIndex + 1])
				PivotIndex--;

			return PivotIndex;
		}

		/// <summary>
		/// функция получения новой перестановки с помощью алгоритма Нарайаны
		/// </summary>
		/// <param name="Sequence">Текущая перестановка</param>
		/// <param name="PivotIndex">Опорный элемент</param>
		/// <returns>Новую перестановку</returns>
		public static string NextPermutation(string Sequence, int PivotIndex)
		{
			//Копируем список
			string copied = ArrayHandler.CopyString(Sequence);

			do  // повторяем пока не будет найдено следующее размещение
			{
				int k = Sequence.Length - 1;

				//Ищем с конца первый элемент меньший или равный опорному и меняем их местами
				while (copied[PivotIndex]>= copied[k]) k--;
				copied = ArrayHandler.Swap(copied, PivotIndex, k);

				// сортируем оставшуюся часть последовательности
				int l = PivotIndex + 1, r = Sequence.Length - 1; 
				while (l < r)
					copied = ArrayHandler.Swap(copied, l++, r--);

			} while (PivotIndex > Sequence.Length - 1);
			return copied;
		}

		
	}
}

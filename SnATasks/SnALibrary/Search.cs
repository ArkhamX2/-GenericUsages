using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class Search
    {
        /// <summary>
        /// Функция поиска подстроки в строке. Наивный алгоритм
        /// </summary>
        /// <param name="source"> исходная строка </param>
        /// <param name="find"> искомая подстрока </param>
        /// <returns> Массив индексов всех вхождений подстроки в строку, или
        /// -1, если строка не найдена</returns>
        public List<int> NaiveSearch(string source, string find)
        {
            bool found_flag = false;    //флаг найденной подстроки
            List<int> answer = new List<int> { -1 };
            for (int i = 0; i < source.Length - find.Length + 1; i++) //перебор символов исходной строки
            {
                for (int j = 0; j < find.Length; j++) //сравнение с искомой подстрокой
                {
                    if (source[i + j] != find[j])   //при несовпадении возвращаемся в строку
                    {
                        found_flag = false;
                        break;
                    }
                    found_flag = true;
                }
                if (found_flag) //Если найдено совпадение - возвращаем индекс
                    answer.Add(i);
            }
            if (answer.Count > 1 && answer[0] == -1) answer.Remove(-1);
            return answer;
        }


        static int alphabetSize = 256;
        /// <summary>
        /// Функция поиск всех вхождений подстроки в строку. Алгоритм Рабина-Карпа
        /// </summary>
        /// <param name="find"> искомая строка </param>
        /// <param name="source"> исходная подстрока </param>
        /// <returns>Список всех вхождений подстроки в строку, или
        /// -1, если строка не найдена</returns>
        public List<int> RKSearch(string find, string source,int q)
        {
            List<int> result = new List<int>();

            int M = find.Length;
            int N = source.Length;
            int i, j;
            int findHash = 0; // hash value for pattern
            int sourceHash = 0; // hash value for txt
            int h = 1;

            //(alphabetSize^M-1)%q
            for (i = 0; i < M - 1; i++)
                h = (h * alphabetSize) % q;

            // Считаем начальные хэши для искомого текста и начального отрезка исходного
            for (i = 0; i < M; i++)
            {
                findHash = (alphabetSize * findHash + find[i]) % q;
                sourceHash = (alphabetSize * sourceHash + source[i]) % q;
            }

            //Проходим по оставшемуся тексту
            for (i = 0; i <= N - M; i++)
            {

                // Сравниваем хэши и ,если они равны, сравниваем отрезки текста посимвольно
                if (findHash == sourceHash)
                {
                    for (j = 0; j < M; j++)
                    {
                        if (source[i + j] != find[j])
                            break;
                    }

                    if (j == M)
                        result.Add(i);
                }

                // Считаем хэш следующего отрезка. Убираем начальный и добавляем следующий символ
                if (i < N - M)
                {
                    sourceHash = (alphabetSize * (sourceHash - source[i] * h) + source[i + M]) % q;

                    // Если хэш отрицательный, то переводим его в положительный
                    if (sourceHash < 0)
                        sourceHash += q;
                }
            }


            return result;

        }

        /// <summary>
        /// Функция поиска подстроки. Алгоритм Кнута-Морриса-Пратта
        /// </summary>
        /// <param name="source"> исходная строка </param>
        /// <param name="find"> искомая подстрока </param>
        /// <returns>Список всех вхождений подстроки в строку, или
        /// -1, если строка не найдена</returns>
        public List<int> KMPSearch(string source, string find)
        {
            int[] Prefix = GetPrefix(find); //получаем длины префиксов
            int index = 0;  //индекс найденного вхождения
            List<int> answer = new List<int> { -1 };

            for (int i = 0; i < source.Length; i++) //проходим по строке
            {
                //перебор префикса до совпадения его последнего символа с текущим символом строки
                while (index > 0 && find[index % find.Length] != source[i])
                {
                    index = Prefix[index - 1];
                }
                if (index > find.Length - 1) index--;
                if (find[index] == source[i])
                {
                    index++;  //проверяем на совпадение следующие символы в строке
                }

                if (index == find.Length)
                {
                    answer.Add(i - index + 1); //возвращаем номер символа в строке, если нашли совпадение
                }
            }
            if (answer.Count > 1 && answer[0] == -1) answer.Remove(-1);
            return answer;
        }

        /// <summary>
        /// Функция поиска длин префиксов строки
        /// </summary>
        /// <param name="pattern"> исходная строка </param>
        /// <returns> массив длин префиксов </returns>
        static int[] GetPrefix(string pattern)
        {
            int[] result = new int[pattern.Length]; //массив длин префиксов
            result[0] = 0;

            int index = 0;  //индекс конца префикса

            for (int i = 1; i < pattern.Length; i++)    //i - индекс конца суффикса
            {
                //Перебор префикса до совпадения его конца с концом суффикса
                while (index > 0 && pattern[index] != pattern[i]) { index = result[index - 1]; }
                //расширяем префикс и сохраняем его длину
                index++;
                result[i] = index;
            }

            return result;
        }

        /// <summary>
        /// Функция стемминга списка строк
        /// </summary>
        /// <param name="input"> исходный список строк </param>
        /// <returns> список строк без окончаний </returns>
        public List<string> Stemming(List<string> input)
        {
            return new List<string>() { "123" };
        }
    }
}

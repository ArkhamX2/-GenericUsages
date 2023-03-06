using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    /// <summary>
    /// Класс стемминга слов
    /// </summary>
    public class Stemming
    {
        /// <summary>
        /// Удвоенные буквы
        /// </summary>
        private readonly string[] doubles = { "bb", "dd", "ff", "gg", "mm", "nn", "pp", "rr", "tt" };
        /// <summary>
        /// Несокращаемые окончания
        /// </summary>
        private readonly string[] validLiEndings = { "c", "d", "e", "g", "h", "k", "m", "n", "r", "t" };

        /// <summary>
        /// Замены для шага 1b
        /// </summary>
        private readonly string[,] step1bReplacements =
            {
            {"eedly","ee"},
            {"ingly",""},
            {"edly",""},
            {"eed","ee"},
            {"ing",""},
            {"ed",""}
        };

        /// <summary>
        /// Замены для шага 2
        /// </summary>
        private readonly string[,] step2Replacements =
            {
            {"ization","ize"},
            {"iveness","ive"},
            {"fulness","ful"},
            {"ational","ate"},
            {"ousness","ous"},
            {"biliti","ble"},
            {"tional","tion"},
            {"lessli","less"},
            {"fulli","ful"},
            {"entli","ent"},
            {"ation","ate"},
            {"aliti","al"},
            {"iviti","ive"},
            {"ousli","ous"},
            {"alism","al"},
            {"abli","able"},
            {"anci","ance"},
            {"alli","al"},
            {"izer","ize"},
            {"enci","ence"},
            {"ator","ate"},
            {"bli","ble"},
            {"ogi","og"},
            {"li",""}
        };

        /// <summary>
        /// Замены для шага 3
        /// </summary>
        private readonly string[,] step3Replacements =
            {
            {"ational","ate"},
            {"tional","tion"},
            {"alize","al"},
            {"icate","ic"},
            {"iciti","ic"},
            {"ative",""},
            {"ical","ic"},
            {"ness",""},
            {"ful",""}
        };

        /// <summary>
        /// Замены для шага 4
        /// </summary>
        private readonly string[] step4Replacements =
                {"ement",
            "ment",
            "able",
            "ible",
            "ance",
            "ence",
            "ate",
            "iti",
            "ion",
            "ize",
            "ive",
            "ous",
            "ant",
            "ism",
            "ent",
            "al",
            "er",
            "ic"
        };

        /// <summary>
        /// слова-исключения
        /// </summary>
        private readonly string[,] exceptions =
            {
        {"skis","ski"},
        {"skies","sky"},
        {"dying","die"},
        {"lying","lie"},
        {"tying","tie"},
        {"idly","idl"},
        {"gently","gentl"},
        {"ugly","ugli"},
        {"early","earli"},
        {"only","onli"},
        {"singly","singl"},
        {"sky","sky"},
        {"news","news"},
        {"howe","howe"},
        {"atlas","atlas"},
        {"cosmos","cosmos"},
        {"bias","bias"},
        {"andes","andes"}
        };

        /// <summary>
        /// слова-исключения
        /// </summary>
        private readonly string[] exceptions2 =
            {"inning","outing","canning","herring","earring","proceed",
            "exceed","succeed"};

        /// <summary>
        /// Проверка содержится ли символ в массиве строк
        /// </summary>
        /// <param name="arr">массив строк</param>
        /// <param name="s">искомый символ</param>
        /// <returns>true, если символ содержится в массиве</returns>
        private bool ArrayContains(string[] arr, string s)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == s) return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка является ли буква гласной
        /// </summary>
        /// <param name="sWord">проверяемое слово</param>
        /// <param name="offset">индекс буквы</param>
        /// <returns>true, если указанная буква - гласная</returns>
        private bool IsVowel(StringBuilder sWord, int offset)
        {
            switch (sWord[offset])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Проверка слогов
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="offset">оступ от конца слова</param>
        /// <returns>true, если слог можно сократить</returns>
        private bool IsShortSyllable(StringBuilder sWord, int offset)
        {
            if ((offset == 0) && (IsVowel(sWord, 0)) && (!IsVowel(sWord, 1)))
                return true;
            else
                if (
                    ((offset > 0) && (offset < sWord.Length - 1)) &&
                    IsVowel(sWord, offset) && !IsVowel(sWord, offset + 1) &&
                    (sWord[offset + 1] != 'w' && sWord[offset + 1] != 'x' && sWord[offset + 1] != 'Y')
                    && !IsVowel(sWord, offset - 1))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверка является ли слово сокращаемым
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r1">индекс области r1</param>
        /// <returns>true, если слово сокращается</returns>
        private bool IsShortWord(StringBuilder sWord, int r1)
        {
            if ((r1 >= sWord.Length) && (IsShortSyllable(sWord, sWord.Length - 2))) return true;

            return false;
        }

        /// <summary>
        /// Замена y в начале слова на Y
        /// замена y после гласной на Y
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        private void ChangeY(StringBuilder sWord)
        {
            if (sWord[0] == 'y') sWord[0] = 'Y';

            for (int i = 1; i < sWord.Length; ++i)
            {
                if ((sWord[i] == 'y') && (IsVowel(sWord, i - 1))) sWord[i] = 'Y';
            }
        }

        /// <summary>
        /// Расчёт r1 и r2 - специальных областей слова
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r1">Область слова после первого сочетания "гласная согласная"</param>
        /// <param name="r2">Область r1 после первого сочетания "гласная согласная"</param>
        private void ComputeR1R2(StringBuilder sWord, ref int r1, ref int r2)
        {
            r1 = sWord.Length;  //Область слова после первого сочетания "гласная согласная"
            r2 = sWord.Length;  //Область r1 после первого сочетания "гласная согласная"

            for (int i = 1; i < sWord.Length; ++i)
            {
                if ((!IsVowel(sWord, i)) && (IsVowel(sWord, i - 1)))
                {
                    r1 = i + 1;
                    break;
                }
            }

            for (int i = r1 + 1; i < sWord.Length; ++i)
            {
                if ((!IsVowel(sWord, i)) && (IsVowel(sWord, i - 1)))
                {
                    r2 = i + 1;
                    break;
                }
            }
        }

        /// <summary>
        /// Удаляем все окончания принадлежности  student`s -> student students`
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        private void Step0(StringBuilder sWord)
        {

            if ((sWord.Length >= 2) && (sWord.ToString(sWord.Length - 2, 2) == "s'"))
                sWord.Remove(sWord.Length - 3, 3);
            else
            if ((sWord.Length >= 2) && (sWord.ToString(sWord.Length - 2, 2) == "'s"))
                sWord.Remove(sWord.Length - 2, 2);
            else
                if (sWord[sWord.Length - 1] == '\'')
                sWord.Remove(sWord.Length - 1, 1);
        }

        /// <summary>
        /// Удаляем окончания множественных чисел существительных
        /// caresses-> caress  cats->cat
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        private void Step1a(StringBuilder sWord)
        {

            if ((sWord.Length >= 4) && sWord.ToString(sWord.Length - 4, 4) == "sses")
                sWord.Replace("sses", "ss", sWord.Length - 4, 4);
            else
                if ((sWord.Length >= 3) && (sWord.ToString(sWord.Length - 3, 3) == "ied" || sWord.ToString(sWord.Length - 3, 3) == "ies"))
            {
                if (sWord.Length > 4)
                    sWord.Replace(sWord.ToString(sWord.Length - 3, 3), "i", sWord.Length - 3, 3);
                else
                    sWord.Replace(sWord.ToString(sWord.Length - 3, 3), "ie", sWord.Length - 3, 3);
            }
            else
                    if ((sWord.Length >= 2) && (sWord.ToString(sWord.Length - 2, 2) == "us" || sWord.ToString(sWord.Length - 2, 2) == "ss"))
                return;
            else
                        if ((sWord.Length > 0) && (sWord.ToString(sWord.Length - 1, 1) == "s"))
            {
                for (int i = 0; i < sWord.Length - 2; ++i)
                    if (IsVowel(sWord, i))
                    {
                        sWord.Remove(sWord.Length - 1, 1);
                        break;
                    }
            }

        }

        /// <summary>
        /// Удаляем окончания глаголов
        /// feed -> feed
        /// plastered -> plaster
        /// motoring->motor
        /// sized->size
        /// filing->file
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r1">индекс области r1</param>
        private void Step1b(StringBuilder sWord, int r1)
        {
            for (int i = 0; i < 6; ++i)
            {
                if ((sWord.Length > step1bReplacements[i, 0].Length) && 
                    (sWord.ToString(sWord.Length - step1bReplacements[i, 0].Length, step1bReplacements[i, 0].Length) == step1bReplacements[i, 0]))
                {
                    switch (step1bReplacements[i, 0])
                    {
                        case "eedly":
                        case "eed":
                            if (sWord.Length - step1bReplacements[i, 0].Length >= r1)
                                sWord.Replace(step1bReplacements[i, 0], step1bReplacements[i, 1], sWord.Length - step1bReplacements[i, 0].Length, step1bReplacements[i, 0].Length);
                            break;
                        default:
                            bool found = false;
                            for (int j = 0; j < sWord.Length - step1bReplacements[i, 0].Length; ++j)
                            {
                                if (IsVowel(sWord, j))
                                {
                                    sWord.Replace(step1bReplacements[i, 0], step1bReplacements[i, 1], sWord.Length - step1bReplacements[i, 0].Length, step1bReplacements[i, 0].Length);
                                    found = true;
                                    break;
                                }
                            }
                            if (!found) return;
                            if (sWord.Length >= 2)
                            {
                                switch (sWord.ToString(sWord.Length - 2, 2))
                                {
                                    case "at":
                                    case "bl":
                                    case "iz":
                                        sWord.Append("e");
                                        return;
                                }
                                if (ArrayContains(doubles, sWord.ToString(sWord.Length - 2, 2)))
                                {
                                    sWord.Remove(sWord.Length - 1, 1);
                                    return;
                                }
                            }
                            if (IsShortWord(sWord, r1))
                                sWord.Append("e");
                            break;
                    }
                    return;
                }
            }
        }

        /// <summary>
        /// happy->happi
        /// sky->sky
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        private void Step1c(StringBuilder sWord)
        {
            if ((sWord.Length > 0) &&
                (sWord[sWord.Length - 1] == 'y' || sWord[sWord.Length - 1] == 'Y') &&
                (sWord.Length > 2) && (!IsVowel(sWord, sWord.Length - 2))
               )
                sWord[sWord.Length - 1] = 'i';
        }

        /// <summary>
        /// Исправление окончаний существительных и прилагательных
        /// conditional -> condition
        /// predication -> predicate
        /// hopefulness -> hopeful
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r1">индекс области r1</param>
        private void Step2(StringBuilder sWord, int r1)
        {
            for (int i = 0; i < 24; ++i)
            {
                if (
                    (sWord.Length >= step2Replacements[i, 0].Length) &&
                    (sWord.ToString(sWord.Length - step2Replacements[i, 0].Length, step2Replacements[i, 0].Length) == step2Replacements[i, 0])
                    )
                {
                    if (sWord.Length - step2Replacements[i, 0].Length >= r1)
                    {
                        switch (step2Replacements[i, 0])
                        {
                            case "ogi":
                                if ((sWord.Length > 3) &&
                                    (sWord[sWord.Length - step2Replacements[i, 0].Length - 1] == 'l')
                                    )
                                    sWord.Replace(step2Replacements[i, 0], 
                                        step2Replacements[i, 1], 
                                        sWord.Length - step2Replacements[i, 0].Length, 
                                        step2Replacements[i, 0].Length);
                                return;
                            case "li":
                                if ((sWord.Length > 1) &&
                                    (ArrayContains(validLiEndings, sWord.ToString(sWord.Length - 3, 1)))
                                    )
                                    sWord.Remove(sWord.Length - 2, 2);
                                return;
                            default:
                                sWord.Replace(step2Replacements[i, 0], 
                                    step2Replacements[i, 1], 
                                    sWord.Length - step2Replacements[i, 0].Length,
                                    step2Replacements[i, 0].Length);
                                return;
                                break;

                        }
                    }
                    else
                        return;
                }
            }
        }

        /// <summary>
        /// Исправление прилагательных и существительных
        /// hopeful->hope
        /// goodness->good
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r1">индекс области r1</param>
        /// <param name="r2">индекс области r2</param>
        private void Step3(StringBuilder sWord, int r1, int r2)
        {
            for (int i = 0; i < 9; ++i)
            {
                if (
                    (sWord.Length >= step3Replacements[i, 0].Length) &&
                    (sWord.ToString(sWord.Length - step3Replacements[i, 0].Length, step3Replacements[i, 0].Length) == step3Replacements[i, 0])
                    )
                {
                    if (sWord.Length - step3Replacements[i, 0].Length >= r1)
                    {
                        switch (step3Replacements[i, 0])
                        {
                            case "ative":
                                if (sWord.Length - step3Replacements[i, 0].Length >= r2)
                                    sWord.Replace(step3Replacements[i, 0], step3Replacements[i, 1], 
                                        sWord.Length - step3Replacements[i, 0].Length, step3Replacements[i, 0].Length);
                                return;
                            default:
                                sWord.Replace(step3Replacements[i, 0], step3Replacements[i, 1], 
                                    sWord.Length - step3Replacements[i, 0].Length, step3Replacements[i, 0].Length);
                                return;
                        }
                    }
                    else return;
                }
            }
        }

        /// <summary>
        /// Исправление окончаний существительных и глаголов
        /// revival -> reviv
        /// activate->activ
        /// effective->effect
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r2">индекс области r2</param>
        private void Step4(StringBuilder sWord, int r2)
        {
            for (int i = 0; i < 18; ++i)
            {
                if (
                    (sWord.Length >= step4Replacements[i].Length) &&
                    (sWord.ToString(sWord.Length - step4Replacements[i].Length, step4Replacements[i].Length) == step4Replacements[i]) 
                    )
                {
                    if (sWord.Length - step4Replacements[i].Length >= r2)
                    {
                        switch (step4Replacements[i])
                        {
                            case "ion":
                                if (
                                    (sWord.Length > 3) &&
                                    (
                                        (sWord[sWord.Length - step4Replacements[i].Length - 1] == 's') ||
                                        (sWord[sWord.Length - step4Replacements[i].Length - 1] == 't')
                                    )
                                   )
                                    sWord.Remove(sWord.Length - step4Replacements[i].Length, step4Replacements[i].Length);
                                return;
                            default:
                                sWord.Remove(sWord.Length - step4Replacements[i].Length, step4Replacements[i].Length);
                                return;
                        }
                    }
                    else
                        return;
                }
            }

        }

        /// <summary>
        /// Удаляем ненужные E и ll в конце слова
        /// </summary>
        /// <param name="sWord">слово для стемминга</param>
        /// <param name="r1">индекс области r1</param>
        /// <param name="r2">индекс области r2</param>
        private void Step5(StringBuilder sWord, int r1, int r2)
        {
            if (sWord.Length > 0)
                if (
                    (sWord[sWord.Length - 1] == 'e') &&
                    (
                        (sWord.Length - 1 >= r2) ||
                        ((sWord.Length - 1 >= r1) && (!IsShortSyllable(sWord, sWord.Length - 3)))
                    )
                   )
                    sWord.Remove(sWord.Length - 1, 1);
                else
                    if (
                        (sWord[sWord.Length - 1] == 'l') &&
                            (sWord.Length - 1 >= r2) &&
                            (sWord[sWord.Length - 2] == 'l')
                        )
                    sWord.Remove(sWord.Length - 1, 1);
        }

        /// <summary>
        /// Стемминг слова
        /// </summary>
        /// <param name="inputWord">слово для стемминга</param>
        /// <returns>слово без окончаний и суффиксов</returns>
        public string Stem(string inputWord)
        {
            if (inputWord.Length < 3) return inputWord;

            StringBuilder sWord = new StringBuilder(inputWord.ToLower());

            if (sWord[0] == '\'') sWord.Remove(0, 1);

            for (int i = 0; i < exceptions.Length/2; ++i)
                if (inputWord == exceptions[i, 0])
                    return exceptions[i, 1];

            int r1 = 0, r2 = 0;
            ChangeY(sWord);
            ComputeR1R2(sWord, ref r1, ref r2);

            Step0(sWord);
            Step1a(sWord);

            //Проверяем не является ли sWord исключением
            for (int i = 0; i < exceptions2.Length; ++i)
                if (sWord.ToString() == exceptions2[i])
                    return exceptions2[i];

            Step1b(sWord, r1);
            Step1c(sWord);
            Step2(sWord, r1);
            Step3(sWord, r1, r2);
            Step4(sWord, r2);
            Step5(sWord, r1, r2);


            return sWord.ToString().ToLower();
        }
    }
}
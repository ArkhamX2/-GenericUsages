using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class LogicalEvaluator
    {
        //-(-x*y+z)+(х*-z)

        // A B + C * 
        // true false + true *

        MyStack<string> operations = new MyStack<string>();
        /// <summary>
        /// Метод вычисления логического выражения
        /// </summary>
        /// <param name="tokens">Логическое выражение, где A,B,C... заменены на их значения True/False </param>
        /// <returns>Значение логического выражения</returns>
        public bool EvaluateEquation(List<string> tokensInp, bool[] values)
        {

            List<string> tokens = SetValues(tokensInp,values);
            //Заносим каждый токен в стек и выполняем соответствующую логическую операцию
            for (int i = 0; i < tokens.Count; i++)
            {
                operations.Push(tokens[i]);
                string curToken = operations.Peek();
                //"Вытаскиваем" последнюю операцию из стека
                // Если это переменная ("True" или "False"), ничего не происходит
                // Операции, требующие 2 операнда "вытаскивают" последние два операнда и проводят операцию с ними, занося в стек результат
                // Операция отрицания "вытаскивает" последний операнд и выполняет отрицание, занося в стек результат
                bool op1 = true;
                bool op2 = true;
                bool res = true;

                switch (curToken)
                {
                    case "-":   //Отрицание
                        operations.Pop();

                        op1 = operations.Pop() == "True";

                        res = op1 == false;

                        operations.Push(res.ToString());

                        break;

                    case "+":   //Дизъюнкция
                        operations.Pop();

                        op1 = operations.Pop() == "True";
                        op2 = operations.Pop() == "True";
                        res = op1 || op2;

                        operations.Push(res.ToString());
                        break;

                    case "*":   //Конъюнкция
                        operations.Pop();

                        op1 = operations.Pop() == "True";
                        op2 = operations.Pop() == "True";

                        operations.Push((op1 && op2).ToString());
                        break;

                    case "->":  //Импликация
                        operations.Pop();
                        bool evalB = operations.Pop() == "True";
                        bool evalA = operations.Pop() == "True";

                        Sensor sensorImplicate = Sensor.Custom(new bool[] { evalA, evalB });
                        operations.Push(sensorImplicate.Implicate().ToString());
                        break;

                    case "<->": //Эквиваленция
                    case "EQV":
                        operations.Pop();
                        Sensor sensorEqualite = Sensor.Custom(new bool[] { operations.Pop() == "True", operations.Pop() == "True" });
                        operations.Push(sensorEqualite.Equalite().ToString());
                        break;

                    case "XOR": //XOR
                        operations.Pop();
                        Sensor sensorXOR = Sensor.Custom(new bool[] { operations.Pop() == "True", operations.Pop() == "True" });
                        operations.Push(sensorXOR.Xor().ToString());
                        break;

                    default:
                        break;
                }
            }
            return operations.Pop() == "True";
        }
        // X + Y -> true + false
        /// <summary>
        /// Метод присвоения логическим переменным A,B,C... заданных значений
        /// </summary>
        /// <param name="tokens">Логическое выражение в постфиксной записи</param>
        /// <param name="values">логические значения букв-переменных [A,B,C,D...]</param>
        /// <returns>Список токенов, где буквенные переменные заменены на их значения</returns>
        public List<string> SetValues(List<string> tokens, bool[] values)
        {
            List<string> answer = new List<string>();
            for (int i = 0; i < tokens.Count; i++)
            {
                //Не операциям присвваиваем значение из кортежа по индексу
                if (tokens[i] != "-" &&
                    tokens[i] != "+" &&
                    tokens[i] != "*" &&
                    tokens[i] != "->" &&
                    tokens[i] != "<->" &&
                    tokens[i] != "EQV")
                {
                    //Получаем текущую букву из строки: переводим строку в массив символов,
                    //но буква - единственный символ,
                    //Поэтому берём нулевой элемент
                    char curLetter = tokens[i].ToCharArray()[0]; 

                    //Каждому символу соответствует код: для А - 65, для B - 66 и т.д.,
                    //поэтому нужно отнять 65, чтобы получить индекс в массиве значений для буквы.
                    //curLetter - 65 - индекс соответствующего букве значения в массиве values.
                    //Для A - 0, для B - 1 и т.д.
                    answer.Add(values[curLetter - 65].ToString());
                }
                else answer.Add(tokens[i]);
            }
            return answer;
        }
    }
}

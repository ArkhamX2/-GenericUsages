using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public class ArithmeticEvaluator
    {
        MyStack<string> operations = new MyStack<string>();

        /// <summary>
        /// Метод вычисления арифметического выражения
        /// </summary>
        /// <param name="tokens">Арифметическое выражение</param>
        /// <returns>Значение арифметического выражения</returns>
        public double EvaluateEquation(List<string> tokensInp)
        {
            //Заносим каждый токен в стек и выполняем соответствующую логическую операцию операцию
            for (int i = 0; i < tokensInp.Count; i++)
            {
                operations.Push(tokensInp[i]);
                string curToken = operations.Peek();
                //"Вытаскиваем" последнюю операцию из стека
                // Если это переменная ("True" или "False"), ничего не происходит
                // Операции, требующие 2 операнда "вытаскивают" последние два операнда и проводят операцию с ними, занося в стек результат
                // Операция отрицания "вытаскивает" последний операнд и выполняет отрицание, занося в стек результат

                switch (curToken)
                {
                    case "-":   //Вычитание
                        operations.Pop();
                        operations.Push( (-double.Parse(operations.Pop()) + double.Parse(operations.Pop())).ToString() );
                        break;

                    case "+":   //Сложение
                        operations.Pop();
                        operations.Push((double.Parse(operations.Pop()) + double.Parse(operations.Pop())).ToString());
                        break;

                    case "*":   //Умножение
                        operations.Pop();
                        operations.Push((double.Parse(operations.Pop()) * double.Parse(operations.Pop())).ToString());
                        break;

                    case "/":  //Деление
                        operations.Pop();
                        operations.Push((( 1/double.Parse(operations.Pop()) ) * double.Parse(operations.Pop())).ToString());
                        break;
                        
                    default:
                        break;
                }
            }
            return double.Parse(operations.Pop());
        }
    }
}

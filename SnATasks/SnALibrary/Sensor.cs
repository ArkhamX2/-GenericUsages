using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{
    public struct Sensor
    {
        /// <summary>
        /// Список булевых значений
        /// </summary>
        private readonly bool[] _list;

        /// <summary>
        /// Конструктор кортежа
        /// </summary>
        /// <param name="count">Количество булевых переменных</param>
        public Sensor(int count)
        {
            _list = new bool[count];
        }

        /// <summary>
        /// Настраиваемый конструктор кортежа
        /// </summary>
        /// <param name="list">Список булевых значений</param>
        /// <returns>Объект кортежа</returns>
        public static Sensor Custom(bool[] list)
        {
            int count = list.Count();
            Sensor sensor = new Sensor(count);

            for (int i = 0; i < count; i++)
            {
                sensor.List[i] = list[i];
            }

            return sensor;
        }

        /// <summary>
        /// Доступ к списку булевых значений
        /// </summary>
        public bool[] List => _list;

        /// <summary>
        /// Получить новый кортеж с противоположными значениями
        /// </summary>
        /// <returns>Новый кортеж с противоположными значениями</returns>
        public Sensor Negate()
        {
            int count = List.Count();
            bool[] result = new bool[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = !List[i];
            }

            return Custom(result);
        }

        /// <summary>
        /// Применить операцию импликации
        /// </summary>
        /// <returns>Статус операции</returns>
        public bool Implicate()
        {
            bool result = List[0];

            foreach (bool item in List.Skip(1))
            {
                result = !result | item;
            }

            return result;
        }

        /// <summary>
        /// Применить операцию эквализации
        /// TODO: эквализация?
        /// </summary>
        /// <returns>Статус операции</returns>
        public bool Equalite()
        {
            bool result = List[0];

            foreach (bool item in List.Skip(1))
            {
                if (result != item)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Применить операцию конъюнкции
        /// </summary>
        /// <returns>Статус операции</returns>
        public bool And()
        {
            bool result = List[0];

            foreach (bool item in List.Skip(1))
            {
                result &= item;
            }

            return result;
        }

        /// <summary>
        /// Применить операцию дизъюнкции
        /// </summary>
        /// <returns>Статус операции</returns>
        public bool Or()
        {
            bool result = List[0];

            foreach (bool item in List.Skip(1))
            {
                result |= item;
            }

            return result;
        }

        /// <summary>
        /// Применить операцию исключающей дизъюнкции
        /// </summary>
        /// <returns>Статус операции</returns>
        public bool Xor()
        {
            bool result = List[0];

            foreach (bool item in List.Skip(1))
            {
                result = (result & !item) | (!result & item);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Join(" ", List.Select(x => x == true ? 1 : 0));
        }
    }
}

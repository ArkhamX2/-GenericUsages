using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnALibrary;

namespace SnATasks
{
    public partial class FormNarayana : Form
    {
        public FormNarayana()
        {
            InitializeComponent();
            //Привязка кнопки Enter к копке "Вычислить"
            this.AcceptButton = buttonGeneratePermutations;
        }

        private void buttonGeneratePermutations_Click(object sender, EventArgs e)
        {
            List<string> Symbols = tbInputSymbols.Text.TrimEnd(' ').Split(' ').ToList();
            int SeqLen = 0;

            try
            {
                SeqLen = int.Parse(tbInputCount.Text);
                if (SeqLen > Symbols.Count) throw new Exception();
                if (SeqLen < 2) throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод","Ошибка");
                return;
            }

            if (Symbols.Count > 11)
            {
                MessageBox.Show("Слишком много символов. Максимальное количество - 11", "Ошибка");
                return;
            }
            
            foreach(string sym in Symbols)
                if (sym.Length > 1)
                {
                    MessageBox.Show("Введен не набор одиночных символов.", "Ошибка");
                    return;
                }

            textBoxAnswer.Text = MakeAnswer(Permutations.GetSeqPermutations(Symbols, SeqLen));

        }

        /// <summary>
        /// Функция формирования строки, содержащей все размещения и информацию о них
        /// </summary>
        /// <param name="list">список всех размещений</param>
        /// <returns>список размещений, в котором не имеет значения порядок</returns>
        private string MakeAnswer(List<string> list)
        {
            string answer = "";

            //Исключаем ситуацию печати 123 и 321 в одном списке
            var hashset = new HashSet<string>();
            foreach (var sequence in list)
            {
                if (!hashset.Contains(Reverse(sequence)))
                    hashset.Add(Reverse(sequence));
                if (!hashset.Contains(sequence))
                    answer += sequence + Environment.NewLine;
            }

            answer = "Количество перестановок " + (answer.Length/(list[0].Length+2)).ToString() + Environment.NewLine +
                "Все перестановки длины " + (list[0].Length/2 + 1).ToString() + Environment.NewLine + answer;

            return answer;
        }

        /// <summary>
        /// Функция переворота строки
        /// </summary>
        /// <param name="sequence">строка</param>
        /// <returns>перевёрнутая строка</returns>
        private string Reverse(string sequence)
        {
            string tmp = "";
            for (int i = sequence.Length-1; i >=0 ; i--)
            {
                tmp += sequence[i];
            }
            return tmp;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Условие задачи:\n" +
                "Дан набор из n символов. Составить все возможные перестановки этих символов без повторений.\n" +
                "В поле для символов необходимо ввести символы через пробел." +
                "В поле для ввода длины перестановок необходимо ввести натуральное число больше 2.");
        }
    }
}

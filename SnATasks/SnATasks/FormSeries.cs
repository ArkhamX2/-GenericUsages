using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnATasks
{
    public partial class FormSeries : Form
    {
        public FormSeries()
        {
            InitializeComponent();
            this.AcceptButton = buttonCalculate;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string[] Sequence = (tbInput.Text.TrimEnd(' ') + " \0").Split(' ');

            //Количество серий
            int SubSeqLen = 0;
            for (int i = 1; i < Sequence.Length; i++)
            {
                if (Sequence[i] != Sequence[i - 1]) SubSeqLen++;
            }

            string[] Starts = new string[SubSeqLen];
            int[] Lengths = new int[SubSeqLen];

            int index = 0;
            int counter = 1;
            for (int i = 1; i < Sequence.Length; i++)
            {
                if (Sequence[i] != Sequence[i - 1])
                {
                    Starts[index] = Sequence[i-1];
                    Lengths[index] = counter;
                    counter = 0;
                    index++;
                }

                counter++;
            }
            tbContent.Text = MakeAnswer(Starts, Lengths);
        }

        private string MakeAnswer(string[] starts, int[] lengths)
        {
            string answer = "Количество серий: " + starts.Length.ToString() + Environment.NewLine +
                "Имена серий: " + Environment.NewLine;
            foreach (string start in starts)
                answer += start + " ";
            answer += Environment.NewLine + "Длины серий: " + Environment.NewLine;
            foreach (int len in lengths)
                answer += len.ToString() + " ";

            return answer;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Условие задачи:\n" +
                "Дана последовательность символов. Необходимо вывести информацию о каждом символе, образующем серию и её длину.\n" +
                "Серия - идущие подряд одинаковые символы.\n" +
                "В поле ввода помледовательности необходимо ввести символы через пробел");
        }
    }
}

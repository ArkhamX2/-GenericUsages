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
    public partial class FormBoxes : Form
    {
        public FormBoxes()
        {
            InitializeComponent();
            //Привязка кнопки Enter к копке "Вычислить"
            this.AcceptButton = buttonCalculate;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string[] tmp = tbInput.Text.TrimEnd(' ').Split(' ');
            double[] Sizes = new double[tmp.Length];
            try
            {
                for (int i = 0; i < tmp.Length; i++)
                    Sizes[i] = double.Parse(tmp[i]);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод", "Ошибка");
                return;
            }

            // "Разворачиваем" оба прямоугольника большей стороной горизонтально
            if (Sizes[0] > Sizes[1])
            {
                double swap = Sizes[0];
                Sizes[0] = Sizes[1];
                Sizes[1] = swap;
            }
            if (Sizes[2] > Sizes[3])
            {
                double swap = Sizes[2];
                Sizes[2] = Sizes[3];
                Sizes[3] = swap;
            }

            string answer = "";
            //Если помещается по высоте и помещается по длине в горизонтальном положении
            if (Sizes[0] > Sizes[2] && Sizes[1] > Sizes[3])
            {
                if (Sizes[0] > Sizes[3]) answer = "Можно разместить и параллельно, и перпендикулярно";
                else answer = "Можно разместить только горизонтально";
            }
            else answer = "Разместить невозможно";

            textBoxContent.Text = answer;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Условие задачи:\n" +
                "Дано размеры двух прямоугольников. Необходимо определить, можно ли поместить один в другой, " +
                "а также указать их расположение относительно друг друга: параллельно или перпендикулярно.\n" +
                "В поле для размеров прямоугольников необходимо ввести 4 числа через пробел. Первая пара - размеры первого прямоугольника" +
                "Вторая пара - размеры второго прямоугольника.");
        }
    }
}

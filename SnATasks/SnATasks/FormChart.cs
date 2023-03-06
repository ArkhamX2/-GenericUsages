using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SnATasks
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
            //Привязка кнопки Enter к копке "Вычислить"
            this.AcceptButton = Generate;
        }

        Random random = new Random();
        private void Generate_Click(object sender, EventArgs e)
        {
            int CountDots = 0;

            //Проверка ввода
            if (textBoxInput != null)
            {
                try
                {
                    CountDots = int.Parse(textBoxInput.Text);
                    if (CountDots < 1) throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный ввод количества точек");
                    return;
                }
            }

            //Инициализация массивов точек
            double[] X = new double[CountDots];
            double[] Y = new double[CountDots];

            //Очистка листа
            this.chartSplineMaker.Series.Clear();

            //Создание нового сплайна
            this.chartSplineMaker.Series.Add("New line");
            this.chartSplineMaker.Series["New line"].ChartType = SeriesChartType.Line;

            //Заполнение массивов случайными точками
            for (int i = 0; i < CountDots; i++)
            {
                X[i] = random.Next(0, CountDots);
                Y[i] = random.Next(0, CountDots);

                //Построение новой точки на графике
                this.chartSplineMaker.Series["New line"].Points.AddXY(X[i], Y[i]);

            }
            //Заполнение таблицы значений точек
            dataGridViewSpline.RowCount = CountDots + 1;
            for (int i = 0; i < CountDots; i++)
            {
                dataGridViewSpline.Rows[i].Cells[0].Value = X[i];
                dataGridViewSpline.Rows[i].Cells[1].Value = Y[i];
            }
                        


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Условие задачи:\n" +
                "Изобразить на элементе управления Chart произвольную кривую\n" +
                "В поле для количества точек необходимо ввести натуральное число");
        }
    }
}

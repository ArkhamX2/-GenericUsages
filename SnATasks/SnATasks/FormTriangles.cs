using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SnALibrary;

namespace SnATasks
{
    public partial class FormTriangles : Form
    {
        public FormTriangles()
        {
            InitializeComponent();
            this.AcceptButton = buttonCalculate;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int CountDots = 0;

            try
            {
                CountDots = int.Parse(textBoxCountDots.Text);
                if (CountDots < 3) throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод", "Ошибка");
                return;
            }

            double[,] Dots = Coordinates.GetRandomDots(CountDots,new int[]{-1000,1000});

            CreateChartnLegend(Dots,CountDots);

            double[,] Triangle = Algorithms.FindSmallestPerimeterTriangle(Dots);
            tbContent.Text = MakeAnswer(Triangle);
            BuildTriangleOnChart(Triangle);
        }

        /// <summary>
        /// Функция построения треугольника в Chart
        /// </summary>
        /// <param name="triangle">двумерный массив координат вершин треугольника</param>
        private void BuildTriangleOnChart(double[,] triangle)
        {
            this.chartTriangles.Series.Add("Found triangle");
            this.chartTriangles.Series["Found triangle"].ChartType = SeriesChartType.Line;
            this.chartTriangles.Series["Found triangle"].BorderWidth = 3;
            this.chartTriangles.Series["Found triangle"].BorderColor = Color.Red;
            for (int i = 0; i < 4; i++)
                this.chartTriangles.Series["Found triangle"].Points.AddXY(triangle[i%3, 0], triangle[i%3, 1]);
        }

        /// <summary>
        /// Формирование строки-ответа с информацией об искомом треугольнике
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        private string MakeAnswer(double[,] triangle)
        {
            string answer = "Вершины треугольника с наименьшим периметром обладают координатами:" + Environment.NewLine;
            for (int i = 0; i < 3; i++)
                answer += "(" + triangle[i, 0] + ";" + triangle[i, 1] + ") , ";
            return answer;
        }
        /// <summary>
        /// Заполнение легенды Chart
        /// </summary>
        /// <param name="Dots"> Точки Chart </param>
        /// <param name="CountDots">Количество точек</param>
        private void CreateChartnLegend(double[,] Dots,int CountDots)
        {
            this.chartTriangles.Series.Clear();
            this.chartTriangles.Series.Add("New Dots");
            this.chartTriangles.Series["New Dots"].ChartType = SeriesChartType.Point;

            for (int i = 0; i < CountDots; i++)
                this.chartTriangles.Series["New Dots"].Points.AddXY(Dots[i, 0], Dots[i, 1]);

            dataGridViewLegend.RowCount = CountDots;
            for (int i = 0; i < CountDots; i++)
            {
                dataGridViewLegend.Rows[i].Cells[0].Value = Dots[i, 0];
                dataGridViewLegend.Rows[i].Cells[1].Value = Dots[i, 1];
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо из множества точек найти такие, которые образуют треугольник с наименьшим периметром.\n" +
                "В поле \"Множество точек\" выводятся случайно сгенерированные точки с целыми координатами." +
                "В поле \"\"");
        }
    }
}

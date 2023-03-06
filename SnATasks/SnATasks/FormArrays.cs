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
    public partial class FormArrays : Form
    {
        public FormArrays()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нео,ходимо реализовать алгоритмы на симметричном и разреженном массиве.\n" +
                "Массивы целых чисел размера 6х6 генерируются случайным образом или формируются пользователем" +
                " и отображаются в полях \"Разреженная(Симметричная) матрица\".\n" +
                "В поле справа отображаются результаты работы различным алгоритмов на симметричной и разреженной матрице.");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            int[,] SparseMatrix = GetSparseMatrix();
            int[][] PackedSparseMatrix = Matrix.PackSparse(SparseMatrix);
            int[,] UnpackedSparseMatrix = Matrix.UnpackSparse(PackedSparseMatrix);
            int[,] SymmetricalMatrix = GetSymmetricalMatrix();
            int[] PackedSymmetricalMatrix = Matrix.PackSymmetrical(SymmetricalMatrix);
            int[,] UnpackedSymmetricalMatrix = Matrix.UnpackSymmetrical(PackedSymmetricalMatrix);

            tbContent.Text = MakeAnswer(PackedSparseMatrix, UnpackedSparseMatrix,PackedSymmetricalMatrix,UnpackedSymmetricalMatrix);
        }

        private string MakeAnswer(int[][] PackedSparse,int[,] UnpackedSparse, int[] PackedSymmetrical, int[,] UnpackedSymmetrical)
        {
            string answer = "Результаты работы алгоритмов:"+Environment.NewLine+"Запакованная разреженная матрица:" + Environment.NewLine;
            answer += ArrayArraysToString(PackedSparse) + Environment.NewLine;
            answer += "Распакованная разреженная матрица:" + Environment.NewLine;
            answer += Array2dToString(UnpackedSparse)+ Environment.NewLine;
            answer += "Запакованная симметричная матрица:" + Environment.NewLine;
            answer += ArrayToString(PackedSymmetrical) + Environment.NewLine;
            answer += "Распакованная симметричная матрица:" + Environment.NewLine;
            answer += Array2dToString(UnpackedSymmetrical);


            return answer;
        }

        private string ArrayArraysToString(int[][] packedSparseMatrix)
        {
            string answer = "";
            foreach (int[] array in packedSparseMatrix)
                answer += ArrayToString(array) + Environment.NewLine;
            return answer;
        }

        private int[,] GetSymmetricalMatrix()
        {
            int[,] Symmetricalmatrix = new int[6, 6];
            int index1 = 0;
            int index2 = 0;
            foreach (TextBox tb in gBSymmetricalMatrix.Controls)
            {
                Symmetricalmatrix[index1, index2] = int.Parse(tb.Text);
                index2++;
                if (index2 > 5)
                {
                    index2 = 0;
                    index1++;
                }
            }
            return Symmetricalmatrix;
        }

        private int[,] GetSparseMatrix()
        {
            int[,] Sparsematrix = new int[6, 6];
            int index1 = 0;
            int index2 = 0;
            foreach (TextBox tb in gBSparseMatrix.Controls)
            {
                Sparsematrix[index1, index2] = int.Parse(tb.Text);
                index2++;
                if (index2 > 5)
                {
                    index2 = 0;
                    index1++;
                }
            }
            return Sparsematrix;
        }

        private string Array2dToString(int[,] matrix)
        {
            string answer = "";
            for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(0)+1; j++)
                {
                    answer += matrix[i, j]+" ";
                }
                answer += Environment.NewLine;
            }
            return answer;
        }

        private string ArrayToString(int[] matrix)
        {
            string answer = "";
            foreach (int element in matrix)
                answer += element + " ";
            return answer;
        }

        private void buttonFillRandomSparse_Click(object sender, EventArgs e)
        {
            int[,] matrix = Matrix.GetSparseMatrix(6,new int[] {0,-100,100 });
            int row = 0; int column = 0;
            foreach(TextBox tb in gBSparseMatrix.Controls)
            {
                tb.Text = matrix[row, column].ToString();
                column++;
                if(column > 5)
                {
                    column = 0;
                    row++;
                }
            }
        }

        private void buttonbuttonFillRandomSymmetrical_Click(object sender, EventArgs e)
        {
            int[,] matrix = Matrix.GetSimmMatrix(6, new int[] { -100, 100 });
            int row = 0; int column = 0;
            foreach (TextBox tb in gBSymmetricalMatrix.Controls)
            {
                tb.Text = matrix[row, column].ToString();
                column++;
                if (column > 5)
                {
                    column = 0;
                    row++;
                }
            }
        }
    }
}

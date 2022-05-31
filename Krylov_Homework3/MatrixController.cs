using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krylov_Homework3
{
    class MatrixController
    {
        int[,] matrix;

        public MatrixController(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public MatrixController(int n, int m)
        {
            this.matrix = new int[n, m];
        }
        public void SetMatrixNormal()
        {
            int counter = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = counter++;
                }
            }
        }
        public void SetMatrixVerticalSnake()
        {
            int counter = 1;
            bool turn = true;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (turn)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        matrix[j, i] = counter++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                    {
                        matrix[j, i] = counter++;
                    }
                }
                turn = !turn;

            }
        }
        public void SetMatrixDiagonalSnake(Direction direction)
        {
            int counter = 1;
            int dir, ii, jj;
            if (direction == Direction.Down)
            {
                dir = 1;
                ii = 2;
                jj = 1;
            }
            else
            {
                dir = 0;
                ii = 1;
                jj = 2;
            }
            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                if (line % 2 == dir)
                {
                    int i1 = line;
                    int j1 = 0;
                    for (int i = 0; i < line + 1; i++)
                    {
                        matrix[i1, j1] = counter++;
                        i1--;
                        j1++;
                    }
                }
                else
                {
                    int i1 = 0;
                    int j1 = line;
                    for (int i = 0; i < line + 1; i++)
                    {
                        matrix[i1, j1] = counter++;
                        i1++;
                        j1--;
                    }
                }
            }
// можна біло б уникнути цього циклу. Але алгоритмічно складніше. Трба було знайти закономірність
            for (int line = matrix.GetLength(0) - 1; line >= 0; line--)
            {
                if (line % 2 == dir)
                {
                    int i1 = ii;
                    ii += 2;
                    int j1 = matrix.GetLength(0) - 1;
                    for (int i = 0; i < line; i++)
                    {
                        matrix[i1, j1] = counter++;
                        i1++;
                        j1--;
                    }
                }
                else
                {
                    int i1 = matrix.GetLength(0) - 1;
                    int j1 = jj;
                    jj += 2;
                    for (int i = 0; i < line; i++)
                    {
                        matrix[i1, j1] = counter++;
                        i1--;
                        j1++;
                    }
                }
            }


        }
        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    line += matrix[i, j] + "\t";
                }
                line += "\n";
            }
            return line;
        }
        public int[,] Matrix { get => matrix; set => matrix = value; }
    }
}

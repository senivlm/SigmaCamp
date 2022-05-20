using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krylov_Homework2
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
        public void SetMatrixDiagonalSnake() //метод не працює
        {
            //[0,0][0,1][0,2]
            //[1,0][1,1][1,2]
            //[2,0][2,1][2,2]

            //[0,0] [0,1][1,0] [2,0][1,1][0,2] [1,2][2,1] [2,2]
            bool flag = true;
            int sum = 0, i = 0, j = 0, line = 1;
            int counter = 1, c = 0;

            for (int k = 0; k < matrix.Length; k++)
            {
                for (int l = 0; l < line; l++)
                {
                    if (counter == 1)
                    {
                        i = 0;
                        j = 0;
                    }
                    else
                    {
                        if (c == line)
                        {
                            if (j < matrix.GetLength(0))
                            {
                                j++;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                i++;
                                j = sum - i;
                            }
                            else if (i == line - 1)
                            {
                                i--;
                                j = sum - i;
                            }
                            else
                            {
                                throw new Exception("Ne raboteye nichogo");
                            }
                        }

                    }

                    matrix[i, j] = counter++;
                    c++;
                }
                sum++;
                if (line < matrix.GetLength(0) && flag)
                {
                    line++;
                }
                else
                {
                    flag = false;
                    line--;
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

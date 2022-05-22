using System;

namespace Krylov_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array= new int[7,3];
            MatrixController matrix = new MatrixController(array);
            Console.WriteLine(matrix);
            matrix.SetMatrixDiagonalSnake();
            Console.WriteLine(matrix);
        }
    }
}

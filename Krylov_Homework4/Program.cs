﻿using System;

namespace Krylov_Homework4
{// Ваш номер у списку 50.
    enum Direction
    {
        Right,
        Down
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(15);
            vector.InitShuffle();
            Console.WriteLine(vector);
            vector.QuickSort();
            Console.WriteLine(vector);
        }
    }
}

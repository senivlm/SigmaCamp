using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krylov_Homework4
{
    class Vector
    {
        int[] array;
        public int this[uint index]
        {
            get
            {
                if (index < array.Length)
                {
                    return array[index];

                }
                else
                {
                    throw new ArgumentException();
                }
            }
            set
            {
                array[index] = value;
            }
        }
        public Vector(int n)
        {
            array = new int[n];
        }
        public Vector(int[] array)
        {
            this.array = array;
        }
        public void InitRand(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(a, b);
            }
        }
        public void ReverseArr()
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        public void ReverseArrStandart()
        {
            Array.Reverse(array);
        }
        public int FindLongestSequence()
        {
            int num = 0, counter = 0, counterMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    num = array[i];
                    counter++;
                    counterMax = counter;
                }
                else if (array[i] == array[i - 1])
                {
                    counter++;

                }
                else
                {
                    counter = 1;

                }
                if (counter > counterMax)
                {
                    counterMax = counter;
                    num = array[i];
                }
            }
            return num;
        }
        public bool IsPalindrom()
        {
            for (int i = 0; i <= array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    break;
                }
                else if (i == array.Length / 2)
                {
                    return true;
                }
            }
            return false;
        }
        public void InitShuffle()
        {
            Random random = new Random();
            int[] numbers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int r = random.Next(numbers.Length);
                array[i] = numbers[r];
                numbers[r] = numbers[numbers.Length - 1];
                Array.Resize(ref numbers, numbers.Length - 1);
            }
            // OLD ALGORITHM
            //int index = Array.IndexOf(array, 0);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    while (true)
            //    {
            //        int r = random.Next(1, array.Length + 1);
            //        bool isExist = false;
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (array[j] == r)
            //            {
            //                isExist = true;
            //                break;
            //            }
            //        }
            //        if (!isExist)
            //        {
            //            array[i] = r;
            //            break;
            //        }

            //    }
            //}
        }
        public Pair[] CalculateFreq()
        {
            Pair[] pairs = new Pair[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                pairs[i] = new Pair(0, 0);
            }
            int countDifference = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if (array[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = array[i];
                    countDifference++;

                }
            }
            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }
            return result;
        }
        public void Bubble()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int item = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = item;
                    }
                }
            }
        }
        public void Counting()
        {
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            int[] temp = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                temp[array[i] - min]++;
            }
            int k = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i]; j++)
                {
                    array[k] = i + min;
                    k++;
                }
            }
        }
        void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        int Partition(int minIndex, int maxIndex)
        {
            var pivot = minIndex-1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        void QuickSort(int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return;
            }

            var pivotIndex = Partition(minIndex, maxIndex);
            QuickSort(minIndex, pivotIndex - 1);
            QuickSort(pivotIndex + 1, maxIndex);
        }

        public void QuickSort()
        {
            QuickSort(0, array.Length - 1);
        }
        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < array.Length; i++)
            {
                line += array[i] + " ";
            }
            return line;
        }
    }
}

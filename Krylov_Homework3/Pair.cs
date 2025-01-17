﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krylov_Homework3
{
    class Pair
    {
        private int number;
        private int freq;
        public Pair(int number,int freq)
        {
            this.number = number;
            this.freq = freq;
        }
        public int Number { get => number; set => number = value; }
        public int Freq { get => freq; set => freq = value; }
        public override bool Equals(object obj)
        {
            if (obj ==null)
            {
                return false;
            }
            if(!(obj is Pair))
            {
                return false;
            }
            return (this.Number == ((Pair)obj).Number) && (this.Freq == ((Pair)obj).Freq);
        }
        
    }
}

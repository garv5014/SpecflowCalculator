﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        public int Sub() 
        { 
            return FirstNumber - SecondNumber ;  
        }

        public int Mul() 
        { 
            return FirstNumber * SecondNumber;
        }

        public int Plus( int num) 
        {
            FirstNumber+= num;
            return FirstNumber;
        }

        public int Minus(int num)
        {
            FirstNumber -= num;
            return FirstNumber;
        }


        public int Div(int num) 
        {
            FirstNumber /= num;
            return FirstNumber;
        }
        public int Mod(int num)
        {
            FirstNumber %= num;
            return FirstNumber;
        }

    }
}

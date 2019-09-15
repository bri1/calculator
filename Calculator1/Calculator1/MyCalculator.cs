using System;
using System.Collections.Generic;
using System.Text;// importing packages

namespace Calculator1
{
    public class MyCalculator
    {
        public decimal Add(decimal input1, decimal input2)
        {
            return input1 + input2;
        }

        public decimal Multiply(decimal input1, decimal input2)
        {
            return input1 * input2;
        }

        public decimal Square(decimal input1)
        {
            return input1 * input1;
        }

    }
}

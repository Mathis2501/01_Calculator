using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            return y + x;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Power(int x, int y)
        {
            var OriginalInput = x;
            for (int i = 1; i < y; i++ )
            {
                x = OriginalInput * x;
            }
            return x;
            
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Factorial(int x)
        {
            var ReducingValue = x - 1;
            for (int i = x - 1; i > 0; i--)
            {
                x = ReducingValue * x;
                ReducingValue = ReducingValue - 1;
            }
            return x;
        }

        internal static int Sum(int[] numbers)
        {
            return numbers[0] + numbers[1];
        }

    }
}

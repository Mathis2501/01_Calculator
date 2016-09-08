using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    public class Calculator
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

        public static int Multiply(int[] numbers)
        {
            int resultat = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                resultat = resultat * numbers[i];
            }
            return resultat;
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

        public static int Sum(int[] numbers)
        {
            int resultat = 0;
            for (int i=0; i< numbers.Length; i++)
            {
                resultat = resultat + numbers[i];

            }
            return resultat;
        }

    }
}

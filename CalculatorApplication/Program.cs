using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace CalculatorApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("how do you wanna do Maths today? Add(A), Subtract(S), Multiply(M), Factorial(F), Power(P), Sum(U)");
            UserChoiceInput = Console.ReadKey();
            switch (UserChoiceInput)
            {
                case "A":
                    
                    Console.WriteLine("Which numbers do you want\n"); //Prompts user for input
                    int UserNumberOne = int.Parse(Console.ReadLine()); //Accepts first input
                    int UserNumberTwo = int.Parse(Console.ReadLine()); //Accepts Second input
                    Console.WriteLine(Calculator.Add(UserNumberOne, UserNumberTwo));
                    Console.ReadLine();
                    break;
            }
        }
    }
}

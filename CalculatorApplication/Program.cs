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
            string UserChoiceInput = Console.ReadLine();
            switch (UserChoiceInput.ToUpper())
            {
                case "A":
                    Console.WriteLine("Which numbers do you want\n"); //Prompts user for input
                    int AddNumberOne = int.Parse(Console.ReadLine()); //Accepts first input
                    int AddNumberTwo = int.Parse(Console.ReadLine()); //Accepts Second input
                    Console.WriteLine(Calculator.Add(AddNumberOne, AddNumberTwo));
                    Console.ReadLine();
                    break;

                case "S":
                    Console.WriteLine("Which numbers do you want\n"); //Prompts user for input
                    int SubtractNumberOne = int.Parse(Console.ReadLine()); //Accepts first input
                    int SubtractNumberTwo = int.Parse(Console.ReadLine()); //Accepts Second input
                    Console.WriteLine(Calculator.Subtract(SubtractNumberOne, SubtractNumberTwo));
                    Console.ReadLine();
                    break;
                case "M":
                    Console.WriteLine("How many numbers do you want to multiply\n"); //Prompts user for input
                    int MultiplyXNumbers = int.Parse(Console.ReadLine());
                    int[] numbers = new int[1];
                    numbers = new int[MultiplyXNumbers];
                    for (int i = 0; i < MultiplyXNumbers; i++)
                    {
                        int EnterNumberOne = i + 1;
                        Console.WriteLine("Enter the " + EnterNumberOne + " Number");
                        numbers[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(Calculator.Multiply(numbers));
                    Console.ReadLine();
                    break;
            }
        }
    }
}

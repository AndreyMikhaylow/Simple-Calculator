using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                //variables
                double firstNumber, secondNumber;

                string sign;

                double result;

                try
                {
                    //first number
                    Console.WriteLine("Enter the first number");

                    firstNumber = double.Parse(Console.ReadLine());

                    //second number
                    Console.WriteLine("Enter the second number");

                    secondNumber = double.Parse(Console.ReadLine());

                    //operator
                    Console.WriteLine("Enter operator '+', '-', '*', '/'");

                    sign = Console.ReadLine();
                }

                catch (Exception)
                {
                    Console.WriteLine("invalid syntax :(");
                    Console.ReadLine();
                    continue;
                }

                //logic
                switch (sign)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        Console.WriteLine("Result = " + result);
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        Console.WriteLine("Result = " + result);
                        break;

                    case "*":
                        result = firstNumber * secondNumber;
                        Console.WriteLine("Result = " + result);
                        break;

                    case "/":
                        if (secondNumber == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine("Result = " + firstNumber / secondNumber);
                        break;

                    default:
                        Console.WriteLine("invalid syntax :(");
                        break;


                }
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }
    }
}

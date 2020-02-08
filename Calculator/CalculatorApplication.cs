using System;
using CalculatorOps;

namespace Calculator
{
    class CalculatorApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("This application allows you to perform basic mathematics calculation\n 1. Addittion (+)\n 2. Subraction(-)\n 3. Multiplcation(*)\n Division()\n Exponential(**)\n 4. Modulus(%)");
            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select an operator: ");
            String ops = Console.ReadLine();
            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result;
            if(ops.Equals("+")){
                result = CalculatorOperation.add(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {result}");

            } else if(ops.Equals("-")){
                result = CalculatorOperation.subract(num1, num2);
                Console.WriteLine($"{num1} - {num2} = {result}");


            }else if (ops.Equals("/"))
            {
                result = CalculatorOperation.divide(num1, num2);
                Console.WriteLine($"{num1} / {num2} = {result}");


            }else if (ops.Equals("*"))
            {
                result = CalculatorOperation.multiply(num1, num2);
                Console.WriteLine($"{num1} * {num2} = {result}");
            }else if (ops.Equals("%"))
            {
                result = CalculatorOperation.modu(num1, num2);
                Console.WriteLine($"{num1} % {num2} = {result}");
            }else
            {
            
                Console.WriteLine($"Invalid operator.");
            }
            Console.Read();
        }
    }

}

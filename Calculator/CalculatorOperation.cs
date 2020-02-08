using System;

namespace CalculatorOps
{
    public class CalculatorOperation
    {
        // Addttion
        static public int add(int num1, int num2){
            return num1 + num2;
        }

        // Subraction
        static public int subract(int num1, int num2)
        {
            return num1 - num2;
        }

        // Multiplication
        static public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Division
        static public int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        // Modulus
        static public int modu(int num1, int num2){
            var res = num1 % num2;
            return res;
        }

    }
}
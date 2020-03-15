using System;
using System.Text;
using System.IO;

namespace StringLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strWithEvenPosition = new StringBuilder();
            StringBuilder strWithOddPosition = new StringBuilder();
            Console.WriteLine("Number of test cases: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Input string 1: ");
                string s1 = Console.ReadLine();

                string[] strArr = s1.Split(',');

                for (int n = 0; n < strArr.Length; n++)
                {
                    strWithEvenPosition.Clear();
                    strWithOddPosition.Clear();
                    char[] charArr = strArr[n].ToCharArray();
                    for (int j = 0; j < charArr.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            strWithEvenPosition.Append(charArr[j]);
                        }
                        else if (j % 2 == 1)
                        {
                            strWithOddPosition.Append(charArr[j]);
                        }
                    }
                    string oddString = $"{strWithOddPosition.ToString()}";
                    string evenString = $"{strWithEvenPosition.ToString()}";
                    Console.WriteLine($"{evenString} {oddString}");
                }

            }
        }
    }
}

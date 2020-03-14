using System;
using System.IO;
using System.Text;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            convertNumberToWords(9);
        }

        public static string convertNumberToWords(int num)
        {
            Dictionary<string, string> digits = new Dictionary<string, string>(){ 
                {'1', 'One'}, 
                {'2', 'Two'},
                {'3', 'Three'},
                {'4', 'Four'},
                {'5', 'Five'},
                {'6', 'Six'},
                {'7', 'Seven'},
                {'8', 'Eight'},
                {'9', 'Nine'},
            };
            Dictionary<string, string> tens = new Dictionary<string, string>(){ 
                {'10', 'One'}, 
                {'20', 'Twenty'},
                {'30', 'Thirty'},
                {'40', 'Fourty'},
                {'50', 'Fifty'},
                {'60', 'Sixty'},
                {'70', 'Seventy'},
                {'80', 'Eighty'},
                {'90', 'Ninety'}
            };

            Dictionary<string, string> teens = new Dictionary<string, string>(){ 
                {'11', 'Eleven'}, 
                {'12', 'Twelve'},
                {'13', 'Thirteen'},
                {'14', 'Fourteen'},
                {'15', 'Fifteen'},
                {'16', 'Sixteen'},
                {'17', 'Seventeen'},
                {'18', 'Eighteen'},
                {'19', 'Nineteen'}
            };

            StringBuilder words = new StringBuilder();
            string number = string.Parse(num);
            Console.WriteLine(number);
        }
    }
}

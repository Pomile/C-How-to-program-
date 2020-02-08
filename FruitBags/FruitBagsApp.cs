using System;


namespace FruitBags
{
    public class FruitBagsApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equality Operator in action (==)");
            Console.WriteLine("Logical operators \n a. And (&&)\n b. Or (||))");
            Console.Write("Please enter the number of bags of fruit: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 4 && num < 4 && num > 0 ){
                Console.WriteLine("Not Heavy");
            } else if(num > 4 && num <= 8){
                Console.WriteLine("Heavy");
            }else{
                Console.WriteLine("Too Heavy");
            }
            
        }
    }
}
using System;

namespace FruitBags
{
    class EqualitOps
    {
        public void EqulityOps()
        {
            Console.WriteLine("Equality kinds in c# and equality operator");
            // Referencing the same object
            object a1 = new object();
            object b1 = a1;
           Console.WriteLine(Object.ReferenceEquals(a1, b1));
           // Numeric equality: True
            Console.WriteLine((2 + 2) == 4);
            // Reference equality: different objects,
            // same boxed value: False.
            object s = 1;
            object t = 1;
            Console.WriteLine(s == t);
            // Define some strings:
            string a = "hello";
            string b = String.Copy(a);
            string c = "hello";
            // Compare string values of a constant and an instance: True
            Console.WriteLine(a == b);
            // Compare string references;
            // a is a constant but b is an instance: False.
            Console.WriteLine((object)a == (object)b);
            // Compare string references, both constants
            // have the same value, so string interning
            // points to same reference: True.
            Console.WriteLine((object)a == (object)c);
        }
    }
}

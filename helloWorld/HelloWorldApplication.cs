using System;
/*
Namespaces are heavily used in C# programming in two ways. First, .NET uses namespaces to organize its many classes. System is a namespace and Console is a class in that namespace. The using keyword can be used so that the complete name is not required,

Second, declaring your own namespaces can help you control the scope of class and method names in larger programming projects.
 */
namespace helloWorld
{
    class HelloWorldApplication
    {
        // method main begins the program exection
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

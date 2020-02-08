using System;
using System.Collections.Generic;
using System.Linq;

namespace Person
{
    class PersonApp
    {
        static void Main(string[] args)
        {
           // Create a person object
            Person p1 = new Person{ Name="Yomi", Age=40, Height = 6, Color="brown"};
            Console.WriteLine("Hello " + p1.Name);
            // Set a person name
            p1.Name="Abayomi";
            // display a person attribute
            Console.WriteLine("First person " + p1.toString());
            Console.WriteLine("Color : " + p1.Color);
            Console.WriteLine("PG: "+ p1.pG(41));

            // Create a second person object
            Person p2 = new Person{ Name="Shola", Age=40, Height = 6, Color="Black"};
            Console.WriteLine("Sercond person " + p2.toString());
            Console.WriteLine("Person 1 and 2 are equal: "+  p1.Equals(p2));

            // Create a list of persons
            var persons = new List<Person>
            {
            new Person{ Name = "Jony3", Age = 20, Height = 10, Color="Black" },
            new Person{ Name = "Jony1", Age = 20, Height = 10, Color="Black"},
            new Person{ Name = "Jony3", Age = 21, Height = 7, Color="Black"}
            };
            // get the number person whose age and height are not equal
           var distinctPersons = persons.Distinct().Count();
           Console.WriteLine("Distinct person count: "+ distinctPersons);

           var distinctPersonsComparator = persons.Distinct(new PersonComparator()).Count();
           Console.WriteLine("Distinct person comparator count: "+ distinctPersonsComparator);


        }
    }
}

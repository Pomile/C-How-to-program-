using System;
using System.Collections.Generic;

namespace Person
{
    public class PersonComparator: IEqualityComparer<Person>
    {
       public bool Equals(Person x, Person y){
           return x.Age == y.Age && x.Height == y.Height;
       }

       public int GetHashCode(Person obj){
           return obj.Age.GetHashCode() * obj.Height.GetHashCode();
       }
    }
}
namespace Person
{
    public class Person
    {
     
      public string Name{ get; set;}
      public int Age{ get; set;}
      public int Height{ get; set;}
      public string Color{ get; set;}
      
      public string pG(int age){
          if(age > 18 || Age >= age){
              return "Eligible";
          } else if(age > 0 && age <= 18 || Age >= age ){
              return "Not Eligible";
          } else {
              return "";
          }
      }
      public override bool Equals(object obj){
          if(obj == null ) return false;
          Person  objAsPerson =  obj as Person;
          if(objAsPerson == null) return false;
          else return Equals(objAsPerson);
      }

      public bool Equals(Person person){
          if(person == null) return false;
          return Age == person.Age && Height == person.Height;
      }
      public override int GetHashCode(){
          int hashAge = Age != null ? Age.GetHashCode(): 0;
          int hashHeight = Height != null ? Height.GetHashCode(): 0;
          return hashAge * hashHeight;
      }
      public string toString(){
          return "{ Name: " + Name 
          +  ", Age : " + Age + ", Height : " + Height + "}";
      }
    }
}
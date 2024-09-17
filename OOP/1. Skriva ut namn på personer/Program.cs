using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

Person myPerson = new Person() {firstName = "Kalle", lastName = "Balle"};

Person otherPerson = new Person() {firstName = "Alle", lastName = "Balle"};

myPerson.GetFullName();
otherPerson.GetFullName();
Console.WriteLine(myPerson.GetFullNameReversed());
System.Console.WriteLine(myPerson.GetFullName());

class Person
{
    public string firstName;

    public string lastName;

    public string GetFullName(string title = "Dr")
    {
        return $"{title} {lastName}";
    }

    public string GetFullName()
   {
        return $" {firstName + " " + lastName}!";
   }

   public string GetFullNameReversed()
   {
       char[] myArray = GetFullName().ToCharArray();
       Array.Reverse(myArray);
       return new string (myArray); 
   }


}      
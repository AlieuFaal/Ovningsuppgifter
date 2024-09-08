string myString = "Detta är uppgift 3";

for (int i = 0; i < myString.Length; i++) 
{
    if (i % 2 == 0)
    {
        System.Console.Write("*");
    }
    else 
    {
        System.Console.Write(myString[i]);
    }

}

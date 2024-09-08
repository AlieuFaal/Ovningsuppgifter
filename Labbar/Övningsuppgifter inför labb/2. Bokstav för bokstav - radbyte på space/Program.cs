string myString = "This is just some other text";

for (int i = 0; i < myString.Length; i++) 
{
    System.Console.Write(myString[i]);

    if (Char.IsWhiteSpace(myString[i]))
    {
        System.Console.Write("\n");
    }

}

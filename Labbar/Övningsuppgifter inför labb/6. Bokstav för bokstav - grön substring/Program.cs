string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string myString2 = "oo";

for (int i = 0; i < myString.Length; i++)
{
    if (i <= myString.Length - 2 && myString.Substring(i, 2) == myString2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(myString.Substring(i,2));
        i++ ;
    }
    else
    {
        Console.ResetColor();
        Console.Write(myString[i]);
    }
}

Console.ResetColor();

string myString1 = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string myString2 = "chuck";

for (int i = 0; i < myString1.Length; i++)
{
    if (i <= myString1.Length - 5 && myString1.Substring(i, 5) == myString2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(myString1.Substring(i, 5));
    
        for (int j = 0; j < 4; j++)
        {
            i++;
        }    
        
    }

    else
    {
        Console.ResetColor();
        Console.Write(myString1 [i]);
    }
    
}

Console.ResetColor();
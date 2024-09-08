string myString = "Hello World";

char[] myChar = myString.ToCharArray();

foreach (char c in myChar)
{    
    
    if (c == 'l')
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    else if (c == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    else
    {
        Console.ResetColor();
    }

    Console.Write(c);
    
}



string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";

for (int i = 0; i < myString.Length; i++)
{   
    if (i == 0)
    {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(0,3));
            Console.ResetColor(); 
            System.Console.Write(myString.Substring(3 , 67));
            System.Console.Write("\n");
    } 

    if (i == 4)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,4));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(4,4));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(8,62));
        }
    }

    if (i == 9)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,9));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(9,4));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(13,57));
        }
    }
        
    if (i == 14)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,14));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(14,5));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(19,51));
        }
    }

    if (i == 20)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,20));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(20,1));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(21,49));
        }
    }

    if (i == 22)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,22));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(22,9));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(31,39));
        }
    }

    if (i == 32)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,32));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(32,5));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(37,33));
        }
    }

    if (i == 38)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,38));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(38,2));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(40,30));
        }
    }

    if (i == 41)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,41));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(41,1));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(42,28));
        }
    }

    if (i == 43)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,43));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(43,9));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(52,18));
        }
    }

    if (i == 53)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,53));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(53,5));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(58,12));
        }
    }

    if (i == 59)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,59));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(59,5));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(64,6));
        }
    }

    if (i == 65)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,65));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(65,4));
            Console.ResetColor();
            System.Console.WriteLine(myString.Substring(69,1));
        }
    }

    if (i == 69)
    {
        for (int j = 0; j < 1; j++)
        {
            System.Console.Write(myString.Substring(0,69));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(myString.Substring(69,1));
            Console.ResetColor();
        }
    }
}
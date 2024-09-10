string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";


for (int i = 0; i < myString.Length; i++)
{
    if (i == 0)
    {
        System.Console.Write(myString.Substring(0, 3));
        System.Console.Write("\n");
    } 
    
    if (i == 4)
    {
        for (int j = 0; j < 2; j++)
        {
            System.Console.Write(myString.Substring(4,4));
            System.Console.Write(" "); 
        }
            System.Console.Write("\n");   
    }

    if (i == 9)
    {
        for (int j = 0; j < 3; j++)
        {
            System.Console.Write(myString.Substring(9,4));
            System.Console.Write(" ");
        }
            System.Console.Write("\n");  
    }

    if (i == 14)
    {
        for (int j = 0; j < 4; j++)
        {
            System.Console.Write(myString.Substring(14,5));
            System.Console.Write(" ");
        }
            System.Console.Write("\n");  
    }

    if (i == 20)
    {
        for (int j = 0; j < 5; j++)
        {
            System.Console.Write(myString.Substring(20,1));
            System.Console.Write(" "); 
        }
            System.Console.Write("\n");  
    }

    if (i == 22)
    {
        for (int j = 0; j < 6; j++)
        {
            System.Console.Write(myString.Substring(22,9));
            System.Console.Write(" "); 
        }
            System.Console.Write("\n");  
    }

    if (i == 32)
    {
        for (int j = 0; j < 7; j++)
        {
            System.Console.Write(myString.Substring(32,5));
            System.Console.Write(" ");
        }
            System.Console.Write("\n");  
    }

    if (i == 38)
    {
        for (int j = 0; j < 8; j++)
        {
            System.Console.Write(myString.Substring(38,2));
            System.Console.Write(" ");
        }
            System.Console.Write("\n");  
    }

    if (i == 42)
    {
        for (int j = 0; j < 9; j++)
        {
            System.Console.Write(myString.Substring(41,1));
            System.Console.Write(" "); 
        }
            System.Console.Write("\n");  
    }

    if (i == 43)
    {
        for (int j = 0; j < 10; j++)
        {
            System.Console.Write(myString.Substring(43,9));
            System.Console.Write(" ");
        }
            System.Console.Write("\n");  
    }

    if (i == 53)
    {
        for (int j = 0; j < 11; j++)
        {
            System.Console.Write(myString.Substring(53,5));
            System.Console.Write(" ");
        }
            System.Console.Write("\n");  
    }

    if (i == 59)
    {
        for (int j = 0; j < 12; j++)
        {
            System.Console.Write(myString.Substring(59,5));
            System.Console.Write(" "); 
        }
            System.Console.Write("\n");  
    }

    if (i == 65)
    {
        for (int j = 0; j < 13; j++)
        {
            System.Console.Write(myString.Substring(65,4));
            System.Console.Write(" "); 
        }
            System.Console.Write("\n");  
    }

    if (i == 69)
    {
        for (int j = 0; j < 14; j++)
        {
            System.Console.Write(myString.Substring(69,1));
            System.Console.Write(" "); 
        } 
    }
}
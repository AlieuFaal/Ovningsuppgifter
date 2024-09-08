string myString = "Hello World!";

for (int i = 0; i <= myString.Length; i++)
{
       if (i == 1) 
       {
        Console.Write(myString.Substring(0, i));
        Console.Write("\n");
       }

        if (i == 2) 
       {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(myString.Substring(1, 1));
            }
            Console.Write("\n");
       }

        if (i == 3) 
       {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(myString.Substring(2, 1));
            }
            Console.Write("\n");
       }

        if (i == 4) 
       {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(myString.Substring(3, 1));
            }
            Console.Write("\n");
       }

        if (i == 5) 
       {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(myString.Substring(4, 1));
            }
            Console.Write("\n");
       }

        if (i == 7) 
       {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(myString.Substring(6, 1));
            }
            Console.Write("\n");
       }

        if (i == 8) 
       {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(myString.Substring(7, 1));
            }
            Console.Write("\n");
       }

        if (i == 9) 
       {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(myString.Substring(8, 1));
            }
            Console.Write("\n");
       }

        if (i == 10) 
       {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(myString.Substring(9, 1));
            }
            Console.Write("\n");
       }

        if (i == 11) 
       {
            for (int j = 0; j < 11; j++)
            {
                Console.Write(myString.Substring(10, 1));
            }
            Console.Write("\n");
       }

        if (i == 12) 
       {
            for (int j = 0; j < 12; j++)
            {
                Console.Write(myString.Substring(11, 1));
            }
       }
}
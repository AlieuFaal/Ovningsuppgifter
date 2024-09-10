String myString = "abcdefghijklmnopqrstuvwxyz";

for (int i = 0; i <= myString.Length - 5; i++)
    {
        if(i > 0)
        {
            Console.ResetColor();
            Console.Write(myString.Substring(0, i));
        }
        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(myString.Substring(i, 5));
                
            Console.ResetColor();
            Console.Write(myString.Substring(i + 5, myString.Length - (i + 5)));
                
            Console.WriteLine();
    }   


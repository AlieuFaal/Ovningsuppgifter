string myString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
Console.Write("Insert your string: ");
string yourString = Console.ReadLine();

for (int i = 0; i < myString.Length; i++)
{
    if (i <= myString.Length - yourString.Length && myString.Substring(i, yourString.Length) == yourString)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(myString.Substring (i, yourString.Length));

        for (int j = 0; j < yourString.Length - 1; j++)
        {
            i++;
        }

    }
    else 
        {
            Console.ResetColor();
            Console.Write(myString[i]);
        }
}

Console.ResetColor();
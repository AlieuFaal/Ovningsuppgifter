System.Console.Write("Enter your String: ");
string yourString = Console.ReadLine();

bool foundFirstChar = false;

for (int i = 0; i < yourString.Length; i++)
{
    if (!foundFirstChar)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ResetColor();
    }
        
        System.Console.Write(yourString[i]);

    if (i != 0 && yourString[0] == yourString[i])
    {
        foundFirstChar = true;

    }
}

Console.ResetColor();






string myString = "Hello World";

for (int i = 0; i < myString.Length - 1; i++) 
{
    if (myString[i] == myString[i + 1]) // Check if two letters are the same
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(myString[i]); // Print the first letter in green
        Console.Write(myString[i+1]); // Print the second letter in green
        Console.ResetColor();
        i++; // Skip the next character since it's already printed
    }

    else
    {
        Console.ResetColor();
        Console.Write(myString[i]); // Print non-matching letters normally
    }

}

// Print the last character if it's not part of a matching pair
if (myString.Length > 1 && myString[myString.Length - 2] != myString[myString.Length -1])
{
    Console.ResetColor();
    Console.Write(myString[myString.Length - 1]);
}

Console.ResetColor(); // Ensure color is reset when done



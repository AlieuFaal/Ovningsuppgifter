System.Console.Write("Enter your string: ");
string yourString = Console.ReadLine();

for (int start = 0; start < yourString.Length; start++)
{
    bool foundDuplicate = false;

    for (int i = 0; i < yourString.Length; i++)
    {
        // Print in red starting from the `start` index, reset if a duplicate is found or if 'i' is lesser than 'start'
        if (i < start || foundDuplicate)
        {
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        System.Console.Write(yourString[i]);

        // Set flag if the duplicate of the starting character is found
        if (i > start && yourString[start] == yourString[i])
        {
            foundDuplicate = true;
        }
    }

    // Reset color after each line
    Console.ResetColor();
    System.Console.WriteLine(); // Starts a new line
}

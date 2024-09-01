Console.Write("Skriv något: ");

char[] yourString = Console.ReadLine().ToCharArray();

Array.Reverse(yourString);

Console.WriteLine(new string(yourString));
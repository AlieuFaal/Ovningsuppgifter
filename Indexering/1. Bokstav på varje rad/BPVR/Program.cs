Console.WriteLine("Skriv något:"); 

string yourString = Console.ReadLine();

foreach (char letter in yourString)
{ 
    Console.WriteLine(letter);
}
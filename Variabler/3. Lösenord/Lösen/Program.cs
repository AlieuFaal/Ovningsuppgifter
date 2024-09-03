while (true)
{
    
Console.Write("Lösenord: ");

string yourPassword = Console.ReadLine();

string myPassword = "password123";

if (yourPassword == myPassword)
{
    Console.WriteLine("Rätt lösenord!");
}
else
{
    Console.WriteLine("Fel lösenord. Försök igen!");
}

}

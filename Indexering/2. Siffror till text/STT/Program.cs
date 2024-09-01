string[] siffror = new string[] {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};

System.Console.Write("Skriv en siffra: ");

string yourNumber = Console.ReadLine();

foreach (char siffra in yourNumber)
{
    int convertednumber  = Convert.ToInt32(char.GetNumericValue(siffra));
    System.Console.Write(siffror[convertednumber] + "-");
}
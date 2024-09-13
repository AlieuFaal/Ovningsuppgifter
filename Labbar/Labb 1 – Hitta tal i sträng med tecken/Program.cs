System.Console.Write("Enter a string: "); // Ber användaren att ge en input.
string userInput = Console.ReadLine();

List<string> validSubstrings = new List<string> (); // Skapar en lista som ska innehålla alla giltiga substrings.

for (int start = 0; start < userInput.Length; start++) // En yttre loop som går igenom alla tecken i strängen och startar från olika positioner.
{
    HashSet<char> seenDigit = new HashSet<char>(); // HashSet som håller koll på om det förekommer några duplicates och förhindrar duplicering inom samma substring.

    for (int i = start; i < userInput.Length; i++) // Inre loop som går framt från "start" för att hitta giltiga
    {
        if(!char.IsDigit(userInput[i])) // Om "i" i userInput inte är en siffra så har programmet hittat en illegal character, break.
        {
            break;
        }

        if(i <= start && seenDigit.Contains(userInput[i])) // Om siffran redan finns i HashSet "seenDigit", bryt eftersom det inte får finnas upprepade siffror i en giltig substring. 
        {
            break;
        }
        seenDigit.Add(userInput[i]); // Lägger till alla siffror som redan förekommit i HashSet "seenDigit" 

        if (i > start && userInput[start] == userInput[i]) // Om "i" är större än "start" och tecknet på "start" och indexet "i" i userInput är densamma så har vi hittat 2 av samma karaktär på olika platser vilket är det vi letar efter.
        {
            string validSubstring = userInput.Substring(start, i - start + 1); // Identifierar vart substringen ska börja och sluta och lägger sedan till substringen i listan validSubstrings.
            validSubstrings.Add(validSubstring); 
            

            Console.ResetColor(); // Ställer tillbaks färgen till sin orginal färg innan programmet ska börja färglägga.
                
            for (int j = 0; j < userInput.Length; j++) // Skriver ut hela strängen, men markerar den giltiga substringen i rött.
            {
                if (j == start || (j > start && j <= i)) // Färgar alla siffror i intervallet mellan "start" och "i"
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor(); // Skriver ut tecknet på position "j".
                }

                System.Console.Write(userInput[j]); // Skriver ut hela strängen med de rödmarkerade substringsen.
            }
            
            Console.ResetColor(); // Resettar färgen efter hela strängen har skrivits ut.
            System.Console.WriteLine(); // Startar om på ny rad.
            break; // Avslutra inre loopen efter att ha hittat en giltig substring.
        }
    }
}

Console.WriteLine("\nValid Highligted substrings:\n");

foreach (string substring in validSubstrings) // Går igenom alla substrings i validSubstrings-listan.
{
    Console.WriteLine(double.Parse(substring)); // Printar ut alla giltiga substrings från listan validSubstrings.
}

double sum = 0;

for (int i = 0; i < validSubstrings.Count; i++) // Loopar igenom alla giltiga substrings och summerar deras värden.
{
    sum += double.Parse(validSubstrings[i]);
}

Console.WriteLine($"\nTotal: {sum}"); // Skriver ut totalen av alla giltiga substrings. 
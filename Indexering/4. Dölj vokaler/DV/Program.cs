// Mitt försök med array ===>

// Console.Write("Skriv något: ");

// char[] vowels = new char[] {'a','o','u','å','e','i','y','ä','ö','A','O','U','Å','E','I','Y','Ä','Ö'};

// string yourString = Console.ReadLine();

// char censor = Convert.ToChar("*");

// foreach (char vowel in vowels)
// {
//     System.Console.WriteLine(yourString.Replace(vowel, censor));
// }



// Utan array ===>

// Console.Write("Skriv något: ");

// string yourString = Console.ReadLine();

// yourString = yourString.Replace("a", "*");
// yourString = yourString.Replace("o", "*");
// yourString = yourString.Replace("u", "*");
// yourString = yourString.Replace("å", "*");
// yourString = yourString.Replace("e", "*");
// yourString = yourString.Replace("i", "*");
// yourString = yourString.Replace("y", "*");
// yourString = yourString.Replace("ö", "*");
// yourString = yourString.Replace("A", "*");
// yourString = yourString.Replace("O", "*");
// yourString = yourString.Replace("U", "*");
// yourString = yourString.Replace("Å", "*");
// yourString = yourString.Replace("E", "*");
// yourString = yourString.Replace("I", "*");
// yourString = yourString.Replace("Y", "*");
// yourString = yourString.Replace("Ä", "*");
// yourString = yourString.Replace("Ö", "*");

//Console.WriteLine(yourString);


// Luddes lösning ===>

char[] vowels = new char[] {'a', 'o', 'u', 'å', 'ä', 'e', 'i', 'y', 'ö', 'A', 'O', 'U', 'Å', 'Ä', 'E', 'I', 'Y', 'Ö'};
Console.Write("Skriv något: ");

string yourString = Console.ReadLine();

char[] yourStringToChars = yourString.ToCharArray();

for (int i = 0; i < yourStringToChars.Length; i++)
{
    if (vowels.Contains(yourStringToChars[i])) 
    {
        yourStringToChars[i] = '*';
    }
}

Console.WriteLine(yourStringToChars);
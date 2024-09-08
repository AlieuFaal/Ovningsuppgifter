string myString = "Helloimsofucking good!";

char [] charString  = myString.ToCharArray();

for (int i = 0; i < charString.Length; i++) 
{
    System.Console.Write(charString[i]);

    if (Char.IsWhiteSpace(charString[i]))
    {
        break;
    }

}

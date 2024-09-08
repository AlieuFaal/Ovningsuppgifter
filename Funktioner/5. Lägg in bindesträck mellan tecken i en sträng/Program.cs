static string minString(string Name)
{       
    string combinedString = string.Join("-", Name.ToCharArray());
   
   return combinedString;
}

System.Console.WriteLine(minString("Carl"));
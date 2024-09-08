static string myJoin(string Land1, string Land2, string Land3)
{
    
    string superString = string.Join("->", Land1, Land2, Land3);
    
   
        return superString;
}

System.Console.WriteLine(myJoin("Sverige ", " Norge ", " Irland"));
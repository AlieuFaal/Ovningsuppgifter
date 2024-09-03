while(true)
{
System.Console.Write("Skriv ett tal: ");

int dittTal = Convert.ToInt32(Console.ReadLine());

if (dittTal < 100)
{
    System.Console.WriteLine($"Ditt tal {dittTal}, är mindre än 100.");
}
    else if (dittTal > 100)
    {
        System.Console.WriteLine($"Ditt tal {dittTal}, är större än 100.");
    }

        else if (dittTal == 100)
        {
            System.Console.WriteLine($"Ditt tal {dittTal}, är lika med 100.");
        }
}
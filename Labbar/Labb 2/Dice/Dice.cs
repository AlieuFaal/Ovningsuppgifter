class Dice
{
    private int NumberOfDice { get; set; }
    private int SidesPerDice { get; set; }
    private int Modifier { get; set; }
    public static int Result;
    static Random random = new Random();

    public Dice (int _numberOfDice, int _sidesPerDice, int _modifier)
    {
        NumberOfDice = _numberOfDice;
        SidesPerDice = _sidesPerDice;
        Modifier = _modifier;
    }

    public int ThrowDice()
    {
        Result = 0;
        
        for (int i = 0; i < NumberOfDice; i++)
        {
            Result += random.Next(1, SidesPerDice + 1) + Modifier;
        }
        
        Result += Modifier;
        
        return Result;   
    }

    public override string ToString()
    {
        Console.SetCursorPosition(0, 2);
        return $"Rolled {NumberOfDice}d{SidesPerDice}+{Modifier} = {Result}"; 
    }
}
class Dice
{
    public int NumberOfDice { get; set; }
    public int SidesPerDice { get; set; }
    public int Modifier { get; set; }

    public Dice (int _numberOfDice, int _sidesPerDice, int _Modifier)
    {
        NumberOfDice = _numberOfDice;
        SidesPerDice = _sidesPerDice;
        Modifier = _Modifier;
    }

    public int ThrowDice()
    {
        return 1; 
    }

    public override string ToString() // ???
    {
        return this.ToString(); 
    }
}

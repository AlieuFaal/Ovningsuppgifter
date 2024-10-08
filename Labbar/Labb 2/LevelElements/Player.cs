class Player : LevelElement
{
    public static int PlayerHP { get; set; }
    // public Dice AttackDice { get; set; }
    // public Dice DefenceDice { get; set; }
    
    public Player()
    {
        ClassChar = '@'; 
        CharColor = ConsoleColor.White;
        PlayerHP = 100;
        // AttackDice = 2d6+2;
        // DefenceDice = 2d6+0;
    }
}
class Player : LevelElement
{
    Dice _attackDie = new Dice(2,6,2);
    Dice _defenceDie = new Dice(2,6,0);
    
    public static int PlayerHP { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }
    public int ATK { get; set; }
    public int DEF { get; set; }
    
    public Player()
    {
        ClassChar = '@'; 
        CharColor = ConsoleColor.White;
        PlayerHP = 1000; // Mer HP för testing purposes...
        AttackDice = _attackDie;
        DefenceDice = _defenceDie;
    }

    public void Attack(Enemy enemy)
    {
        AttackDice.ThrowDice();
        Console.SetCursorPosition(40,0);
        System.Console.Write("Player Dice:");
        Console.SetCursorPosition(40,2);
        System.Console.Write(AttackDice.ToString());
        Console.SetCursorPosition(35,2);
        System.Console.Write("ATK:");
        int ATK = AttackDice.Result;

        enemy.Defend(ATK,this);
        
        Console.SetCursorPosition(65, 8);
        Console.Write($"You attacked {enemy.EnemyName} for {ATK} damage!");
    }

    public void Defend(int IncomingDmg)
    {
        DefenceDice.ThrowDice();
        Console.SetCursorPosition(40, 3);
        System.Console.Write(DefenceDice.ToString());
        Console.SetCursorPosition(35,3);
        System.Console.Write("DEF:");
        int DEF = DefenceDice.Result; 

        int DmgTaken = IncomingDmg - DEF;
        
        if (DmgTaken > 0)
        {
            PlayerHP -= DmgTaken;
        }
        Console.SetCursorPosition(65, 9);
        Console.Write($"You defended against {IncomingDmg} damage. You took {DmgTaken} damage!");
    }
}
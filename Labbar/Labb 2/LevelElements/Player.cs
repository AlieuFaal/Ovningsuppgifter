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
        PlayerHP = 1000;
        AttackDice = _attackDie;
        DefenceDice = _defenceDie;
    }
    
    private static void DisplayMessage(string message)
    {
        Console.SetCursorPosition(0, 2);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 2);
        Console.Write(message);
    }

    public void Attack(Enemy enemy)
    {
        AttackDice.ThrowDice();
        System.Console.WriteLine(_attackDie.ToString());
        int Damage = AttackDice.Result;

        enemy.Defend(Damage,this);
        
        DisplayMessage($"You attacked {Enemy.EnemyName} for {Damage} damage!");
    }

    public void Defend(int IncomingDmg)
    {
        DefenceDice.ThrowDice();
        System.Console.WriteLine(_defenceDie.ToString());
        int Defence = DefenceDice.Result; 

        int DmgTaken = IncomingDmg - Defence;
        
        if (DmgTaken > 0)
        {
            PlayerHP -= DmgTaken;
        }
        DisplayMessage($"You defended against {IncomingDmg} damage. You took {DmgTaken} damage!");
    }
}
class Player : LevelElement
{
    Dice _attackDie = new Dice(2,6,2);
    Dice _defenceDie = new Dice(2,6,0);
    
    public static int PlayerHP { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }
    public int DMG { get; set; }
    public int DEF { get; set; }
    
    public Player()
    {
        ClassChar = '@'; 
        CharColor = ConsoleColor.White;
        PlayerHP = 100;
        AttackDice = _attackDie;
        DefenceDice = _defenceDie;
    }
    
    private static void DisplayMessage(string message)
    {
        Console.SetCursorPosition(0, 3);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, 3);
        Console.Write(message);
    }

    public void Attack(Enemy enemy)
    {
        AttackDice.ThrowDice();
        System.Console.WriteLine(_attackDie.ToString());
        int Damage = Dice.Result;
    
        foreach (LevelElement element in LevelData.Elements)
        {
            if (element is Rat rat)
            {
                rat.Defend(Damage, this);
            }
            else if (element is Snake snake)
            {
                snake.Defend(Damage, this);
            }
        }
        // DisplayMessage($"You attacked {enemy.EnemyName} for {Damage} damage!");
    }

    public void Defend(int IncomingDmg)
    {
        DefenceDice.ThrowDice();
        System.Console.WriteLine(_defenceDie.ToString());
        int Defence = Dice.Result; 

        int DmgTaken = IncomingDmg - Defence;
        
        if (DmgTaken > 0)
        {
            PlayerHP -= DmgTaken;
            
            if(PlayerHP <= 0)
            {
                LevelData.Elements.Remove(this);    
            }
        }

        // DisplayMessage($"You defended against {incomingDmg} damage. You took {DmgTaken} damage!");
    }
}
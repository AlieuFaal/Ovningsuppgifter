class Snake : Enemy
{
    Dice _attackDie = new Dice(3,4,2);
    Dice _defenceDie = new Dice(1,8,5);
    
    public Snake()
    {
        EnemyName = "Ssssnake";
        ClassChar = 's';
        CharColor = ConsoleColor.Green;
        EnemyHP = 25;
        AttackDice = _attackDie;
        DefenceDice = _defenceDie;
    }

    public override void UpdateMethod()
    {
        Player player = LevelData.Elements.OfType<Player>().FirstOrDefault();
        
        double DeltaX = this.PositionX - player.PositionX;
        double DeltaY = this.PositionY - player.PositionY;
        double DistanceToPlayer = Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY);
        
        int PreviousX = PositionX;
        int PreviousY = PositionY;
        
        if (PositionX >= 0 && PositionX < Console.WindowWidth &&
            PositionY >= 0 && PositionY < Console.WindowHeight)
        {
            if (DistanceToPlayer <= 2)
            {
                if (this.PositionX < player.PositionX && this.PositionX < Console.WindowWidth - 1)
                {
                    this.PositionX--;
                }
                else if (this.PositionX > player.PositionX && this.PositionX > 0)
                {
                    this.PositionX++;
                }

                if (this.PositionY < player.PositionY && this.PositionY < Console.WindowWidth - 1)
                {
                    this.PositionY--;
                }
                else if (this.PositionY > player.PositionY && this.PositionY > 0)
                {
                    this.PositionY++;
                }

                if (CollisionDetected(PositionX,PositionY, this))
                {
                    this.PositionX = PreviousX;
                    this.PositionY = PreviousY;  
                }
            }
        }
        this.Draw(player);
    }

    private static bool CollisionDetected(int NextX, int NextY, LevelElement movingElement)
    {
        foreach (LevelElement element in LevelData.Elements)
        {
            if (element == movingElement)
            {
                continue;
            }

            if (element is Wall or Enemy or Player && element.PositionX == NextX && element.PositionY == NextY)
            {
                return true;
            }
        }
        return false;
    }

    public override void Attack(Player player)
    {
        AttackDice.ThrowDice();
        Console.SetCursorPosition(100,0);
        System.Console.Write("Snakes' Dice:");
        Console.SetCursorPosition(100,2);
        System.Console.Write(AttackDice.ToString());
        Console.SetCursorPosition(95,2);
        System.Console.Write("ATK:");
        int ATK = AttackDice.Result;
        player.Defend(ATK);  
    }

    public override bool Defend(int incomingDmg, Player player)
    {
        DefenceDice.ThrowDice();
        Console.SetCursorPosition(100, 3);
        System.Console.Write(DefenceDice.ToString());
        Console.SetCursorPosition(95,3);
        System.Console.Write("DEF:");
        int DEF = DefenceDice.Result; 

        int DmgTaken = incomingDmg - DEF;

        if (DmgTaken > 0)
        {
            this.EnemyHP -= DmgTaken;

            Console.SetCursorPosition(65, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write($"Snake took {DmgTaken} damage! The Snake has {this.EnemyHP} HP left.");
            Console.ResetColor();

            if (this.EnemyHP <= 0)
            {
                Console.SetCursorPosition(65, 17);
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("A Snake has been defeated!");;
                Console.ResetColor();
                MarkForRemoval = true;
                return true;
            }
            else
            {
                MarkForRemoval = false;
                this.Attack(player);
                return false;
            }
        }
        else
        {
            Console.SetCursorPosition(65, 16);
            System.Console.Write("The Snake blocked your attack!");
            return false;
        }
    }
}
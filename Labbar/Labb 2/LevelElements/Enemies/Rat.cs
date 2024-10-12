class Rat : Enemy
{
    static Random random = new Random();
    
    Dice _attackDie = new Dice(1,6,3);
    Dice _defenceDie = new Dice(1,6,1);

    public Rat()
    {
        EnemyName = "Ratte";
        ClassChar = 'r';
        CharColor = ConsoleColor.Red;
        EnemyHP = 100; // Mer HP för testing purposes...
        AttackDice = _attackDie;
        DefenceDice = _defenceDie;
    }
    
    public override void Attack(Player player)
    {
        AttackDice.ThrowDice();
        Console.SetCursorPosition(70,0);
        System.Console.Write("Rat's Dice:");
        Console.SetCursorPosition(70,2);
        System.Console.Write(AttackDice.ToString());
        Console.SetCursorPosition(65,2);
        System.Console.Write("ATK:");
        int ATK = AttackDice.Result;
        player.Defend(ATK);  
    }

    public override bool Defend(int incomingDmg, Player player)
    {
        DefenceDice.ThrowDice();
        Console.SetCursorPosition(70, 3);
        System.Console.Write(DefenceDice.ToString());
        Console.SetCursorPosition(65,3);
        System.Console.Write("DEF:");
        int DEF = DefenceDice.Result; 

        int DmgTaken = incomingDmg - DEF;

        if (DmgTaken > 0)
        {
            this.EnemyHP -= DmgTaken;

            Console.SetCursorPosition(65, 11);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write($"The Rat took {DmgTaken} damage! The Rat has {this.EnemyHP} HP left.");
            Console.ResetColor();

            if (this.EnemyHP <= 0)
            {
                Console.SetCursorPosition(65, 13);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("A Rat has been defeated!");
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
            Console.SetCursorPosition(65, 12);
            System.Console.Write("The Rat blocked your attack!");
            return false; 
        }
    }

    public override void UpdateMethod()
    {       
        Player player = LevelData.Elements.OfType<Player>().FirstOrDefault();

        int PreviousX = PositionX;
        int PreviousY = PositionY;

        int direction = random.Next(4);

    if (PositionX >= 0 && PositionX < Console.WindowWidth &&
        PositionY >= 0 && PositionY < Console.WindowHeight)
        {
            switch (direction)
            {
                case 0: 
                PositionY--;
                break;

                case 1:
                PositionY++;
                break;

                case 2:
                PositionX--;
                break;

                case 3:
                PositionX++;
                break;
            }
        }

        if (CollisionDetected(PositionX,PositionY,this))
        {
            this.PositionX = PreviousX;
            this.PositionY = PreviousY;  
        }

        if (player != null && this.PositionX == player.PositionX && this.PositionY == player.PositionY )
        {
            FightCollision(player,this);
        }
        
        this.Draw(player);
    }
    
    private static void FightCollision(Player player, Enemy enemy)
    {
        if (player.PositionX == enemy.PositionX && player.PositionY == enemy.PositionY)
        {
            player.Attack(enemy);

            if (enemy.EnemyHP > 0 && enemy is Rat rat)
            {
                rat.Attack(player);
            }
            if (enemy.EnemyHP > 0 && enemy is Snake snake)
            {
                snake.Attack(player);
            }
        }
    }

    private static bool CollisionDetected(int nextX, int nextY, LevelElement movingElement)
    {
        foreach (LevelElement element in LevelData.Elements)
        {
            if (element == movingElement)
            {
                continue;
            }

            if (element is Wall or Enemy or Player && element.PositionX == nextX && element.PositionY == nextY)
            {
                return true;
            }
        }
        return false;
    }
}
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
        EnemyHP = 10;
        AttackDice = _attackDie;
        DefenceDice = _defenceDie;
    }
    
    public override void Attack(Player player)
    {
        AttackDice.ThrowDice();
        System.Console.WriteLine(AttackDice.ToString());
        int Damage = AttackDice.Result;
        player.Defend(Damage);  
    }

    public override bool Defend(int incomingDmg, Player player)
    {
        DefenceDice.ThrowDice();
        System.Console.WriteLine(DefenceDice.ToString());
        int Defence = DefenceDice.Result; 

        int DmgTaken = incomingDmg - Defence;

        if (DmgTaken > 0)
        {
            this.EnemyHP -= DmgTaken;

            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"The Rat took {DmgTaken} damage! The Rat has {this.EnemyHP} HP left.");
            Console.ResetColor();

            if (this.EnemyHP <= 0)
            {
                Console.SetCursorPosition(0, 4);
                Console.ForegroundColor = ConsoleColor.Red;
                string MyString = "A Rat has been defeated!";
                System.Console.WriteLine(MyString.PadLeft(5, ' '));
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
            Console.SetCursorPosition(0, 5);
            System.Console.WriteLine("The Rat blocked your attack!");
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
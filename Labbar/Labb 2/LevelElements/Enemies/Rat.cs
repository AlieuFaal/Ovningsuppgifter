class Rat : Enemy
{
   static Random random = new Random();
    
    public Rat()
    {
        ClassChar = 'r';
        CharColor = ConsoleColor.Red;
        EnemyHP = 10;
        // AttackDice = 1d6+3;
        // DefenceDice = 1d6+1;
    }

    public override void UpdateMethod()
    {       
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
        
        Draw();
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

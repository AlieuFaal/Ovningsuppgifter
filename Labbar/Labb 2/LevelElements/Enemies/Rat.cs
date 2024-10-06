class Rat : Enemy
{
    Random random = new Random();
    
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

        if (CollisionDetected(PositionX,PositionY))
        {
            PositionX = PreviousX;
            PositionY = PreviousY;  
        }

        Draw();
    }
    
    private static bool CollisionDetected(int nextX, int nextY)
    {
        foreach (LevelElement element in LevelData.Elements)
        {
            if ( element is Wall && element.PositionX == nextX && element.PositionY == nextY)
            {
                return true;
            }
        }
        return false;
    }
}

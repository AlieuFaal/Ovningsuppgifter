using Microsoft.VisualBasic;

class Snake : Enemy
{
    public Snake()
    {
        ClassChar = 's';
        CharColor = ConsoleColor.Green;
        EnemyHP = 25;
        // AttackDice = 3d4+2;
        // DefenceDice = 1d8+5;
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
        Draw();
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
}
class GameLoop : LevelElement 
{
    private static Player player = LevelData.Elements.OfType<Player>().FirstOrDefault();
    private static bool isGameOver = false;   

    public static void RunGame()
    {
        Console.CursorVisible = false;
        Console.Clear();
        LevelData.Load(@"E:\Coding\Lectures\Övningsuppgifter\Labbar\Labb 2\LevelData\Level1.txt");

        while (!isGameOver)
        {            
            
            for(int i = 0; i < 10000; i++)
            {
                Console.SetCursorPosition(0, 0);
                System.Console.WriteLine($"Health: {Player.PlayerHP} / 1000 ");
                
                PlayerTurn();

                if (isGameOver) break;
                
                EnemiesTurn();

                if (Player.PlayerHP <= 0)
                {
                    // Console.WriteLine("Game Over!");
                    isGameOver = true;
                }
                
                LevelData.Elements.RemoveAll(element => element is Enemy enemy && enemy.MarkForRemoval);

                Console.SetCursorPosition(25, 0);
                System.Console.WriteLine($"Turn: {i}");
            }
        }
    }
    
    private static bool CollisionDetected(int nextX, int nextY, Player player)
    {
        foreach (LevelElement element in LevelData.Elements)
        {
            if ( element is Wall or Enemy && element.PositionX == nextX && element.PositionY == nextY)
            {
                return true;
            }
        }
        return false;
    }

    private static bool IsAdjacent(int PosX1, int PosY1, int PosX2, int PosY2)
    {
        return (Math.Abs(PosX1 - PosX2) <= 1 && Math.Abs(PosY1 - PosY2) <= 1 );
    }

    private static void FightCollision(Player player, Enemy enemy)
    {
        if (IsAdjacent(player.PositionX, player.PositionY, enemy.PositionX, enemy.PositionY))
        {
            player.Attack(enemy);

            if (enemy.EnemyHP > 0)
            {
                enemy.Attack(player);
            }
            else
            {
                enemy.MarkForRemoval = true;
            }
        }
    }

    private static void PlayerTurn()
    {
        PlayerInput();
        PlayerActions();
    }

    private static void EnemiesTurn()
    {
        foreach (var element in LevelData.Elements)
        
        {
            element.Draw(player);

            if(element is Enemy enemy) 
            {
                Console.SetCursorPosition(enemy.PositionX, enemy.PositionY);
                System.Console.Write(" ");
                enemy.UpdateMethod();
                EnemyActions(enemy); 
            }
            
        }
    }

    private static void PlayerInput()
    { 
        ConsoleKeyInfo KeyInfo = Console.ReadKey(intercept: true);
        Console.SetCursorPosition(player.PositionX, player.PositionY);
        System.Console.Write(" ");

        switch(KeyInfo.Key)
        {
            case ConsoleKey.W:
            if (!CollisionDetected(player.PositionX, player.PositionY - 1, player))
            {
                player.PositionY--;
            }
            break;

            case ConsoleKey.A:
            if (!CollisionDetected(player.PositionX - 1, player.PositionY, player))
            {
                player.PositionX--;
            }
            break;
            
            case ConsoleKey.S:
            if (!CollisionDetected(player.PositionX, player.PositionY + 1, player))
            {
                player.PositionY++;
            }
            break;
            
            case ConsoleKey.D:
            if (!CollisionDetected(player.PositionX + 1, player.PositionY, player))
            {
                player.PositionX++;
            }
            break;

            case ConsoleKey.Escape:
            isGameOver = true;
            break;
        }
        
        foreach (var element in LevelData.Elements)
        {
            if (element is Enemy enemy && IsAdjacent(player.PositionX, player.PositionY, enemy.PositionX, enemy.PositionY))
            {
                FightCollision(player, enemy);
                break;
            }
        }
    }

    private static void PlayerActions()
    {
        foreach (LevelElement element in LevelData.Elements)
        {
            if (element is Player player && element is Enemy enemy)
            {
                if (IsAdjacent(player.PositionX,player.PositionY, enemy.PositionX,enemy.PositionY))
                {
                    player.Attack(enemy);
                    if (enemy.EnemyHP > 0)
                    {
                        enemy.Attack(player);
                    }
                }
            }
        }
    }

    private static void EnemyActions(Enemy enemy)
    {
        if (IsAdjacent(enemy.PositionX,enemy.PositionY, player.PositionX,player.PositionY))
        {
            enemy.Attack(player);
        }
    }
}
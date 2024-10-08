class GameLoop : LevelElement 
{
    private static Player player = LevelData.Elements.OfType<Player>().FirstOrDefault();

    private static bool isRunning = true;   
    
    public static void RunGame()
    {
        Console.CursorVisible = false;
        Console.Clear();
        LevelData.Load(@"E:\Coding\Lectures\Övningsuppgifter\Labbar\Labb 2\LevelData\Level1.txt");
        
        while (isRunning == true || Player.PlayerHP >= 0)
        {
            Console.SetCursorPosition(0, 0);
            System.Console.WriteLine($"Health: {Player.PlayerHP} / 100");
            
            for(int i = 0; i < 5000; i++)
            {
                
                PlayerInput(); 
            
                foreach (var element in LevelData.Elements) 
                {
                    
                    if(element is Enemy enemy) 
                    {
                        Console.SetCursorPosition(enemy.PositionX, enemy.PositionY);
                        System.Console.Write(" ");
                        enemy.UpdateMethod();
                    }
                }

                Console.SetCursorPosition(0, 0);
                System.Console.WriteLine($"\t\t\tTurn: {i}");
            }
        }
    }

    private static bool CollisionDetected(int nextX, int nextY,Player player1)
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
            isRunning = false;
            break;
        }
        player.Draw();
    }
}
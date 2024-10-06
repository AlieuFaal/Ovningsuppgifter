class GameLoop : LevelElement 
{
    private static Player player = new Player();
    private static Snake snake = new Snake(){EnemyName = "Seasnake"};
    private static Rat rat = new Rat() {EnemyName = "Desertrat"};
    private static bool isRunning = true;   
    
    public static void RunGame()
    {
        LevelData.Load(@"E:\Coding\Lectures\Övningsuppgifter\Labbar\Labb 2\LevelData\Level1.txt");
        player.PositionX = 4;
        player.PositionY = 3;
        
        while (isRunning == true)
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
        }
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

    private static void PlayerInput()
    {      
        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

        Console.SetCursorPosition(player.PositionX, player.PositionY);
        System.Console.Write(" ");



        switch(keyInfo.Key)
        {
            case ConsoleKey.W:
            if (!CollisionDetected(player.PositionX, player.PositionY - 1))
            {
                player.PositionY--;
            }
            break;

            case ConsoleKey.A:
            if (!CollisionDetected(player.PositionX - 1, player.PositionY))
            {
                player.PositionX--;
            }
            break;
            
            case ConsoleKey.S:
            if (!CollisionDetected(player.PositionX, player.PositionY + 1))
            {
                player.PositionY++;
            }
            break;
            
            case ConsoleKey.D:
            if (!CollisionDetected(player.PositionX + 1, player.PositionY))
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
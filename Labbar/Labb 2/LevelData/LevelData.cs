class LevelData
{
    // public static List<LevelElement> elements = new List<LevelElement>();

    public static List<LevelElement> Elements = new List<LevelElement>(); //{ get {return elements; }}
    
    public static void Load(string filename)
    {        
        Elements = new List<LevelElement>();

        using (StreamReader fileReader = new StreamReader(filename))
        {
            char wallChar = '#';
            char ratChar = 'r';
            char snakeChar = 's';
            char playerChar = '@';
    
            int y = 0;
            
            while (!fileReader.EndOfStream)
            {                
                string line = fileReader.ReadLine();
                
                for (int x = 0; x < line.Length; x++)
                {
                    char c = line[x];

                    if (c == wallChar)
                    {
                        Wall wall = new Wall() {PositionX = x, PositionY = y};
                        Elements.Add(wall);
                        // System.Console.WriteLine($"Wall created at pos: {x}, {y}");
                    }
                    else if (c == ratChar)
                    {
                        Rat rat = new Rat() {PositionX = x, PositionY = y, EnemyName = "Ratte"};
                        Elements.Add(rat);
                    }
                    else if (c == snakeChar)
                    {
                        Snake snake = new Snake() {PositionX = x, PositionY = y, EnemyName = "Ssssnake"};
                        Elements.Add(snake);
                    }
                    else if (c == playerChar)
                    {
                        Player player = new Player() {PositionX = x, PositionY = y};
                        Elements.Add(player);
                    }
                }   
                        y++;
            }
            
            foreach (var element in Elements)
            {
                // Console.WriteLine($"Loaded element: {element.GetType().Name} at ({element.PositionX}, {element.PositionY})");
                element.Draw();
            }
        }
    }
}

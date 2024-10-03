class LevelData
{
    private List<LevelElement> elements = new List<LevelElement>();

    public List<LevelElement> Elements { get {return elements; }}
    
    public static void Load(string filename)
    {        
        List<LevelElement> elements = new List<LevelElement>();


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
                        elements.Add(wall);
                    }
                    else if (c == ratChar)
                    {
                        Rat rat = new Rat() {PositionX = x, PositionY = y, EnemyName = "Ratte"};
                        elements.Add(rat);
                    }
                    else if (c == snakeChar)
                    {
                        Snake snake = new Snake() {PositionX = x, PositionY = y, EnemyName = "Ssssnake"};
                        elements.Add(snake);
                    }
                    else if (c == playerChar)
                    {
                        Player player = new Player() {PositionX = x, PositionY = y};
                        elements.Add(player);
                    }
                }   
                        y++;
            }
            
            foreach (var element in elements)
            {
                element.Draw();
            }
        }
    }
}

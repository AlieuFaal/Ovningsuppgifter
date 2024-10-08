
class LevelData
{
    public static List<LevelElement> Elements = new List<LevelElement>(); 
    
    public static void Load(string filename)
    {        
        using (StreamReader fileReader = new StreamReader(filename))
        {
            char wallChar = '#';
            char ratChar = 'r';
            char snakeChar = 's';
            char playerChar = '@';
    
            int y = 3;
            
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
                    }
                    else if (c == ratChar)
                    {
                        Rat rat = new Rat() {PositionX = x, PositionY = y};
                        Elements.Add(rat);
                    }
                    else if (c == snakeChar)
                    {
                        Snake snake = new Snake() {PositionX = x, PositionY = y};
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
                element.Draw();
            }
        }
    }
}

abstract class LevelElement
{
    public int VisionRange { get; set; }    
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public char ClassChar { get; set; }
    public ConsoleColor CharColor;
    
    public void Draw (Player player)
    {   
        if (IsWithinVisionRange())
        {
            if (PositionX >= 0 && PositionX < Console.WindowWidth &&
                PositionY >= 0 && PositionY < Console.WindowHeight)
            {
                Console.SetCursorPosition(PositionX, PositionY);
                Console.ForegroundColor = CharColor;
                Console.Write(ClassChar);
                Console.ResetColor();
            }
        }
    }

    private bool IsWithinVisionRange()
    {
        Player player = LevelData.Elements.OfType<Player>().FirstOrDefault();
        VisionRange = 5;
            
        if (player != null)
        {
            int DeltaX = Math.Abs(player.PositionX - this.PositionX);
            int DeltaY = Math.Abs(player.PositionY - this.PositionY);

            return DeltaX <= VisionRange && DeltaY <= VisionRange;
        }
        return false;
    }
}

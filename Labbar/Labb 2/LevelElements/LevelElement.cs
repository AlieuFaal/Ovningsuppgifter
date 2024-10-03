abstract class LevelElement
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public char ClassChar { get; set; }
    public ConsoleColor CharColor;

    public void Draw()
    {
        Console.SetCursorPosition(PositionX, PositionY);
        Console.ForegroundColor = CharColor;
        Console.Write(ClassChar);
        Console.ResetColor();
    }
}

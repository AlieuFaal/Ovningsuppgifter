using System.Collections;
using System.Reflection.Metadata.Ecma335;

using (LevelData.Load("Level1.txt")
{

}


abstract class LevelElement
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public char ClassChar { get; set; }
    public ConsoleColor CharColor;

    public void DrawMethod()
    {
    }
}

class Wall : LevelElement
{
    public Wall()
    {
        CharColor = ConsoleColor.Gray;
        ClassChar = '#';
    }

}

abstract class Enemy : LevelElement
{
    required public string EnemyName { get; set; }
    public double EnemyHP { get; set; }
    
    public abstract void UpdateMethod();
}

class Rat : Enemy
{
    public override void UpdateMethod()
    {

    }

}

class Snake : Enemy
{
    public override void UpdateMethod()
    {

    }
}

class LevelData
{
    private List<LevelElement> elements;

    public List<LevelElement> Elements { get {return elements; }}

    public static void Load(string filename)
    {
        using (FileStream stream = File.OpenRead(filename));
    }
}

class Dice
{
    public int NumberOfDice { get; set; }
    public int SidesPerDice { get; set; }
    public int Modifier { get; set; }

    public Dice (int _numberOfDice, int _sidesPerDice, int _Modifier)
    {
        NumberOfDice = _numberOfDice;
        SidesPerDice = _sidesPerDice;
        Modifier = _Modifier;
    }

    public int ThrowDice()
    {
        return 1; 
    }

    public override string ToString() // ???
    {
        return this.ToString(); 
    }
}

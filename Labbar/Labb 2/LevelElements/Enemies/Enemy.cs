abstract class Enemy : LevelElement
{
    public string EnemyName { get; set; }
    public int EnemyHP { get; set; }
    // public Dice AttackDice { get; set; }
    // public Dice DefenceDice { get; set; }
    
    public abstract void UpdateMethod(); // Allt fienden gör för varje runda
}

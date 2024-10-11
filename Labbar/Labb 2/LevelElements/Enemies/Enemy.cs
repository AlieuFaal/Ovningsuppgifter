abstract class Enemy : LevelElement
{
    public string EnemyName { get; set; }
    public int EnemyHP { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }
    public bool MarkForRemoval { get; set; } = false;
    

    public abstract void UpdateMethod();
}

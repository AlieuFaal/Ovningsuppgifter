abstract class Enemy : LevelElement
{
    public static string EnemyName { get; set; }
    public int EnemyHP { get; set; }
    public Dice AttackDice { get; set; }
    public Dice DefenceDice { get; set; }
    public bool MarkForRemoval { get; set; } = false;
    

    public abstract void UpdateMethod();

    public abstract void Attack(Player player);

    public abstract bool Defend(int incomingDmg, Player player);
}

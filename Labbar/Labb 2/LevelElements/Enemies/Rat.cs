class Rat : Enemy
{
    public Rat()
    {
        ClassChar = 'r';
        CharColor = ConsoleColor.Red;
        EnemyHP = 10;
        // AttackDice = 1d6+3;
        // DefenceDice = 1d6+1;
    }

    public override void UpdateMethod()
    {

    }

}

class Snake : Enemy
{
    public Snake()
    {
        ClassChar = 's';
        CharColor = ConsoleColor.Green;
        EnemyHP = 25;
        // AttackDice = 3d4+2;
        // DefenceDice = 1d8+5;
    }

    public override void UpdateMethod()
    {

    }
}

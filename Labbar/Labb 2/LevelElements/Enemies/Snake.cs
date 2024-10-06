class Snake : Enemy
{
    // Player player = new Player();
    // Snake snake= new Snake() {EnemyName = "Fck off"};

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
        // if(player.PositionX is 2 < snake.PositionX)
        // Draw();
    }
}

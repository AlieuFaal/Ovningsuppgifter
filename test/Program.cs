Dice AttackDie = new Dice(2, 6, 0);
Dice DefenceDie = new Dice(4, 4, 4);

// AttackDie.ThrowDice();
// System.Console.WriteLine(AttackDie.ToString());

// DefenceDie.ThrowDice();
// System.Console.WriteLine(DefenceDie.ToString());

AttackDie.Attack();

DefenceDie.Defend();

Console.ReadKey();

class Dice
{
    public int AttackDice { get; set; }
    public int DefenceDice { get; set; }
    private int NumberOfDice { get; set; }
    private int SidesPerDice { get; set; }
    private int Modifier { get; set; }
    private static int Result;
    static Random random = new Random();

    public Dice (int _numberOfDice, int _sidesPerDice, int _modifier)
    {
        NumberOfDice = _numberOfDice;
        SidesPerDice = _sidesPerDice;
        Modifier = _modifier;
    }

    public int ThrowDice()
    {
        Result = 0;
        
        for (int i = 0;i < NumberOfDice;i++)
        {
            Result += random.Next(1, SidesPerDice + 1) + Modifier;
        }
        
        Result += Modifier;
        
        return Result;   
    }

    public override string ToString()
    {
        return $"{NumberOfDice}d{SidesPerDice}+{Modifier} = {Result}"; 
    }

    public void Attack()
    {
        ThrowDice();
        System.Console.WriteLine(ToString());
        int DMG = Result;
        System.Console.WriteLine($"{DMG}");
        System.Console.WriteLine();
    }

    public void Defend()
    {
        System.Console.WriteLine();
        ThrowDice();
        System.Console.WriteLine(ToString());
        int DEF = Result; 
        System.Console.WriteLine($"{DEF}");
    }
}
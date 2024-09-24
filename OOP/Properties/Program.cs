using System.Dynamic;

Human human = new Human();
Stepcounter stepcounter = new Stepcounter();
Vehicle vehicle = new Vehicle();
Vehicle vehicle2 = new Vehicle();
Vehicle vehicle3 = new Vehicle("Nissan GTR", "Jade Green", 400000);

// human.FirstName = "Kalle";
// human.LastName = "Karlsson";

// System.Console.WriteLine(human.FirstName);
// System.Console.WriteLine(human.LastName);
// System.Console.WriteLine(human.GetFullName);

// System.Console.WriteLine();

// System.Console.WriteLine(stepcounter.Steps); // 1 step
// System.Console.WriteLine(stepcounter.Steps); // 2 steps
// System.Console.WriteLine(stepcounter.Steps); // 3 steps
// Stepcounter.Reset();
// System.Console.WriteLine(stepcounter.Steps);
// System.Console.WriteLine(stepcounter.Steps);
// System.Console.WriteLine(stepcounter.Steps);
// Stepcounter.Reset();

// Stepcounter.Step();
// Stepcounter.Step();

// System.Console.WriteLine();

// vehicle.Model = "Corvette C8";
// vehicle.Price = 877000;
// vehicle.Colour = "White";

// System.Console.WriteLine(vehicle.Model);
// System.Console.WriteLine(vehicle.Colour);
// System.Console.WriteLine(vehicle.Price);

// System.Console.WriteLine();

// System.Console.WriteLine(vehicle2.Model);
// System.Console.WriteLine(vehicle2.Colour);
// System.Console.WriteLine(vehicle2.Price);

// System.Console.WriteLine();

// System.Console.WriteLine(vehicle3.Model);
// System.Console.WriteLine(vehicle3.Colour);
// System.Console.WriteLine(vehicle3.Price);

Vattenglas.FyllGlaset();
Vattenglas.FyllGlaset();
Vattenglas.TömGlaset();
Vattenglas.TömGlaset();









Console.ReadKey();

class Human
{
    private string  _firstName;

    public string FirstName
    {
        get
        {
            return _firstName;
        }
        
        set
        {
            _firstName = value;
        }

    }

    public string LastName {get; set; }

    public string GetFullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
}

class Stepcounter
{
    public static int _steps = 1;

    public string Steps
    {
        get
        {return $"Steg: {_steps++}";}
    }

    public static void Reset()
    {
        _steps = 1;
    }

    public static void Step()
    {
        for (int i = 1; i <= 1000; i++)
        {
            System.Console.WriteLine($"Steg: {_steps++}"); 
        }
    }
}

class Vehicle
{
    private string _model;
    private int _price;
    private string _colour;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public Vehicle()
    {
        this.Model = "Datsun 240Z";
        this.Colour = "Black";
        this.Price = 140000;
    }

    public Vehicle(string Model, string Colour, int Price)
    {
        this.Model = Model;
        this.Colour = Colour;
        this.Price = Price;
    }
}

class Vattenglas
{
    private static bool tomtlrfullt = false;

    public static void FyllGlaset()
    {
        
        if (tomtlrfullt == true)
        {

            System.Console.WriteLine("Glaset är redan fyllt.");
        }
        else
        {
            System.Console.WriteLine("Fyller glaset.");
        }

        tomtlrfullt = true;
    }

    public static void TömGlaset()
    {
        
        if (tomtlrfullt == false)
        {
            System.Console.WriteLine("Glaset är redan tomt.");
        }
        else
        {
            System.Console.WriteLine("Tömmer glaset.");
        }
        
        tomtlrfullt = false;
    }
}
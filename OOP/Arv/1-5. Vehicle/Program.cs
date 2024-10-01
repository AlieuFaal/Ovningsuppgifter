Vehicle car1 = new Vehicle(Brand.Porsche, Color.Red);
Vehicle car2 = new Vehicle(Brand.Nissan, Color.Green);
Vehicle car3 = new Vehicle(Brand.Lamborghini);



System.Console.WriteLine(car1.Brand);
System.Console.WriteLine(car1.Color);
System.Console.WriteLine(car2.Brand);
System.Console.WriteLine(car2.Color);
System.Console.WriteLine(car3.Brand);
System.Console.WriteLine(car3.Color);
System.Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));
System.Console.WriteLine(new Vehicle(Brand.Nissan, Color.Blue));
System.Console.WriteLine(new Car(Brand.Nissan, "R-34 GTR", Color.Blue));
System.Console.WriteLine(new VehicleSize (10,20,30));






Console.ReadKey();
struct VehicleSize
{
    public double Length { get; set;}
    public double Width { get; set;}
    public double Height { get; set;}

    public VehicleSize (double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"Width: {Width}cm\nHeight: {Height}cm\nLength: {Length}cm";
    }
    
}

enum Brand
{
    Corvette,
    Porsche,
    Nissan,
    Toyota,
    Lamborghini
}

enum Color
{
    Red,
    Green,
    Blue,
    White,
    Black 
}

class Vehicle
{
    public Brand Brand { get; set; }

    public Color Color { get; set; }
    
    public VehicleSize Size { get; set; }

    public Vehicle (Brand _brand, Color _color)
    {
        var rand = new Random();
        VehicleSize _size = new VehicleSize();
        _size.Length = rand.NextDouble() + rand.Next(2 , 6);

        Brand = _brand;
        Color = _color;
        Size = _size;

    }

    public Vehicle (Brand _brand) : this (_brand, Color.White)
    {
        Brand = _brand;
        Color = Color.White;
    }

    public Vehicle ()
    {

    }

    public override string ToString()
    {
        return $"A {Color} {Brand}";
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car (Brand brand, string model, Color color) : base (brand, color)
    {
        Model = model;
    }

    public override string ToString()
    {
        return $"A {Color} {Size.Length} meter long {Model} from {Brand}!";
    }
}


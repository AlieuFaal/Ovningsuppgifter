using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

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
System.Console.WriteLine(new Size (10,20,30));






Console.ReadKey();
struct Size
{
    public double Length { get; set;}
    public double Width { get; set;}
    public double Height { get; set;}

    public Size (double length, double width, double height)
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
    
    public Size Size { get; set; }

    public Vehicle (Brand _brand, Color _color)
    {
        Brand = _brand;
        Color = _color;
        Size = new Size(new Random().Next(3, 6), new Random().Next(1, 3), new Random().Next(1, 2));
    }

    public Vehicle (Brand _brand)
    {
        Brand = _brand;
        Color = Color.White;
        Size = new Size(new Random().Next(3, 6), new Random().Next(1, 3), new Random().Next(1, 2));
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

    public Car (Brand brand, string model, Color color)
    {
        Brand = brand;
        Model = model;
        Color = color;
    }

    public override string ToString()
    {
        double lengthInMeters = Size.Length;
        return $"A {Color} {lengthInMeters} meter long {Model} from {Brand}!";
    }
}


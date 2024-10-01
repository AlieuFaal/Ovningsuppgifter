using System.Formats.Asn1;

Circle circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");


// Square square = new Square(5);
// Console.WriteLine(square);
// Console.WriteLine($"Area: {square.Area:f2}");
// Console.WriteLine($"Circumference: {square.Circumference:f2}");

Console.ReadKey();
public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area { get; }

    public override double Circumference { get; }

    public Circle (double _radius)
    {
        Radius = _radius;
        Area = Math.Pow(_radius,2) * Math.PI;
        Circumference = 2 * Math.PI * _radius;
    }
}

class Square : Shape
{
    public override double Area { get; }

    public override double Circumference { get; }
}
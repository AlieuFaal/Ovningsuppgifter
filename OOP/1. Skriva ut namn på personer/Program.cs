Human human1 = new Human() {firstName = "Alle", lastName = "Falle"};

Human human2 = new Human() {firstName = "Alieu", lastName = "Faal", Mother = "Mariam Moore", Father = "Pa Faal"};

Human human3 = new Human() {firstName = "Mariam", lastName = "Moore" };

Human human4 = new Human() {firstName = "Pa", lastName = "Faal" };




// Console.WriteLine(human1.GetFullName());
// Console.WriteLine(human2.GetFullName());
// Console.WriteLine(human1.GetFullNameReversed());
// Console.WriteLine(human2.GetFullNameReversed());
Console.WriteLine(human2.Mother);
Console.WriteLine(human2.Father);
Console.WriteLine(human2.GetFullName("Mr."));
Console.WriteLine(human2.GetParents());
System.Console.WriteLine(human2.GetSelfAndParents());
human2.SetLength(1.94);
Console.WriteLine(human2.GetLength());
human2.SetWeight(90);
Console.WriteLine(human2.GetWeight());
Console.WriteLine(human2.GetBMI());


Console.ReadKey();


class Human
{
    public string firstName;

    public string lastName;

    public string Mother;

    public string Father;

    private double length;

    private double Weight;

    public void SetLength(double length)
    {
        this.length = length;
    }

    public double GetLength()
    {
        return length;
    }

    public void SetWeight(double Weight)
    {
        this.Weight = Weight;
    }

    public double GetWeight()
    {
        return Weight;
    }

    public double GetBMI()
    {
        return Weight / Math.Pow(length, 2);
    }

    public string GetFullName(string title)
    {
        return $"{title} {firstName} {lastName}";
    }

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }

    public string GetFullNameReversed()
    {
       char[] nameArray = GetFullName().ToCharArray();
       Array.Reverse(nameArray);
       return new string (nameArray); 
    }

    public string GetParents()
    {
        return $"{Mother}, {Father}";
    } 

    public string GetSelfAndParents()
    {
        return $"{GetFullName()} - Mamma: {Mother} - Pappa: {Father}";
    }
}      
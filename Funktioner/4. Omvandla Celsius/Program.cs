static double MyFunction (double myCelsius)
{
    double myFahrenheit;

    myFahrenheit = (myCelsius * 9/5) + 32; 

    return myFahrenheit;
}

System.Console.WriteLine(MyFunction (20));
while (true)

{
Console.Write("Skriv in en siffra: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write( "Vad vill du göra? ('+', '-', '*', '/'): "); 
char symbol = Convert.ToChar(Console.ReadLine ());

System.Console.Write("Skriv in en till siffra: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result; 

// char [] operation = {'+', '-', '*', '/'};

// char [] operationToDouble = Convert.ToDouble(operation);

if (symbol == '+')
{
    result = num1 + num2;
    System.Console.WriteLine(result);
}
else if (symbol == '-')
{
    result = num1 - num2;
    System.Console.WriteLine(result);
}

else if (symbol == '*')
{
    result = num1 * num2;
    System.Console.WriteLine(result);
}
 
else if (symbol == '/')
{
     if (num2 != 0);

     result = num1 / num2;
    
     System.Console.WriteLine(result);
}


else 
     {
        System.Console.WriteLine("Error Div / Zero");
     }

}
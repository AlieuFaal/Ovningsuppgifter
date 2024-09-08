static bool MyFunction (int mittHeltal, string minString)
{
    if (minString.Length >= mittHeltal)
    {
        return true;
    }
        else
        {
            return false;
        }
    
}

// bool result = MyFunction(5, "Kalle");
System.Console.WriteLine(MyFunction(5, "Kalle"));
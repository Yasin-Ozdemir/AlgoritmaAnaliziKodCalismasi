using System;

public class Power
{
    public static int Power(int a, int b)
    {
        int result = 1;
        int baseNum = a;  
        int exponent = b; 
        
        while (exponent > 0)
        {
            result *= baseNum;
            exponent -= 1;
        }
        
        return result;
    }

    
    public static void Main(string[] args)
    {
        int baseNumber = 2;
        int exponent = 8;
        int result = Power(baseNumber, exponent);
        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
    }
}
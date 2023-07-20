using System;
public class exponent
{
    public static void Main()
    {
        int num;
        int exp;
                
        Console.Write("Input Base number: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the Exponent : ");
        exp = Convert.ToInt32(Console.ReadLine());
        int value = 1;
        
        for (int i = 1; i <= exp; i++)
            value = value * num;
        Console.Write("The power of number is : " +value);
       
    }
   
}

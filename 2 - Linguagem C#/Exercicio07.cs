using System;
                    
public class Program
{  
    public static void Main()
    {
      int total = 2;
        for (int i = 0; i < 9; i++)
        {
            total *= 2;
        }
        Console.WriteLine("O total é: " + total);
    }
}
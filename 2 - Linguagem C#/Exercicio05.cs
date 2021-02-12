using System;
                    
public class Program
{
    public static void Main()
    {
        double saldo = 100.0;
        double valorSaque = 10.0;
        if (saldo >= valorSaque) {
            saldo -= valorSaque;
            Console.WriteLine("Saque realizado com sucesso");
        }
        else {
            Console.WriteLine("Saldo Insuficiente");
        }
        Console.WriteLine(saldo);
    }
}
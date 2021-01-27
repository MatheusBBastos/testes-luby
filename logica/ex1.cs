using System;

public class Fatorial
{
    private static long CalcularFatorial(int n)
    {
        if (n <= 1) {
            return 1;
        } else {
            return n * CalcularFatorial(n - 1);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalcularFatorial(14));
    }
}

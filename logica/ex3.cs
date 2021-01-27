using System;

public class Primos
{
    private static int ContarNumerosPrimos(int n)
    {
        // Crivo de Erastótenes
        bool[] naoPrimo = new bool[n + 1];
        double limite = Math.Sqrt(n);

        for (int i = 2; i <= limite; i++) {
            if (naoPrimo[i])
                continue;
            
            for (int j = i + i; j <= n; j += i) {
                naoPrimo[j] = true;
            }
        }

        int contagem = 0;
        for (int i = 2; i <= n; i++) {
            if (!naoPrimo[i]) {
                contagem++;
            }
        }

        return contagem;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(ContarNumerosPrimos(9));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class Vetores
{
    private static int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2) {
        return vetor1.Except(vetor2).Concat(vetor2.Except(vetor1)).ToArray();
    }

    public static void Main(string[] args)
    {
        // faltam elementos no vetor2
        int[] vetor1 = new int[] { 1,2,3,4,5 };
        int[] vetor2 = new int[] { 1,2,5 };
        Console.WriteLine(ObterElementosFaltantes(vetor1, vetor2).SequenceEqual(new int[] { 3, 4 })); //true 

        // faltam elementos no vetor3
        int[] vetor3 = new int[] { 1,4,5 };
        int[] vetor4 = new int[] { 1,2,3,4,5 };
        Console.WriteLine(ObterElementosFaltantes(vetor3, vetor4).SequenceEqual(new int[] { 2, 3 })); //true

        // faltam elementos em ambos vetores
        int[] vetor5 = new int[] { 1,2,3,4 };
        int[] vetor6 = new int[] { 2,3,4,5 };
        Console.WriteLine(ObterElementosFaltantes(vetor5, vetor6).SequenceEqual(new int[] { 1, 5 })); //true

        // não faltam items
        int[] vetor7 = new int[] { 1,3,4,5 };
        int[] vetor8 = new int[] { 1,3,4,5 };
        Console.WriteLine(ObterElementosFaltantes(vetor7, vetor8).SequenceEqual(new int[] { })); //true
    }
}

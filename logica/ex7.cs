using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

public class Pares
{
    private static int[] ObterElementosPares(int[] vetor) {
        List<int> pares = new List<int>();

        for (int i = 0; i < vetor.Length; i++) {
            if (vetor[i] % 2 == 0) {
                pares.Add(vetor[i]);
            }
        }

        return pares.ToArray();
    }

    public static void Main(string[] args)
    {
        int[] vetor = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(ObterElementosPares(vetor).SequenceEqual(new int[] { 2, 4 }));
    }
}

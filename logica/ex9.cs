using System;
using System.Collections.Generic;

public class Matrizes
{
    private static int[][] TransformarEmMatriz(string entrada) {
        List<int[]> listaFinal = new List<int[]>();
        string[] numeros = entrada.Split(',');

        List<int> listaAtual = new List<int>();

        for (int i = 0; i < numeros.Length; i++) {
            int num = int.Parse(numeros[i]);
            listaAtual.Add(num);
            if (listaAtual.Count == 2) {
                listaFinal.Add(listaAtual.ToArray());
                listaAtual.Clear();
            }
        }

        return listaFinal.ToArray();
    }

    public static void Main(string[] args)
    {
        int[][] a = TransformarEmMatriz("1,2,3,4,5,6");

        for (int i = 0; i < a.Length; i++) {
            for (int j = 0; j < a[i].Length; j++) {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

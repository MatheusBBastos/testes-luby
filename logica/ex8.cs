using System;
using System.Collections.Generic;
using System.Linq;

public class Busca
{
    private static string[] BuscarPessoa(string[] vetor, string busca) {
        List<string> resultados = new List<string>();

        for (int i = 0; i < vetor.Length; i++) {
            if (vetor[i].Contains(busca)) {
                resultados.Add(vetor[i]);
            }
        }

        return resultados.ToArray();
    }

    public static void Main(string[] args)
    {
        string[] vetor = new string[] {
            "John Doe",
            "Jane Doe",
            "Alice Jones",
            "Bobby Louis",
            "Lisa Romero"
        };

        Console.WriteLine(BuscarPessoa(vetor, "Doe").SequenceEqual(new string[] { "John Doe", "Jane Doe" }));
        Console.WriteLine(BuscarPessoa(vetor, "Alice").SequenceEqual(new string[] { "Alice Jones" }));
        Console.WriteLine(BuscarPessoa(vetor, "Louis").SequenceEqual(new string[] { "Bobby Louis" }));
    }
}

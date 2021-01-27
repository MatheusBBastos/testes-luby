using System;

public class Vogais
{
    private static int CalcularVogais(string texto)
    {
        texto = texto.ToLower();
        int contador = 0;
        char[] vogais = {'a', 'e', 'i', 'o', 'u'};

        for (int i = 0; i < texto.Length; i++) {
            if (Array.Exists(vogais, vogal => vogal == texto[i])) {
                contador++;
            }
        }

        return contador;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalcularVogais("Luby Software"));
    }
}

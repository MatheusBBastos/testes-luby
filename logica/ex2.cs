using System;

public class Premio
{
    private static double CalcularPremio(double valor, string tipo, double? fator)
    {
        if (valor <= 0) {
            Console.WriteLine("Números negativos ou menores que zero não são permitidos!");
            System.Environment.Exit(1);
        }

        if (fator.HasValue && fator.Value > 0) {
            return valor * fator.Value;
        }

        switch (tipo) {
            case "basic":
                return valor * 1;
            case "vip":
                return valor * 1.2;
            case "premium":
                return valor * 1.5;
            case "deluxe":
                return valor * 1.8;
            case "special":
                return valor * 2;
            default:
                Console.WriteLine("Tipo do prêmio não reconhecido!");
                System.Environment.Exit(1);
                break;
        }

        return valor;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalcularPremio(100, "vip", null));
        Console.WriteLine(CalcularPremio(100, "basic", 3));
    }
}

using System;
using System.Text.RegularExpressions;
using System.Globalization;

public class Desconto
{
    private static double ProcessarValor(string valor) {
        return Double.Parse(Regex.Replace(valor, "[^\\d,]", "").Replace(",", "."));
    }
    
    private static string FormatarValor(double valor) {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
        return valor.ToString("C", culture);
    }

    private static string CalcularValorComDescontoFormatado(string valor, string desconto)
    {
        double valorReal = ProcessarValor(valor);
        double descontoReal = ProcessarValor(desconto) / 100;

        return FormatarValor(valorReal * (1 - descontoReal));
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalcularValorComDescontoFormatado("R$ 6.800,00", "30%"));
    }
}

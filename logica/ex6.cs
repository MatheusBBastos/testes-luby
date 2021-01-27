using System;

public class Datas
{
    private static DateTime ProcessarData(string data) {
        return new DateTime(int.Parse(data.Substring(4, 4)), int.Parse(data.Substring(2, 2)), int.Parse(data.Substring(0, 2)));
    }

    private static int CalcularDiferencaData(string data1, string data2)
    {
        return Math.Abs((ProcessarData(data1) - ProcessarData(data2)).Days);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalcularDiferencaData("10122020", "25122020"));
    }
}

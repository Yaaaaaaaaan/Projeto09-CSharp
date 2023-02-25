using System;
using System.Globalization;

namespace Projeto09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a cotação do dólar; ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantitade de dólares a serem comprados; ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = ConversorDeMoeda.ConversorDolarReal(quantia, cotacao);
            Console.WriteLine("O valor a ser pago em reais é; " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}

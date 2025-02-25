using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        
        double soma = 0;
        int notasValidas = 0;

        while (notasValidas < 2)
        {
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                soma += nota;
                notasValidas++;
            }
        }

        double media = soma / 2;
        Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int C = int.Parse(Console.ReadLine()); 
        char T = char.Parse(Console.ReadLine()); 

        double[,] M = new double[12, 12];

        for (int j = 0; j < 12; j++)
        {
            for (int i = 0; i < 12; i++)
            {
                M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        double soma = 0.0;
        for (int i = 0; i < 12; i++)
        {
            soma += M[C, i];
        }

        if (T == 'S')
        {
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
        else if (T == 'M')
        {
            double media = soma / 12.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

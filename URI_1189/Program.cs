using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        char T = char.Parse(Console.ReadLine());

        double[,] M = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        double soma = 0.0;
        int contador = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (i > j && i + j < 11)
                {
                    soma += M[i, j];
                    contador++;
                }
            }
        }

        if (T == 'S')
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        else
            Console.WriteLine((soma / contador).ToString("F1", CultureInfo.InvariantCulture));
    }
}
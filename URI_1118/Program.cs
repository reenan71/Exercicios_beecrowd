using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        while (true)
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

            int opcao;
            do
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 1 && opcao != 2);

            if (opcao == 2)
            {
                break;
            }
        }
    }
}

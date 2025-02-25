using System;

class URI
{
    static void Main(string[] args)
    {
        int totalGrenal = 0;
        int numeroVitoriasInter = 0;
        int numeroVitoriaGremio = 0;
        int empate = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int golsInter = int.Parse(input[0]);
            int golsGremio = int.Parse(input[1]);

            if (golsInter > golsGremio)
            {
                numeroVitoriasInter++;
            }
            else if (golsGremio > golsInter)
            {
                numeroVitoriaGremio++;
            }
            else
            {
                empate++;
            }

            totalGrenal++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 2)
            {
                break;
            }
        }

        // Alteração: Impressão das estatísticas movida para fora do loop
        Console.WriteLine($"{totalGrenal} grenais");
        Console.WriteLine($"Inter:{numeroVitoriasInter}");
        Console.WriteLine($"Gremio:{numeroVitoriaGremio}");
        Console.WriteLine($"Empates:{empate}");

        if (numeroVitoriasInter > numeroVitoriaGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (numeroVitoriaGremio > numeroVitoriasInter)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}

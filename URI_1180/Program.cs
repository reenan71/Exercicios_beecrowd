using System;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); 
        string[] entrada = Console.ReadLine().Split(' '); 

        int[] valores = new int[N];
        for (int i = 0; i < N; i++)
        {
            valores[i] = int.Parse(entrada[i]);
        }

        int menorValor = valores[0];
        int posicaoMenor = 0;

        for (int i = 1; i < N; i++)
        {
            if (valores[i] < menorValor)
            {
                menorValor = valores[i];
                posicaoMenor = i;
            }
        }

        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Posicao: {posicaoMenor}");
    }
}

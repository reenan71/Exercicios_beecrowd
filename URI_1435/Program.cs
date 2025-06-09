using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 0)
                break;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int valor = Math.Min(Math.Min(i, j), Math.Min(N - 1 - i, N - 1 - j)) + 1;

                    if (j == 0)
                        Console.Write($"{valor,3}");
                    else
                        Console.Write($" {valor,3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}

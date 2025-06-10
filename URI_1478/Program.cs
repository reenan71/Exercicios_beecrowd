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

            int[,] M = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    M[i, j] = 1 + Math.Abs(i - j);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j == 0)
                        Console.Write($"{M[i, j],3}");
                    else
                        Console.Write($" {M[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); 
        }
    }
}

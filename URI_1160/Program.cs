using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < T; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int PA = int.Parse(inputs[0]);
            int PB = int.Parse(inputs[1]);
            double G1 = double.Parse(inputs[2]);
            double G2 = double.Parse(inputs[3]);

            int anos = 0;

            while (PA <= PB && anos <= 100)
            {
                // Aplica o crescimento corretamente
                PA = (int)(PA * (1 + G1 / 100));  // Aplica crescimento de A
                PB = (int)(PB * (1 + G2 / 100));  // Aplica crescimento de B
                anos++;
            }

            if (anos > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine($"{anos} anos.");
            }
        }
    }
}

using System; 

class URI {

    static void Main(string[] args)
    {

        double[] vetor = new double[100];

        for (int i = 0; i < 100; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine());
        }

        for(int i = 0; i < 100; i++)
        {
            if (vetor[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {vetor[i]:F1}");
            }
        }

    }

}
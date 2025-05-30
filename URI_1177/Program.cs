using System; 

class URI {

    static void Main(string[] args) { 

        int numero = int.Parse(Console.ReadLine());
        int[] vetor = new int[1000];
        for(int i = 0; i < 1000; i++)
        {
            vetor[i] = i % numero;
        }
    
        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"N[{i}] = {vetor[i]}");
        }
    }
}
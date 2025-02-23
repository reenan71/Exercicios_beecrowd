using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < N; i++)
        {
            string [] input = Console.ReadLine().Split(' ');
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            
            int minimo = Math.Min(X, Y);
            int maximo = Math.Max(X, Y);
            int soma = 0;
            
            for(int j = minimo + 1; j < maximo; j++)
            {
                if(j % 2 != 0)
                {
                    soma += j;
                }
            }
            Console.WriteLine(soma);
        }

    }

}
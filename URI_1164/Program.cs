using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            int X = int.Parse(Console.ReadLine());
            int soma = 0;
            
            for(int j = 1; j <= X / 2; j++)
            {
                if(X % j == 0)
                {
                    soma += j;
                }
            }
            
            if(soma == X)
            {
                Console.WriteLine($"{X} eh perfeito");
            }
            else
            {
                Console.WriteLine($"{X} não eh perfeito");
            }
        }

    }

}
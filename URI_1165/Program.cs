using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            int X = int.Parse(Console.ReadLine());
            int soma = 0;
            
            for(int j = 1; j <= X ; j++)
            {
                if(X % j == 0)
                {
                    soma++;
                }
            }
            
            if(soma == 2)
            {
                Console.WriteLine($"{X} eh primo");
            }
            else
            {
                Console.WriteLine($"{X} nao eh primo");
            }
        }

    }

}
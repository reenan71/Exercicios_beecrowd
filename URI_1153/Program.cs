using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        
        if(N > 0 && N < 13)
        {
            int fatorial = 1;
            for(int i = 1; i <= N; i++)
            {
                fatorial *= i;
            }
        
            Console.WriteLine(fatorial);
        }
    }

}
using System;

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int primeiro = 0;
        int segundo = 1;
        int serie = 0;
        
        for (int i = 0; i < N; i++)
        {
            if (i == 0)
            {
                Console.Write(primeiro);
            }
            else if (i == 1)
            {
                Console.Write(" " + segundo);
            }
            else
            {
                serie = primeiro + segundo;
                Console.Write(" " + serie);
                primeiro = segundo;
                segundo = serie;
            }
        }

        Console.WriteLine(); 
    }

}

using System; 

class URI {

    static void Main(string[] args) { 

        while(true) 
        {
            int X = int.Parse(Console.ReadLine());
            if (X == 0) break;

            if(X % 2 != 0) 
            {
                X += 1;
            }

            int soma = 0;
            for(int i = 0; i < 5; i++) 
            {
                soma += X;
                X += 2;
            }

            Console.WriteLine(soma);
        }
    }

}
using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++){
            string[] input = Console.ReadLine().Split(' ');
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            if(X % 2 == 0) {
                X += 1;
            }

            int soma = 0;
            for(int j = 0; j < Y; j++){
                soma += X + (j * 2);
            }

            Console.WriteLine(soma);
        }

    }

}
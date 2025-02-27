using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            int quadrado =  i * i;
            int quadrado2 = quadrado * i;
            
            Console.WriteLine(i + " " + quadrado + " " + quadrado2);
            Console.WriteLine(i + " " + (quadrado + 1) + " " + (quadrado2 + 1));
        }

    }

}
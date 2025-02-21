using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

        int totalCobaias = 0;
        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos  = 0;

        for(int i = 0; i < N; i++)
        {
          string [] entrada = Console.ReadLine().Split(' ');
          int quantia = int.Parse(entrada[0]);
          char tipo = char.Parse(entrada[1]);

          totalCobaias += quantia;

          switch(tipo)
          {
            case 'C':
            totalCoelhos += quantia;
            break;
            case 'R':
            totalRatos += quantia;
            break;
            case 'S':
            totalSapos += quantia;
            break;
          }
        }

        double percentualCoelhos = (double)totalCoelhos / totalCobaias * 100;
        double percentualRatos = (double)totalRatos / totalCobaias * 100;
        double percentualSapos = (double)totalSapos / totalCobaias * 100;

        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelhos}");
        Console.WriteLine($"Total de ratos: {totalRatos}");
        Console.WriteLine($"Total de sapos: {totalSapos}");
        Console.WriteLine($"Percentual de coelhos: {percentualCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentualRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentualSapos:F2} %");

    }

}
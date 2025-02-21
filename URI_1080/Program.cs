using System; 

class URI {

    static void Main(string[] args) { 

        int [] valores = new int[100];
        for(int i = 0; i < 100; i++)
        {
          valores[i] = int.Parse(Console.ReadLine());
        }

        int MaiorValor = valores[0];
        int posicao = 1;

        for (int i = 1; i < 100; i++)
        {
          if(valores[i] > MaiorValor)
          {
            MaiorValor = valores[i];
            posicao = i + 1;
          }
        }
        Console.WriteLine(MaiorValor);
        Console.WriteLine(posicao);
    }

}
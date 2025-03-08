using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());
        int Z = 0;

        do
        {
            Z = int.Parse(Console.ReadLine());
        }while(Z <= X);

        int soma = 0;
        int contador = 0;

        for(int i = X; soma <= Z; i++)
        {
            soma += i;
            contador++;
        }

        
        Console.WriteLine(contador);

    }

}
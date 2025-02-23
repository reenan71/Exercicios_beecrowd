using System; 

class URI {

    static void Main(string[] args) { 

       while(true)
       {
        string[] input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        if(m <=0 || n <= 0)
        {
            break;
        }
        int menor = Math.Min(m,n);
        int maior = Math.Max(m,n);
        int soma = 0;
        string sequencia = "";
        
        for(int i = menor; i <= maior; i++)
        {
            soma += i;
            sequencia += i + " ";
        }
        Console.WriteLine(sequencia + "Sum=" + soma);
       }

    }

}
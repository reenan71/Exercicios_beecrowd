using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int N = 0;

        // Ler o valor de N, garantindo que seja positivo
        for (int i = 1; i < valores.Length; i++) {
            N = int.Parse(valores[i]);
            if (N > 0) {
                break;
            }
        }

        // Se N ainda for negativo ou zero, pedir nova entrada até ser positivo
        while (N <= 0) {
            N = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        for (int i = 0; i < N; i++) {
            soma += (A + i);
        }

        Console.WriteLine(soma);
    }

}

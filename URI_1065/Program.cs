using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = new string[5];
        int contadorPares = 0;

        for (int i = 0; i < 5; i++)
        {
            input[i] = Console.ReadLine();
        }

        int valor1 = int.Parse(input[0]);
        int valor2 = int.Parse(input[1]);
        int valor3 = int.Parse(input[2]);
        int valor4 = int.Parse(input[3]);
        int valor5 = int.Parse(input[4]);

        if (valor1 % 2 == 0) contadorPares++;
        if (valor2 % 2 == 0) contadorPares++;
        if (valor3 % 2 == 0) contadorPares++;
        if (valor4 % 2 == 0) contadorPares++;
        if (valor5 % 2 == 0) contadorPares++;

        Console.WriteLine($"{contadorPares} valores pares");
    }
}

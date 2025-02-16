using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = new string[5];
        int contadorPares = 0;
        int contadorImpares = 0;
        int contadorPositivos = 0;
        int contadorNegativos = 0;

        for (int i = 0; i < 5; i++)
        {
            input[i] = Console.ReadLine();
        }

        int valor1 = int.Parse(input[0]);
        int valor2 = int.Parse(input[1]);
        int valor3 = int.Parse(input[2]);
        int valor4 = int.Parse(input[3]);
        int valor5 = int.Parse(input[4]);

        int[] valores = { valor1, valor2, valor3, valor4, valor5 };

        foreach (int valor in valores)
        {
            if (valor % 2 == 0) contadorPares++;
            else contadorImpares++;

            if (valor > 0) contadorPositivos++;
            else if (valor < 0) contadorNegativos++;
        }

        Console.WriteLine($"{contadorPares} valor(es) par(es)");
        Console.WriteLine($"{contadorImpares} valor(es) impar(es)");
        Console.WriteLine($"{contadorPositivos} valor(es) positivo(s)");
        Console.WriteLine($"{contadorNegativos} valor(es) negativo(s)");
    }
}

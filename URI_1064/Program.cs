using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int contador = 0;
        double soma = 0.0;
        

        for(int index = 0; index < 6; index++)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valor > 0)
            {
                contador++;
                soma += valor;
            }
        }

        Console.WriteLine($"{contador} valores positivos");
        if(contador > 0)
        {
            double media = soma / contador;
            Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
        }

    }

}
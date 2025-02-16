using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int contador = 0;

        for(int index = 0; index < 6; index++)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valor > 0)
            {
                contador++;
            }
        }

        Console.WriteLine($"{contador} valores positivos");

    }

}
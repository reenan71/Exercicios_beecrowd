using System;

class URI {

    static void Main(string[] args) {

        int[] valores = new int[15];
        int[] par = new int[5];
        int[] impar = new int[5];

        int contador_par = 0;
        int contador_impar = 0;

        for (int i = 0; i < 15; i++)
        {
            valores[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < 15; i++)
        {
            int valorAtual = valores[i]; 

            if (valorAtual % 2 == 0) 
            {
                par[contador_par] = valorAtual;
                contador_par++;

                if (contador_par == 5) 
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"par[{j}] = {par[j]}");
                    }
                    contador_par = 0; 
                }
            }
            else 
            {
                impar[contador_impar] = valorAtual;
                contador_impar++;

                if (contador_impar == 5) 
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"impar[{j}] = {impar[j]}");
                    }
                    contador_impar = 0; 
                }
            }
        }

        for (int j = 0; j < contador_impar; j++)
        {
            Console.WriteLine($"impar[{j}] = {impar[j]}");
        }

        for (int j = 0; j < contador_par; j++)
        {
            Console.WriteLine($"par[{j}] = {par[j]}");
        }
    }
}
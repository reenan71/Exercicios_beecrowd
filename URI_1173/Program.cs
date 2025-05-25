using System; 

class URI {

    static void Main(string[] args)
    {

        int[] numeros = new int[10];
        int i = 0;

        int X = int.Parse(Console.ReadLine());

        numeros[0] = X;

        for (i = 1; i < 10; i++)
        {
            numeros[i] = numeros[i - 1] * 2;
        }

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine($"N[{i}] = {numeros[i]}");  
        }


    }

}
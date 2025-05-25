using System; 

class URI {

    static void Main(string[] args)
    {

        int[] numeros = new int[20];

        for (int i = 0; i < 20; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(numeros);

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"N[{i}] = {numeros[i]}");
        }
        


    }

}
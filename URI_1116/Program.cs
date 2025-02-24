using System;
using System.Globalization; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] valores = Console.ReadLine().Split();
            double X = double.Parse(valores[0]);
            double Y = double.Parse(valores[1]);
            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double divisao = X / Y;
                Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
using System;
using System.Globalization; 

class URI {

    static void Main(string[] args) { 
        
        int N = int.Parse(Console.ReadLine());
        for(int index = 0; index < N; index++)
        {
          string [] valores = Console.ReadLine().Split(' ');
          double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
          double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
          double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
          
          double MediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

          Console.WriteLine(MediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

}
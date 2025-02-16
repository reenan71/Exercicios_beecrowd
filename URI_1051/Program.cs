using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string [] input = Console.ReadLine().Split(' ');
        double renda = double.Parse(input[0], CultureInfo.InvariantCulture);

        double imposto;

        if(renda <= 2000.0) {
            Console.WriteLine("Isento");
        }
        else if(renda <= 3000.0) {
            imposto = (renda - 2000.0) * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if(renda <= 4500.0) {
            imposto = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
        else {
            imposto = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }

    }

}

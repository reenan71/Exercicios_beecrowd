using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int percentual;
        double reajusteSalarial;

        if(salario <= 400.00)
        {
            percentual = 15;
            reajusteSalarial = salario * 0.15;
        }
        else if(salario <= 800.00)
        {
            percentual = 12;
            reajusteSalarial = salario * 0.12;
        }
        else if(salario <= 1200.00)
        {
            percentual = 10;
            reajusteSalarial = salario * 0.10;
        }
        else if(salario <= 2000.00)
        {
            percentual = 7;
            reajusteSalarial = salario * 0.07;
        }
        else
        {
            percentual = 4;
            reajusteSalarial = salario * 0.04;
        }

        double novoSalario = salario + reajusteSalarial;

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + reajusteSalarial.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + percentual + " %");

    }
}

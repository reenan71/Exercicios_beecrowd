using System; 

class URI {

    static void Main(string[] args) { 

        double S = 1;
        int numerador = 1;
        int denominador = 1;
        
        for(numerador = 3, denominador = 2; numerador <= 39; numerador += 2, denominador *= 2)
        {
            S += (double)numerador / denominador;
        }
        
        Console.WriteLine(S.ToString("F2"));
    }

}
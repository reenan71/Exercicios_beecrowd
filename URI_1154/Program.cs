using System; 

class URI {

    static void Main(string[] args) { 

        int somaCumulativa = 0;
        int contador = 0;
        double mediaIdade = 0;
        
        while(true)
        {
            int numerosPositivos = int.Parse(Console.ReadLine());
            
            if(numerosPositivos < 0)
            {
                break;
            }
            somaCumulativa += numerosPositivos;
            contador++;
        }
        if(contador > 0)
        {
            mediaIdade =  (double)somaCumulativa / contador;
            Console.WriteLine(mediaIdade.ToString("F2"));
        }
        
    }

}
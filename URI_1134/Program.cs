using System; 

class URI {

    static void Main(string[] args) { 

        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        while (true)
        {
            int tipo = int.Parse(Console.ReadLine());
            if (tipo == 1)
            {
                alcool++;
            }
            else if (tipo == 2)
            {
                gasolina++;
            }
            else if (tipo == 3)
            {
                diesel++;
            }
            else if (tipo == 4)
            {
                break;
            }
            else {
                continue;
            }
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool); 
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);

    }

}
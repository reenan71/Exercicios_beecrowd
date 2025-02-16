using System; 

class URI {

    static void Main(string[] args) { 

        string tipo = Console.ReadLine();
        string especie = Console.ReadLine();
        string alimentacao = Console.ReadLine();

        if(tipo == "vertebrado")
        {
            if(especie == "ave")
            {
                if(alimentacao == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }
            }
            else
            {
                if(alimentacao == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        if(tipo == "invertebrado")
        {
            if(especie == "inseto")
            {
                if(alimentacao == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }
            else
            {
                if(alimentacao == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }

    }

}

using System; 

class URI {

    static void Main(string[] args) { 
        while(true){
            int senhaFixa = 2002;
            int senha = int.Parse(Console.ReadLine());
        
            if(senha == senhaFixa){
            Console.WriteLine("Acesso Permitido");
            break;
            }else{
            Console.WriteLine("Senha Invalida");
            }
        }
        
    }

}
using System; 

class URI {

    static void Main(string[] args) { 
        
        while(true){
            string[] input = Console.ReadLine().Split(' ');
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            
            if(X == Y){
                break;
            }
        
            if(X < Y){
            Console.WriteLine("Crescente");
            }else{
            Console.WriteLine("Decrescente");
            }
        }
    }
}
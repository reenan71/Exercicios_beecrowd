using System; 

class URI {

    static void Main(string[] args) { 

        while(true){
            string [] input = Console.ReadLine().Split(' ');
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            
            if(X == 0 || Y == 0)
            {
                break;
            }
            
            if(X > 0 && Y > 0)
            {
                Console.WriteLine("primeiro");
            }
            if(X < 0 && Y > 0)
            {
                Console.WriteLine("segundo");
            }
            if(X < 0 && Y < 0)
            {
                Console.WriteLine("terceiro");
            }
            if(X > 0 && Y < 0)
            {
                Console.WriteLine("quarto");
            }
        }

    }

}
using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);
        
        for(int i = 1; i <= Y; i++)
        {
            if(i % X == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }

    }

}

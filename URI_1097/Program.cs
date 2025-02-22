
using System; 

class URI {

    static void Main(string[] args) { 

        int I = 1;
        int J = 7;


        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine($"I={I} J={J - j}");
            }
            I += 2;
            J += 2;
        }

    }

}